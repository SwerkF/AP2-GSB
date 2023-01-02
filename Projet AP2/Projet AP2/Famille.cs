<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    //Class Famille
    internal class Famille
    {

        //Variables

        private string code;
        private string libelle;


        //Constructeur

        public Famille(string unCode, string unLibelle)
        {
            this.code = unCode;
            this.libelle = unLibelle;
        }

        //Getter
        public string getCode()
        {
            return this.code;
        }
    }
}
=======
﻿using System;
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
>>>>>>> featurethomas
