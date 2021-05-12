using System;
using System.Collections.Generic;
using System.Text;

namespace GraphAnalyzer
{
    class CartesianProduct
    {
        class X
        {
            public int x, x1;

            public X(int x, int x1)
            {
                this.x = x;
                this.x1 = x1;
            }
        }
        class Y
        {
            public int y, y1;

            public Y(int y, int y1)
            {
                this.y = y;
                this.y1 = y1;
            }
        }
        public void Multiplication(int[,] matr1, int[,] matr2, int [,] rez) // декартово произведение
        {
            List<X> x = new List<X>();
            List<Y> y = new List<Y>();


            int len1 = matr1.GetLength(0);
            int len2 = matr2.GetLength(0);
            int count = rez.GetLength(0);

            for (int i = 0; i < len1; i++) //Запонение множества вершин
            {
                for (int j = 0; j < len2; j++)
                {
                    x.Add(new X(i, j));
                    y.Add(new Y(i, j));
                }
            }

            for (int i = 0; i < count; i++) //проверка условий на декартаво произведение
            {
                for (int j = 0; j < count; j++)
                {
                    if ((x[i].x == y[j].y) && (matr2[x[i].x1, y[j].y1] == 1))
                    {
                        rez[i, j] = 1;
                    }
                    else if ((x[i].x1 == y[j].y1) && (matr1[x[i].x, y[j].y] == 1))
                    {
                        rez[i, j] = 1;
                    }
                    else
                    {
                        rez[i, j] = 0;
                    }
                }
            }
        }                      
    }
}
