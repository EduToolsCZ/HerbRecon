HerbRecon list maker
===

Tato část software nepřístupná uživateli je využívána pro automatické generování kolekcí `Herb` objektů pomocí Wikipedie.

`HerbReconListMaker.exe` je spustitelný soubor této aplikace.

## Příkazy

**`fetch [path]`**

- `path` - cesta k souboru, obsahujícímu jeden název rostliny na každé řádce
- tento příkaz vytvoří kolkci objektů `Herb` a vypíše vše ve formátu Json do složky s názvem `Output`
- v případě konfliktů názvů rostlin s jinými Wikipedia články bude uživatel dotázán na správný článek
- v případě nenalezení rostliny bude uživatel upozorněn a daná rostlina bude mít u většiny vlastností hodnoty `null`

- soubory ve složce `Output`:

 ```csharp
 Herbs.json // JavaScript objekt na jedné řádce
 HerbsFormatted.json // Pro lidské oko čitelná verze předchozího souboru
 md5.txt // MD5 hash souboru Herbs.json
 ```

**`check`**

- spustí GUI sloužící k úpravě souborů vygenerovaných příkazem uvedeným výše

**`help`**

- vypíše všechny příkazy

**`exit`**

- ukončí aplikaci