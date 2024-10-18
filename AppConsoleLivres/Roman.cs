using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman(string titre, string auteur, int nbrPages, string genre) : base (titre, auteur, nbrPages)
        {
            Genre = genre;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Le Roman {Genre} intitule {Titre} est de l'auteur {Auteur} comportant {NombrePages} pages.");
        }
    }
}
