using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PJM_methodology_picker
{
    enum Atribute
    {
        Buget,
        Cerinte,
        Ciclu_De_Dezvoltare,
        Domeniu_Aplicare,
        Managementul_Partilor_Interesate,
        Marimea_Echipei,
        Obiectivele,
        Planificarea_Managementului_de_Proiect,
        Resursele,
        Timpul
    }

    enum Metodologii
    {
        Agile,
        Waterfall,
        Ambele
    }
    internal class Methodology
    {
        private int counter_Agile;
        private int counter_Waterfall;
        private string proj_Name;

        // --- Create dictionary
        private readonly Dictionary<Atribute, Metodologii> mapping_dict = new Dictionary<Atribute, Metodologii>();

        // default constructor
        public Methodology()
        {
            this.counter_Agile = 0;
            this.counter_Waterfall = 0;
            this.proj_Name = "numele proiectului";
        }

        // getters
        public int getCountAgile()
        {
            return this.counter_Agile;
        }

        public int getCounterWaterfall()
        {
            return this.counter_Waterfall;
        }

        public Dictionary<Atribute, Metodologii> getDict()
        { 
            return this.mapping_dict; 
        } 

        // helper methods
        public void addToDict(Atribute atr, Metodologii mtd)
        {
            this.mapping_dict.Add(atr, mtd);
        }

        public void incrementAgile()
        {
            this.counter_Agile += 1;
            Console.WriteLine("Agile methodology +1 pt");
        }

        public void incrementWaterfall()
        {
            this.counter_Waterfall += 1;
            Console.WriteLine("Waterfall methodology +1 pt");
        }

        public void consoleDisplayResult()
        {
            Console.WriteLine("Agile final score: " + this.counter_Agile);
            Console.WriteLine("Waterfall final score: " + this.counter_Waterfall);
        }

        public void resetCounters()
        {
            this.counter_Agile = 0;
            this.counter_Waterfall = 0;
        }

        public void checkSelection(Atribute atrib) 
        {
            if (this.counter_Agile == this.counter_Waterfall)
            {
                this.addToDict(atrib, Metodologii.Ambele);
            }
            else if (this.counter_Agile > this.counter_Waterfall)
            {
                this.addToDict(atrib, Metodologii.Agile);
            }
            else 
            {
                this.addToDict(atrib, Metodologii.Waterfall);
            }

            this.resetCounters();
        }

        public void printDictToConsole() 
        {
            Console.WriteLine("------------------------------------------");
            foreach (var kv_pair in this.mapping_dict) 
            {
                Console.WriteLine("{0} -> {1}", kv_pair.Key, kv_pair.Value);
            }
        }
    }
}
