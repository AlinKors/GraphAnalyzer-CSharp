using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GraphAnalyzer
{
    class WriterGraphML
    {
        public void ParserWriter(int v, int[,] matrix, int check)
        {
            string path = @"d:\test\MyTest.graphml";
            FileInfo fileInf = new FileInfo(path);
            if (!fileInf.Exists)
            {
                fileInf.Create();
            }
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                sw.WriteLine("<graphml xmlns=\"http://graphml.graphdrawing.org/xmlns\"");
                sw.WriteLine("   xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"");
                sw.WriteLine("   xsi:schemaLocation=\"http://graphml.graphdrawing.org/xmlns");
                sw.WriteLine("   http://graphml.graphdrawing.org/xmlns/1.0/graphml.xsd\">");
                if(check != 0)
                {
                    sw.WriteLine("   <key id=\"role\" for=\"node\" attr.name=\"role\" attr.type=\"string\"></key>");
                }
                sw.WriteLine("  <graph id=\"G\" edgedefault=\"directed\">");
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                for (int i = 0; i < v; i++)
                {
                    string node = (char)34 + "n" + i + (char)34;
                    string role = "R" + i;
                    if(check != 0)
                    {
                        sw.WriteLine("  <node id={0}><data key=\"role\">{1}</data></node>", node, role);
                    }
                    else
                    {
                        sw.WriteLine("  <node id={0}/>", node);
                    }
                }

                for (int i = 0; i < v; i++)
                {
                    for (int j = 0; j < v; j++)
                    {
                        if (matrix[i, j] == 1)
                        {
                            string source = (char)34 + "n" + i + (char)34;
                            string target = (char)34 + "n" + j + (char)34;
                            sw.WriteLine("  <edge source={0} target ={1}/>", source, target);
                        }
                    }
                }

                sw.WriteLine("  </graph>");
                sw.WriteLine("</graphml>");
                sw.Close();
            }

            MessageBox.Show("GraphML файл успешно создан");
        }
    }
}
