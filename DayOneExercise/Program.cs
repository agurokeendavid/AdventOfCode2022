using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DayOneExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var streamReader = new StreamReader("input.txt"))
            {
                int answer = 0; 
                var inputs = new List<int>();
                int current = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    if (line.Length > 0)
                    {
                        current += Convert.ToInt32(line);
                        continue;
                    }
                    answer = Math.Max(answer, current);
                    current = 0;
                }

                answer = Math.Max(answer, current);

                Console.WriteLine(answer);
            }
        }
    }
}