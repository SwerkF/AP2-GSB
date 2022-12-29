using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    internal class Medicament
    {
        private string depot;
        private string nom;
        private string famille;
        private string composition;
        private string effets;
        private string contreIndication;

        //constructeur
        public Medicament(string depot, string nom, string famille, string composition, string effets, string contreIndication)
        {
            this.depot = depot;
            this.nom = nom;
            this.famille = famille;
            this.composition = composition;
            this.effets = effets;
            this.contreIndication = contreIndication;
        }

        public string getDepot()
        {
            return this.depot;
        }
        public string getNom()
        {
            return this.nom;
        }
        public string getFamille()
        {
            return this.famille;
        }
        public string getComposition()
        {
            return this.composition;
        }
        public string getEffets()
        {
            return this.effets;
        }
        public string getContreIndication()
        {
            return this.contreIndication;
        }
    }
}
