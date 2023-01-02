<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{

    //Class étape

    class Etape
    {

        //Variables

        private int num;
        private string libelle;

        //Constructeur
        public Etape(int num, string libelle)
        {
            this.num = num;
            this.libelle = libelle;
        }

        //Getters
        public int getNum()
        {
            return this.num;
        }

        public string getLibelle()
        {
            return this.libelle;
        }

    }

    //Héritage de la classe Etape

    class Norme : Etape
    {

        //Variables

        private string norme;
        private DateTime dateNorme;

        //Constructeur
        public Norme(int num, string libelle, string norme, DateTime dateNorme) : base(num, libelle)
        {
            this.norme = norme;
            this.dateNorme = dateNorme;
        }

        //Getters
        public string getNorme()
        {
            return this.norme;
        }

        public DateTime getDateNorme()
        {
            return this.dateNorme;
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
    internal class Etape
    {
        private int num;
        private string libelle;
        
        //constructeur
        public Etape(int num, string libelle)
        {
            this.num = num;
            this.libelle = libelle;
        }
        public int getNum()
        {
            return this.num;
        }
        public string getLibelle()
        {
            return this.libelle;
        }
    }

    class Norme : Etape
    {
        private string norme;
        private DateTime dateNorme;

        //constructeur
        public Norme(int num, string libelle, string norme, DateTime dateNorme) : base(num, libelle)
        {
            this.norme = norme;
            this.dateNorme = dateNorme;
        }
        public string getNorme()
        {
            return this.norme;
        }
        public DateTime getDateNorme()
        {
            return this.dateNorme;
        }
    }
}
>>>>>>> featurethomas
