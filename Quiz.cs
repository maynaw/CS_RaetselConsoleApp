using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetselprogramm
{
    class Quiz : StelleFrage
    {
        private string Id;

        public string id
        {
            get { return Id; }
            set { Id = value; }
        }

        //private int Punkte;

        //public int punkte
        //{
        //    get { return Punkte; }
        //    set { Punkte = value; }
        //}

        private List<Frage> Fragen;



        public Quiz():base (){
            Fragen = new List<Frage>(); }

        public void add(Frage frage)
        {
            Fragen.Add(frage);
        }

        public override void displayQuiz()
        {
            
            try { 
                string inputA = "";
                bool richtigAntwort = false;
                for (int i = 0; i < Fragen.Count; i++)
                {
                    Console.WriteLine(Fragen[i].text);
                    Fragen[i].displayMoeglichAntworten();
                    inputA = Console.ReadLine();
                    if (inputA == "a" || inputA == "b" || inputA == "c" || inputA == "d")
                    {
                        Fragen[i].findById(inputA);
                        richtigAntwort = Fragen[i].isAntwortRichtig(inputA);
                        if (richtigAntwort == true)
                        {
                            punkte++;
                        }
                    }else
                    {
                        Console.WriteLine("falsche eingabe bitte druecken Sie eingabeTaste");
                        i--;
                        Console.ReadLine();
                    }
                }
                Console.Write("Ihre Punkte ist " + punkte + " ");
                if(punkte == 10)
                {
                    Console.WriteLine("sehr gut");
                }else if(punkte >= 7)
                {
                    Console.WriteLine("gut");

                }
                else
                {
                    Console.WriteLine("eher schlecht");
                }
                punkte = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

