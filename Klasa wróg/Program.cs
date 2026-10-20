namespace Klasa_wróg;
class Przeciwnik
{
    protected string nazwa;
     protected int hp;
    protected int obrazenia;
    public static Przeciwnik stworz_przeciwnika(string nazwa, int hp, int obrazenia)
    {
        Przeciwnik p = new Przeciwnik();
        p.nazwa = nazwa;
        p.hp = hp;
        p.obrazenia = obrazenia;
        return p;
    }
    public void wypisz()
    {
        Console.WriteLine($"Nazwa: {nazwa} Hp: {hp} Obrażenia: {obrazenia} Obrażenia od ognia:");
    }
    public static void Main(string[] args)
    {
        
       Przeciwnik Goblin = Przeciwnik.stworz_przeciwnika("Goblin", 25, 2);
        Smok smok = Smok.stworz_smoka("Smokor", 100, 450, 500);
        Console.WriteLine($"Obrażenia od ognia: {smok.obrazenia_ogien}");
        Goblin.wypisz();
        smok.wypisz();
    }
}