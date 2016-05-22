HerbRecon list maker remarks
===

# Wikipedia

Nalezne přesný název stránky na základě `query`:

`https://cs.wikipedia.org/w/api.php?format=json&action=opensearch&search={query}&limit=10&format=json`

[Příklad](https://cs.wikipedia.org/w/api.php?format=json&action=opensearch&search=Sedmikraska&limit=10&format=jsonfm)

Vrátí tzv. [taxobox](https://cs.wikipedia.org/wiki/%C5%A0ablona:Taxobox) a zároveň obrázky na dané Wikipedia stránce

`https://cs.wikipedia.org/w/api.php?action=query&titles={title}&prop=revisions|images&rvprop=content&rvsection=0&format=json`

[Příklad](https://cs.wikipedia.org/w/api.php?action=query&titles=Sedmikr%C3%A1ska%20chudobka&prop=revisions|images&rvprop=content&rvsection=0&format=jsonfm)