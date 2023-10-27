using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetselprogramm
{
    abstract class StelleFrage
    {

        private int Punkte;

        public int punkte
        {
            get { return Punkte; }
            set { Punkte = value; }
        }
        public StelleFrage()
        {
            punkte = 0;
        }
        public abstract void displayQuiz();

    }
}
