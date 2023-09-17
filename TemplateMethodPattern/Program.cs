using TemplateMethodPattern;

var kaffee = new Kaffee();
var tee = new Tee();

Console.WriteLine("Kaffee zubereiten:");
kaffee.RezeptZubereiten();

Console.WriteLine();
Console.WriteLine("Tee zubereiten:");
tee.RezeptZubereiten();