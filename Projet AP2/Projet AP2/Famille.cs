using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    internal class Famille
    {
        private string code;
        private string libelle;

        public Famille(string unCode, string unLibelle)
        {
            this.code = unCode;
            this.libelle = unLibelle;
        }

        public string getCode()
        {
            return this.code;
        }
    }
}
