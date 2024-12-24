using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using ExerciceLesSalaries_24_12_24.classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation des variables:
            List<Salarie> salaries = new List<Salarie>();
            double salaireTotalDeLEntreprise = 0;
            double salaireMoyenDeLEntreprise = 0;

            //Message de bienvenue:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Bienvenue sur la portail \"Salarié.e.s\" de Zirgi Vopp Inc. (Antenne Terrestre)");
            Console.ResetColor();

            //Utilisation du constructeur pour instancier des salariés:
            Salarie AdorpA = new Salarie("Adorp Aderpman", "Développement Gnorpien");
            Salarie BorduB = new Salarie("Bordü Bolpville", "Développement Gnorpien", 100);
            Salarie ConglupC = new Salarie("Conglup de Congdorp", "Ressources Aliens", 300);
            Salarie AlisonW = new Salarie("Alison Wheeler", "Département Clown", 89000);
            Salarie DerpD = new Salarie("Derp Derpnaught", "Ressources Aliens", 200);
            Salarie ErnpE = new Salarie("Ernp Ermanerp", "Développement Gnorpien");
            Salarie salarie1;

            Console.WriteLine("Entrer nouveau salarié : nom, service, salaire :");
            salarie1 = new Salarie(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));

            //Ajout des salariés à la liste des salariés:
            salaries.Add(AdorpA);
            salaries.Add(BorduB);
            salaries.Add(ConglupC);
            salaries.Add(AlisonW);
            salaries.Add(DerpD);
            salaries.Add(ErnpE);
            salaries.Add(salarie1);

            //Affichage des infos sur l'entreprise:
            InformationGlobalesDeLEntreprise();
            Console.WriteLine("");//<--Passage de ligne.
            Equipe();
            Console.ResetColor();
            Reinitialisation();


            //FONCTION INFORMATION GLOBALES DE L'ENTREPRISE:
            void InformationGlobalesDeLEntreprise()
            {
                foreach(Salarie salarie in salaries)//<--Calcul de la somme des salaires de l'entreprise.
                {
                    salaireTotalDeLEntreprise += salarie.Salaire;
                };
                salaireMoyenDeLEntreprise /= salaries.Count;//<--Calcul de la moyenne des salaires de l'entreprise.

                Titrage("INFORMATION GLOBALES SUR L'ENTREPRISE");
                Console.WriteLine($"Nombre de salarié.e.s : {salaries.Count}" +
                    $"\nSalaire Totale : {salaireTotalDeLEntreprise} glimbs/mois" +
                    $"\nSalaire Moyen : {salaireMoyenDeLEntreprise} glimbs/mois");
            }

            //FONCTION EQUIPE
            void Equipe()
            {
                Titrage("NOTRE ÉQUIPE");
                foreach (Salarie salarie in salaries)
                {
                    Console.WriteLine($"{salarie.Nom}, du service {salarie.Service}, gagne {salarie.Salaire} glimbs/mois.");
                }
            }

            //FONCTION RÉINITIALISATION
            void Reinitialisation()
            {
                salaireMoyenDeLEntreprise = 0;
                salaireTotalDeLEntreprise = 0;
            }

            //FONCTION TITRAGE:
            //Affichage d'un titre encadré en jaune
            void Titrage(string titre)
            {
                titre = $"║ {titre} ║";
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("╔");
                for (int i = 0; i < titre.Length - 2; i++)
                {
                    Console.Write("═");
                };
                Console.WriteLine("╗");
                Console.WriteLine(titre);
                Console.Write("╚");
                for (int i = 0; i < titre.Length - 2; i++)
                {
                    Console.Write("═");
                };
                Console.WriteLine("╝");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}