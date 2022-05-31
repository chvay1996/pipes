using System;
using System.Collections.Generic;

namespace pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pipec pipec = new Pipec();
            List<int> pipe = new List<int>();

            pipec.FillingList(pipe);

            pipec.ResultOutput(pipe);
    }
}

    class Pipec
    {
        public void FillingList(List<int> pipeFilling)
        {
            Console.Write("Введите количество размеров: ");
            int numberOfSizes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSizes; i++)
            {
                Console.Write($"Введите {i + 1} значение: ");
                int pipeSize = int.Parse(Console.ReadLine());
                pipeFilling.Add(pipeSize);
            }
        }

        public void ResultOutput(List<int> pipe)
        {
            Console.Write("Введите размер трубы: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < pipe.Count; i++)
            {
                for (int j = 0; j < pipe.Count; j++)
                {
                    for (int k = 0; k < pipe.Count; k++)
                    {
                        int pipeX = pipe[i];
                        int pipeJ = pipe[j];
                        int pipeK = pipe[k];
                        int resultSize1 = size - pipeX - pipeJ;
                        int resultSize2 = size - pipeX - pipeJ - pipeK;

                        if (resultSize1 >= -5 && resultSize1 <= 1000)
                        {
                            Console.WriteLine($"{size} - {pipeX} - {pipeJ} = {resultSize1}");
                        }
                        if (resultSize2 >= -5 && resultSize2 <= 1000)
                        {
                            Console.WriteLine($"{size} - {pipeX} - {pipeJ} - {pipeK} = {resultSize2}");
                        }
                    }
                }
            }
        }
    }
}
