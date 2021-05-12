using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAnalyzer
{
    class Algoritm
    {
        class V_mass
        {
            public int len, s;

            public V_mass(int len, int s)
            {
                this.len = len;
                this.s = s;
            }
        }

        //Сам алгоритм соотвтетствия орграфа к MLS-решетке
        public void Alg(int count, int[,] matrix)
        {
            string rezult;
            List<V_mass> mass = new List<V_mass>();
            int[] P = new int[count];
            int[] A = new int[count];
            int[] C = new int[count];

            for (int i = 0; i < count; i++)
            {
                int L = 0;
                int j_z = -1;
                int S = 1;
                for (int j = 0; j < count; j++)
                {
                    if ((j != i) && (matrix[i, j] == 1))
                    {
                        if ((L == 0) || (matrix[j, j_z] == 1))
                        {
                            j_z = j;
                            //L++;
                        }
                        L++;
                    }
                }
                if (L > 1)
                {
                    for (int j = 0; j < count; j++)
                    {
                        if ((j != i) && (matrix[i, j] == 1) && (j != j_z) && (matrix[j_z, j] == 0))
                        {
                            S = 0;
                            break;
                        }
                    }
                }
                if (L == 1)
                {
                    if (i == 0)
                    {
                        P[i] = 1;
                        A[i] = 1;
                    }
                    else
                    {
                        P[i] = i;
                        A[i] = i;
                    }

                }
                if ((L > 1) && (S == 1))
                {
                    if (i == 0)
                    {
                        A[i] = -1;
                        P[i] = 1;
                        C[i] = 1;
                    }
                    else
                    {
                        P[i] = i;
                        C[i] = i;
                    }
                    mass.Add(new V_mass(L, i));
                }
                if ((L == 0) && (i == 0))
                {
                    P[i] = -1;
                    A[i] = -1;
                }
            }

            int pi = len_mass(P);
            int alpha = len_mass(A);
            if (sets(A, P) == true)
            {
                if (count != Math.Pow(2, pi))
                {
                    rezult = "Требуемого соответствия нет";
                }
                else
                {
                    rezult = "Орграф соответствует MLS-решетке = XS(" + (pi - 1) + ") × LS(2) или эквивалентной решетке подмножеств XS(" + pi + ")";
                    //Орграф соответствует решетке подмножеств 
                    //XS(pi) или MLS-решетке = (XS(pi - 1) * LS(2))
                }
            }
            else
            {
                if (count != (Math.Pow(2, alpha - 1) * (pi - alpha + 2)))
                {
                    rezult = "Требуемого соответствия нет";
                }
                else
                {
                    int Z = 1;
                    int coun = 0;
                    for (int k = 2; k <= pi - alpha + 1; k++)
                    {
                        for (int i = 0; i < mass.Count; i++)
                        {
                            if (mass[i].len == k)
                            {
                                coun++;
                            }
                        }
                        if (coun != 1)
                            Z = 0;
                    }
                    if (Z == 0)
                    {
                        rezult = "Требуемого соответствия нет";
                    }
                    else
                    {
                        int a = 0;
                        int b = 0;
                        if (mass.Count != 1)
                        {
                            for (int k = 2; k <= pi - alpha; k++)
                            {
                                for (int i = 0; i < mass.Count; i++)
                                {
                                    if (mass[i].len == k + 1)
                                        a = mass[i].s;
                                    if (mass[i].len == k)
                                        b = mass[i].s;
                                }
                                if (matrix[a, b] == 0)
                                    Z = 0;
                            }
                        }
                        if (Z == 0)
                        {
                            rezult = "Требуемого соответствия нет";
                        }
                        else
                        {
                            Z = 0;
                            for (int l = 0; l < A.Length; l++)
                            {
                                int i = 0;
                                int j = A[l];
                                if(j != -1)
                                {
                                    for (int k = 0; k < mass.Count; k++)
                                    {
                                        if (mass[k].len == 2)
                                            i = mass[k].s;
                                    }
                                    if (matrix[i, j] == 1)
                                        Z = 1;
                                }
                            }
                            if (Z == 0)
                            {
                                rezult = "Требуемого соответствия нет";
                            }
                            else
                            {
                                rezult = "Орграф соответствует MLS-решетке = XS(" + (alpha - 1) + ") × LS(" + (pi - alpha + 2) + ")";
                                // G соответствует MLS-решетке = XS(alpha - 1) * LS (pi - alpha + 2)
                            }
                        }
                    }
                }
            }

            MessageBox.Show(rezult);
        }

        public int len_mass(int[] A)
        {
            int len = 0;
            if (A[0] != -1 && A[0] != 0)
                len++;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != 0)
                    len++;
            }
            return len;
        }

        //Проверка на равенства или включение множества
        public bool sets(int[] A, int[] P)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == P[i])
                {
                    count++;
                }
            }
            if (count == P.Length)
                return true;
            else
                return false;
        }
    }
}
