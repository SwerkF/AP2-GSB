using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    internal class Famille
    {
        public string codeFamille;
        public string libelle;
        public int nbMed;

        //constructeur
        public Famille(string codeFamille, string libelle, int nbMed)
        {
            this.codeFamille = codeFamille;
            this.libelle = libelle;
            this.nbMed = nbMed;
        }
        public string getCodeFamille()
        {
            return this.codeFamille;
        }
        public string getLibelle()
        {
            return this.libelle;
        }
        public int getNbMed()
        {
            return this.nbMed;
        }

    }
}
