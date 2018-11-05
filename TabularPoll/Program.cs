using System;
using System.Collections.Generic;
using System.Linq;

namespace TabularPoll
{
    class Program
    {
        private static void ResultPrinter(List<int> questionData, string questionName)
        {
            Console.WriteLine("========================================");
            Console.WriteLine(questionName);
            Console.WriteLine("========================================");
            Dictionary<int, int> counts = questionData.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            counts.ToList().ForEach(val =>
            {
                Console.WriteLine($"Tipo {val.Key} existen {val.Value}");
            });
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string[] rawData = new string[] {
                "665777",
                "775667",
                "777777",
                "665777",
                "665676",
                "555666",
                "776666",
                "776777",
                "776777",
                "777776",
                "776777",
                "766777",
                "776777",
                "666774",   
                "775777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777",
                "777777"
            };

            var sourceData = rawData.ToList();

            List<int> q1 = new List<int>();
            List<int> q2 = new List<int>();
            List<int> q3 = new List<int>();
            List<int> q4 = new List<int>();
            List<int> q5 = new List<int>();
            List<int> q6 = new List<int>();

            sourceData.ForEach(item =>
            {
                for (int i = 0; i < item.Length; i++)
                {
                    int qValue = Convert.ToInt32(item.Substring(i, 1));

                    switch (i)
                    {
                        case 0:
                            q1.Add(qValue);
                            break;
                        case 1:
                            q2.Add(qValue);
                            break;
                        case 2:
                            q3.Add(qValue);
                            break;
                        case 3:
                            q4.Add(qValue);
                            break;
                        case 4:
                            q5.Add(qValue);
                            break;
                        case 5:
                            q6.Add(qValue);
                            break;
                    }
                }
            });


            ResultPrinter(q1, "Pregunta 1");
            ResultPrinter(q2, "Pregunta 2");
            ResultPrinter(q3, "Pregunta 3");
            ResultPrinter(q4, "Pregunta 4");
            ResultPrinter(q5, "Pregunta 5");
            ResultPrinter(q6, "Pregunta 6");



        }
    }
}
