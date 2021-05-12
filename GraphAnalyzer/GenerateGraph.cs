using System;
using System.Security.Cryptography;

namespace GraphAnalyzer
{
    class GenerateGraph
    {
        Algoritm algoritm = new Algoritm();
        WriterGraphML writerGML = new WriterGraphML();
        CartesianProduct mul = new CartesianProduct();
        public void Generate(int v, int e, int check, bool checkMLS) //Генерация случайного графа
        {
            int[,] matrix = new int [v, v];
            AddElements(v, e, matrix);
            if (checkMLS == true)
            {
                ReachabilityMatrix(v, matrix);
            }
            writerGML.ParserWriter(v, matrix, check);
        }

        public void GenerateMix(int v1, int e1, int v2, int e2, bool checkMLS)
        {
            int[,] matr1 = new int[v1, v1];
            AddElements(v1, e1, matr1);
            int[,] matr2 = new int[v2, v2];
            AddElements(v2, e2, matr2);
            int count = v1 * v2;
            int[,] rez =new int[count, count] ;
            mul.Multiplication(matr1, matr2, rez);
            if (checkMLS == true)
            {
                ReachabilityMatrix(count, rez);
            }
            writerGML.ParserWriter(count, rez, 2);
        }

        public void AddElements(int v, int e, int [,] matrix) //создание матрицы смежности
        { 
            int ef = e;
            while (ef != 0)
            {
                for (int i = 0; i < v; i++)
                {
                    if (ef == 0) break;
                    for (int j = 0; j < v; j++)
                    {
                        int rnd = RandomNumberGenerator.GetInt32(0, 2);
                        if (rnd == 1)
                        {
                            matrix[i, j] = 1;
                            ef--;
                        }
                        if (ef == 0) break;
                    }
                }
            }
        }

        public void ReachabilityMatrix(int V, int[,] matrix) // Создание матрицы достижимости для дальнейшего алгоритма
        {
            int[,] matr = new int[V, V];
            int[,] matr_1 = new int[V, V];
            int[,] matr_reach = new int[V, V];

            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    matr_reach[i, j] = matr[i, j] = matrix[i, j];
                }
            }

            for (int round = 0; round < V - 1; round++)
            {
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        for (int k = 0; k < V; k++)
                        {

                            matr_1[i, j] |= (matrix[i, k] & matr[k, j]);
                        }
                    }
                }

                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        matr[i, j] = matr_1[i, j];
                        matr_1[i, j] = 0;
                    }
                }

                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        matr_reach[i, j] |= matr[i, j];
                    }
                }
            }

            algoritm.Alg(V, matr_reach);
        }
    }
}
