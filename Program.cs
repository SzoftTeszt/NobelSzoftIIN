using Microsoft.EntityFrameworkCore;
using NobelDij.Data;
using NobelDij.Models;

NobelDijContext _context = new NobelDijContext();

if (!_context.Tipusok.Any())
{
    string[] sorok = File.ReadAllLines("C:\\Users\\Tanar\\Desktop\\Nobel\\Fajtak.txt");
    foreach (var sor in sorok) {
        var f = new NobelDij.Models.Fajta(sor);
        _context.Tipusok.Add(f);
    }
    _context.SaveChanges();


}if (!_context.Dijak.Any())
{
    string[] sorok2 = (File.ReadAllLines(@"C:\Users\Tanar\Desktop\Nobel\Nobel.csv"));
    var sorok = sorok2.Skip(1);
    foreach (var sor in sorok) {
        string[] adatok = sor.Split(';');
        Fajta tipus = _context.Tipusok.Where(x => x.Tipus == adatok[1]).FirstOrDefault();
        Console.WriteLine("Első"+String.Join(';',adatok));
        _context.Dijak.Add(new Dij(Convert.ToInt32(adatok[0]), tipus, adatok[2], adatok[3]));
     }
    _context.SaveChanges();
}
// Artur B. McDonald

var artur = _context.Dijak.Where(x => (x.KeresztNev == "Arthur B.") && (x.VezetekNev == "McDonald")).Select(x => x.Tipus).FirstOrDefault();
if (artur is not null)
    Console.WriteLine("Artur B. McDonald " + artur.Tipus + " Nobel Díjat kapott!");
else Console.WriteLine("Artur B. McDonald nem kapott díjat!");



foreach (var item in _context.Tipusok)
{
    Console.WriteLine(item);
}foreach (var item in _context.Dijak)
{
    Console.WriteLine("Díj:"+ item);
}
