using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLesSalaries_24_12_24.classes
{
    internal class Salarie
    {
        //ATTRIBUTS:
        private String _nom;
        private String _service;
        private double _salaire;

        //PROPRIÉTÉS:
        public String Nom { get { return _nom; } set { _nom = value; } }
        public String Service { get { return _service; } set { _service = value; } }
        public double Salaire { get { return _salaire; } set { if (value < 100 || value > 100000) { throw new ArgumentOutOfRangeException("Le salaire doit être supérieur au SMIC de Virzoble (0 glimb)"); } _salaire = value; } }

        //CONSTRUCTEUR:
        public Salarie(String nom, String service, double salaire)
        {
            Nom = nom;
            Service = service;
            Salaire = salaire;
        }

        //CONSTRUCTEUR SALAIRE PAR DÉFAUT:
        public Salarie(String nom, String service)
        {
            Nom = nom;
            Service = service;
            Salaire = 100;
        }

        //CONSTRUCTEUR PAR DÉFAUT:
        public Salarie()
        {
            Nom = "Alan Smithee";
            Service = "Global Vorping";
            Salaire = 100;
        }

        //MÉTHODE AFFICHAGE SALAIRE:
        public void AffichageDuSalaire(Salarie salarie)
        {
            Console.WriteLine($"Le.a salarié.e {Nom} gagne un salaire mensuel de {salarie.Salaire} glinbs");
        }

        //MÉTHODE RÉINITIALISER:
        public void Reinitilisation()
        {
            Nom = "";
            Service = "";
            Salaire = 100;
        }
    }
}

