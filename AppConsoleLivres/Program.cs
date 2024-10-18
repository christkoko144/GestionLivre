using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        Revue revue1 = new Revue ("Sport&Sante", "Cesar DUBOIS", 60, 2, 2015);
        Revue revue2 = new Revue ("Passion", "Kader Diop", 150, 7, 2020);
        Revue revue3 = new Revue ("LeMonde", "Eliel Kouakou", 200, 4, 2023);

        revue1.AfficherDetails(); 
        revue2.AfficherDetails(); 
        revue3.AfficherDetails();

        Roman roman1 = new Roman("Le cahier noir", "Camara Nangala", 260, "Classique");
        Roman roman2 = new Roman("Les Frasques d'ebinto", "Amadou Kone", 316, "D'avanture");
        Roman roman3 = new Roman("La Planete des Singes", "Pierre Boule", 190, "science fiction");

        roman1.AfficherDetails();
        roman2.AfficherDetails();
        roman3.AfficherDetails();
    }
}