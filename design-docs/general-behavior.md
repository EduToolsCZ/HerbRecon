HerbRecon - obecné chování aplikace
===

# Obsah
1. [Instalace a auto-update](#dd-part1)
2. [První spuštění](#dd-part2)
3. [Proces zkoušení](#dd-part3)

<div id="dd-part1" />

# Instalace a auto-update
**Využívá 3rd party tool**: [Squirrel for Windows](https://github.com/Squirrel/Squirrel.Windows)

Proces instalace neobsahuje žádné dialogy, včetně UAC. Instalace probíhá na pozadí a
ihned po jejím dokončení je uživateli ukázáno hlavní okno aplikace a jsou zřízeny shortcuty
na ploše a v nabídce Start.

Proces aktualizace je také tichý a probíhá na pozadí bez interakce s uživatelem. Po spuštění aplikace
je zkontrolována aktuálnost verze. Pokud je dostupná nová verze aplikace, je stažena a shortcuty
nahrazeny. Po příštím spuštění aplikace je spuštěna verze nová. Uživatel není tázán k restartu aplikace
ani upozorňován na novou verzi.

<div id="dd-part2" />

# První spuštění
Po prvním spuštění je z předurčené URL staženo aktuální pole ve formátu JSON, které obsahuje objekty - byliny,
které jsou předmětem zkoušení.
Objekt bylina má tyto vlastnosti:
- název (sedmikráska chudobka)
- latinský název (*Bellis perennis*)
- čeleď (hvězdnicovité)
- URL k obrázkům ([1](https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Bellis_perennis_dsc00906.jpg/880px-Bellis_perennis_dsc00906.jpg), [2](http://www.prvnikrok.cz/www_old/clanky/obrazky/875/002.jpg))
    - obrázky jsou do JSON souboru vybírány náhodně, pomocí Google API a Wikimedia API

Soubor je poté uložen do lokálního souborového systému a jsou sledovány jeho změny v originální lokaci na síti, pomocí jeho MD5 hashe. V případě změny je stažena nová verze.
 
<div id="dd-part3" />  

# Proces zkoušení
Před zahájením zkoušení je uživatel dotázán, zda chce být zkoušen z těchto oblastí (`true`/`false`):
- pouze rod rostliny nebo i druh rostliny
- čeleď rostliny

Po zahájení je náhodně vybrána bylina z pole objektů.
Z objektu je náhodně vybrána URL, která bude použita.
Program poté zjistí, zda cache daný obrázek již obsahuje, pomocí
jeho MD5 hashe. Pokud ne, obrázek je stažen a pojmenován pomocí MD5 hashe URL.
Poté program čeká na vstup od uživatele do daných textových polí a ověří jejich podobnost s očekávanou odpovědí pomocí
[Levenštejnovy vzdálenosti](https://cs.wikipedia.org/wiki/Leven%C5%A1tejnova_vzd%C3%A1lenost).
Pokud je tato vzdálenost menší přiměřené konstantě, je odpověď přijmuta. To zabrání vyhodnocení odpovědi
jako špatné, pokud jde jen o překlep(y).

Na začátku zkoušení zkopíruji pole s bylinami, zabalenými do `TestObject`. Tak budu moci sledovat,
kolikrát uživatel danou bylinu již uhodl, jak si vedl atd. a přizpůsobit tomu vylučování bylin
ze seznamu zkoušených. Také budu sledovat, jak uživateli šlo určování v minulých zkoušeních a na základě toho
vybírat rostliny. Na uživatelovu žádost vytvořím tabulku se seznamem bylin a procentuální úspěšností.
Tato data a nastvení budou uchovávána v JSONu v lokálním souborovém systému.
