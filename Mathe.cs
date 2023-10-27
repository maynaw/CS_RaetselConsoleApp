using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetselprogramm
{
    class Mathe: StelleFrage
    {
        public Mathe():base()
        {
                
        }
        public override void displayQuiz()
        {

            try { 
                string userAntwort = "";
                int antwort = 0;
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("(" + i + " * 2) + ( " + i + " )");
                    Console.WriteLine(" = ");
                    userAntwort = Console.ReadLine();
                    antwort = ((i * 2) + (i));
                    int uAntwort = Int32.Parse(userAntwort);
                    if (antwort == uAntwort)
                    {
                        punkte++;
                    }
                }
                    Console.Write("Ihre Punkte ist " + punkte + " ");
                    if (punkte == 10)
                    {
                        Console.WriteLine("sehr gut");
                    }
                    else if (punkte >= 7)
                    {
                        Console.WriteLine("gut");

                    }
                    else
                    {
                        Console.WriteLine("eher schlecht");
                    }
                punkte = 0;
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}

