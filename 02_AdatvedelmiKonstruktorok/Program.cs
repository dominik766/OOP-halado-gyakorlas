using _02_AdatvedelmiKonstruktorok;
Bankszamla Anna = new Bankszamla("100");
Bankszamla Bela = new Bankszamla("200", 100000, 50000);
Anna.Befizetes(10000);
Bela.Kivetel(20000);
Console.WriteLine($"Anna szamlaszama: {Anna.Szamlaszam}, egyenlege: {Anna.Egyenleg}, hitelkerete: {Anna.HiteKeret}");
Console.WriteLine($"Bela szamlaszama: {Bela.Szamlaszam}, egyenlege: {Bela.Egyenleg}, hitelkerete: {Bela.HiteKeret}");