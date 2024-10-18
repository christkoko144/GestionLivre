using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }

        public Revue(string titre, string auteur, int nbrPages, int numero, int annee) : base (titre, auteur, nbrPages)
        {
            Numero = numero;
            Annee = annee;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"La revue numero {Numero} de l'auteur {Auteur} qui a pour titre {Titre} est sortie en {Annee} et compte {NombrePages} page.") ;
        }
    }
}
