using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJM_methodology_picker
{
    internal class Methodology
    {
        private int counter_Agile;
        private int counter_Waterfall;

        // default constructor
        public Methodology()
        {
            this.counter_Agile = 0;
            this.counter_Waterfall = 0;
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

        // setters


        // helper methods
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
    }
}
