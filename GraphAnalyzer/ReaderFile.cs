using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GraphAnalyzer
{
    class ReaderFile
    {
        GenerateGraph graph = new GenerateGraph();
        WriterGraphML writer = new WriterGraphML();
        CartesianProduct mul = new CartesianProduct();
        public void Reader(string @path, int check, bool checkMLS)
        {
            int len = FoundLen(path);
            int[,] matr = new int[len, len];
            //string path = @"d:\test\test1.txt";
            Filling(path, matr, len);
            if (checkMLS == true)
            {
                graph.ReachabilityMatrix(len, matr);
            }
            writer.ParserWriter(len, matr, check);
        }

        public void ReaderMix (string @path1, string @path2, bool checkMLS)
        {
            int len1 = FoundLen(path1);
            int len2 = FoundLen(path2);
            int[,] matr1 = new int [len1, len1];
            int[,] matr2 = new int[len2, len2];
            int count = len1 * len2;
            int[,] rez = new int[count, count];

            //string path = @"d:\test\test1.txt";
            Filling(path1, matr1, len1);
            Filling(path2, matr2, len2);
            mul.Multiplication(matr1, matr2, rez);
            if (checkMLS == true)
            {
                graph.ReachabilityMatrix(count, rez);
            }
            writer.ParserWriter(count, rez, 2);
        }

        public int FoundLen(string @path)
        {
            int len;
            using (StreamReader sr = new StreamReader(path))
            {
                int[] mass = sr.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                len = mass.Length;
                sr.Close();
            }
            return len;
        }

        public void Filling (string @path, int [,] matr, int len)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int i = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int[] mass = line.Split(' ').Select(x => int.Parse(x)).ToArray();

                    for (int j = 0; j < len; j++)
                    {
                        matr[i, j] = mass[j];
                    }
                    i++;
                }
                sr.Close();
            }
        }
    }
}
