using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetselprogramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz1 = new Quiz();
            Frage frage1_1 = new Frage("Welches Land grenzt am Westen Spaniens?");
            Frage frage1_2 = new Frage("Wie heißt der höchste Berg Deutschlands?");
            Frage frage1_3 = new Frage("Welcher Fluss fließt durch die Hauptstadt Österreichs?");
            Frage frage1_4 = new Frage("Cardiff ist die Hauptstadt von ...");
            Frage frage1_5 = new Frage("Welches Land liegt zwischen Frankreich und Spanien?");
            Frage frage1_6 = new Frage("Was ist das größte Tier der Welt?");
            Frage frage1_7 = new Frage("Wie heißt der höchste Berg der Welt?");
            Frage frage1_8 = new Frage("Wie viele Flügel hat ein Schmetterling?");
            Frage frage1_9 = new Frage("Ab wie vielen Jahren ist man in Deutschland volljährig?");
            Frage frage1_10 = new Frage("Auf welchem Kontinent liegt Deutschland?");

            MoeglicheAntwort m1_1a = new MoeglicheAntwort("a", "Frankreich", false);
            MoeglicheAntwort m1_1b = new MoeglicheAntwort("b", "Marokko", false);
            MoeglicheAntwort m1_1c = new MoeglicheAntwort("c", "Portugal", true);
            MoeglicheAntwort m1_1d = new MoeglicheAntwort("d", "Andorra", false);

            MoeglicheAntwort m1_2a = new MoeglicheAntwort("a", "Mattehorn", false);
            MoeglicheAntwort m1_2b = new MoeglicheAntwort("b", "Waxenstein", false);
            MoeglicheAntwort m1_2c = new MoeglicheAntwort("c", "Mont blanc", false);
            MoeglicheAntwort m1_2d = new MoeglicheAntwort("d", "Zugspitze", true);

            MoeglicheAntwort m1_3a = new MoeglicheAntwort("a", "Moldau", false);
            MoeglicheAntwort m1_3b = new MoeglicheAntwort("b", "Donau", true);
            MoeglicheAntwort m1_3c = new MoeglicheAntwort("c", "Rhein", false);
            MoeglicheAntwort m1_3d = new MoeglicheAntwort("d", "Mur", false);

            MoeglicheAntwort m1_4a = new MoeglicheAntwort("a", "Schottland", false);
            MoeglicheAntwort m1_4b = new MoeglicheAntwort("b", "Wales", true);
            MoeglicheAntwort m1_4c = new MoeglicheAntwort("c", "Gibraltar", false);
            MoeglicheAntwort m1_4d = new MoeglicheAntwort("d", "Nordirland", false);

            MoeglicheAntwort m1_5a = new MoeglicheAntwort("a", "Andorra", true);
            MoeglicheAntwort m1_5b = new MoeglicheAntwort("b", "San Marino", false);
            MoeglicheAntwort m1_5c = new MoeglicheAntwort("c", "Albanien", false);
            MoeglicheAntwort m1_5d = new MoeglicheAntwort("d", "Monaco", false);

            MoeglicheAntwort m1_6a = new MoeglicheAntwort("a", "Elefant", false);
            MoeglicheAntwort m1_6b = new MoeglicheAntwort("b", "Giraffe", false);
            MoeglicheAntwort m1_6c = new MoeglicheAntwort("c", "Blauwal", true);
            MoeglicheAntwort m1_6d = new MoeglicheAntwort("d", "Braunbär", false);

            MoeglicheAntwort m1_7a = new MoeglicheAntwort("a", "Alpen", false);
            MoeglicheAntwort m1_7b = new MoeglicheAntwort("b", "Zugspitze", false);
            MoeglicheAntwort m1_7c = new MoeglicheAntwort("c", "Annapurna", false);
            MoeglicheAntwort m1_7d = new MoeglicheAntwort("d", "Mount Everest", true);

            MoeglicheAntwort m1_8a = new MoeglicheAntwort("a", "vier", true);
            MoeglicheAntwort m1_8b = new MoeglicheAntwort("b", "zwei", false);
            MoeglicheAntwort m1_8c = new MoeglicheAntwort("c", "sechs", false);
            MoeglicheAntwort m1_8d = new MoeglicheAntwort("d", "fuemf", false);

            MoeglicheAntwort m1_9a = new MoeglicheAntwort("a", "16", false);
            MoeglicheAntwort m1_9b = new MoeglicheAntwort("b", "18", true);
            MoeglicheAntwort m1_9c = new MoeglicheAntwort("c", "20", false);
            MoeglicheAntwort m1_9d = new MoeglicheAntwort("d", "21", false);

            MoeglicheAntwort m1_10a = new MoeglicheAntwort("a", "Asien", false);
            MoeglicheAntwort m1_10b = new MoeglicheAntwort("b", "Afrika", false);
            MoeglicheAntwort m1_10c = new MoeglicheAntwort("c", "Europa", true);
            MoeglicheAntwort m1_10d = new MoeglicheAntwort("d", "Nordamerika", false);

            frage1_1.addMoeglicheAntwort(m1_1a);
            frage1_1.addMoeglicheAntwort(m1_1b);
            frage1_1.addMoeglicheAntwort(m1_1c);
            frage1_1.addMoeglicheAntwort(m1_1d);

            frage1_2.addMoeglicheAntwort(m1_2a);
            frage1_2.addMoeglicheAntwort(m1_2b);
            frage1_2.addMoeglicheAntwort(m1_2c);
            frage1_2.addMoeglicheAntwort(m1_2d);

            frage1_3.addMoeglicheAntwort(m1_3a);
            frage1_3.addMoeglicheAntwort(m1_3b);
            frage1_3.addMoeglicheAntwort(m1_3c);
            frage1_3.addMoeglicheAntwort(m1_3d);

            frage1_4.addMoeglicheAntwort(m1_4a);
            frage1_4.addMoeglicheAntwort(m1_4b);
            frage1_4.addMoeglicheAntwort(m1_4c);
            frage1_4.addMoeglicheAntwort(m1_4d);

            frage1_5.addMoeglicheAntwort(m1_5a);
            frage1_5.addMoeglicheAntwort(m1_5b);
            frage1_5.addMoeglicheAntwort(m1_5c);
            frage1_5.addMoeglicheAntwort(m1_5d);


            frage1_6.addMoeglicheAntwort(m1_6a);
            frage1_6.addMoeglicheAntwort(m1_6b);
            frage1_6.addMoeglicheAntwort(m1_6c);
            frage1_6.addMoeglicheAntwort(m1_6d);

            frage1_7.addMoeglicheAntwort(m1_7a);
            frage1_7.addMoeglicheAntwort(m1_7b);
            frage1_7.addMoeglicheAntwort(m1_7c);
            frage1_7.addMoeglicheAntwort(m1_7d);

            frage1_8.addMoeglicheAntwort(m1_8a);
            frage1_8.addMoeglicheAntwort(m1_8b);
            frage1_8.addMoeglicheAntwort(m1_8c);
            frage1_8.addMoeglicheAntwort(m1_8d);

            frage1_9.addMoeglicheAntwort(m1_9a);
            frage1_9.addMoeglicheAntwort(m1_9b);
            frage1_9.addMoeglicheAntwort(m1_9c);
            frage1_9.addMoeglicheAntwort(m1_9d);

            frage1_10.addMoeglicheAntwort(m1_10a);
            frage1_10.addMoeglicheAntwort(m1_10b);
            frage1_10.addMoeglicheAntwort(m1_10c);
            frage1_10.addMoeglicheAntwort(m1_10d);

            quiz1.add(frage1_1);
            quiz1.add(frage1_2);
            quiz1.add(frage1_3);
            quiz1.add(frage1_4);
            quiz1.add(frage1_5);
            quiz1.add(frage1_6);
            quiz1.add(frage1_7);
            quiz1.add(frage1_8);
            quiz1.add(frage1_9);
            quiz1.add(frage1_10);
            Mathe m = new Mathe();


            do
            {
                string input = "";
                Console.WriteLine("Drucken Sie bitte Q  für Quiz, M für Mathe or x für aussteigen");
                try
                {
                    input = Console.ReadLine();
                    string startOrEnd = input.ToUpper();
                    if (startOrEnd == "Q")
                    {
                        quiz1.displayQuiz();

                    }
                    else if (startOrEnd == "M")
                    {
                        m.displayQuiz();
                    }
                    else if (startOrEnd == "X")
                    {
                        Console.WriteLine("Jetzt steige ich aus! goodbye");
                        // private static object breack;
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("falsche eingabe");
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);

        }
    }
}
