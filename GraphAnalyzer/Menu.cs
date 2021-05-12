using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GraphAnalyzer
{
    public partial class Menu : MaterialForm
    {
        public Menu()
        {
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey800, Primary.Green50, Accent.Indigo200, TextShade.WHITE);
        }

        private void Generation_Graph_Click(object sender, EventArgs e)
        {
            GenerateGraph generate = new GenerateGraph();
            int check;
            if (mandatiryButton.Checked == true)
            {
                if (countEdge.Text == "" ||
                countVertex.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                int countV = Int32.Parse(countVertex.Text);
                int countE = Int32.Parse(countEdge.Text);
                if(countE > countV * countV)
                {
                    MessageBox.Show("Количество ребер слишком велико. Попробуйте еще раз.");
                    return;
                }
                bool checkMls = CheckMLS.Checked;
                check = 0;
                generate.Generate(countV, countE, check, checkMls);
            }
            else if (roleButton.Checked == true)
            {
                if (countVertexRole.Text == "" ||
                    countEdgeRole.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                check = 1;
                bool checkMls = CheckMLS.Checked;
                int countVRole = Int32.Parse(countVertexRole.Text);
                int countERole = Int32.Parse(countEdgeRole.Text);
                if (countERole > countVRole * countVRole)
                {
                    MessageBox.Show("Количество ребер слишком велико. Попробуйте еще раз.");
                    return;
                }
                generate.Generate(countVRole, countERole, check, checkMls);
            }
            else {
                if (countEdge.Text == "" ||
                countVertex.Text == "" ||
                countVertexRole.Text == "" ||
                countEdgeRole.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                int countV = Int32.Parse(countVertex.Text);
                int countE = Int32.Parse(countEdge.Text);
                int countVRole = Int32.Parse(countVertexRole.Text);
                int countERole = Int32.Parse(countEdgeRole.Text);
                bool checkMls = CheckMLS.Checked;
                if ((countE > countV * countV) || (countERole > countVRole * countVRole))
                {
                    MessageBox.Show("Количество ребер слишком велико. Попробуйте еще раз.");
                    return;
                }

                generate.GenerateMix(countV, countE, countVRole, countERole, checkMls); 
            }
        }

        private void createParse_Click(object sender, EventArgs e)
        {
            ReaderFile reader = new ReaderFile();
            int check;
            if (mandatiryButton.Checked == true)
            {
                if (linkFail.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните поле");
                    return;
                }
                check = 0;
                bool checkMls = CheckMLS.Checked;
                reader.Reader(linkFail.Text, check, checkMls);
            }
            else if (roleButton.Checked == true)
            {
                if (linkFailRole.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните поле");
                    return;
                }
                check = 1;
                bool checkMls = CheckMLS.Checked;
                reader.Reader(linkFailRole.Text, check, checkMls);
            }
            else
            {
                if (linkFailRole.Text == "" ||
                    linkFail.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните поле");
                    return;
                }
                bool checkMls = CheckMLS.Checked;
                reader.ReaderMix(linkFail.Text, linkFailRole.Text, checkMls);
            }
        }
    }
}
