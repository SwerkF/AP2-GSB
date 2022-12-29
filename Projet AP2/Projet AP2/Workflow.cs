using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    internal class Workflow
    {
        private string reference;
        private int etape;
        private int decision;
        private DateTime date;
        Dictionary<DateTime, Etape> lesEtapes;

        //constructeur
        public Workflow(string reference, int etape, int decision, DateTime date)
        {
            this.reference = reference;
            this.etape = etape;
            this.decision = decision;
            this.date = date;
            this.lesEtapes = new Dictionary<DateTime, Etape>();
        }

        public string getReference()
        {
            return this.reference;
        }

        public int getEtape() { return this.etape; }



        public int getDecision() { return this.decision; }



        public DateTime getDate() { return this.date; }



        public Dictionary<DateTime, Etape> getEtapes() { return this.lesEtapes; }



        public void setDate(DateTime date) { this.date = date; }



        public void setEtape(int etape) { if (etape > this.etape) this.etape = etape; }



        public void setDecision(int decision) { this.decision = decision; }



        public void addEtape(DateTime date, Etape uneEtape)
        {
            if (this.lesEtapes.Keys.Contains(date)) return;
            else this.lesEtapes.Add(date, uneEtape);
        }
    }
}
