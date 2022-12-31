using System;
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
