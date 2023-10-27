using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetselprogramm
{
    class Frage
    {
        private string Text;

        public string text
        {
            get { return Text; }
            set { Text = value; }
        }

        private List<MoeglicheAntwort> MoeglicheAntworts;

        public List<MoeglicheAntwort> moeglicheAntworts
        {
            get { return MoeglicheAntworts; }
            set { MoeglicheAntworts = value; }
        }

        public void addMoeglicheAntwort(MoeglicheAntwort moeglicheAntwot)
        {
            MoeglicheAntworts.Add(moeglicheAntwot);
        }

        public Frage(string text)
        {
            this.Text = text;
            MoeglicheAntworts = new List<MoeglicheAntwort>();
        }


        public void displayMoeglichAntworten()
        {
            for (int i = 0; i < MoeglicheAntworts.Count; i++)
            {
                Console.WriteLine(moeglicheAntworts[i].id + ". " + moeglicheAntworts[i].text);
            }
        }

        public MoeglicheAntwort findById(string inputA)
        {
            MoeglicheAntwort erg = null;
            for (int i = 0; i < MoeglicheAntworts.Count; i++)
            {
                if (moeglicheAntworts[i].id == inputA)
                {
                    erg = moeglicheAntworts[i];
                    break;
                }
               
            }
            return erg;
        }
        public bool isAntwortRichtig(string inputA)
        {
            bool erg = false;
            try
            {
                if(inputA != null)
                {
                    if (findById(inputA.ToLower()).richtig == true)
                    {
                        erg = true;
                    }
                }
                else { }  
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return erg;
        }
    }
}
