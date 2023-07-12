using ComparingProteinMolecules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProteinMoleculesForms
{
    public partial class Main : Form
    {
        ParseInfoFromFile first_protein;
        ParseInfoFromFile second_protein;

        private string scriptLocation;
        private int countFileName;

        public Main()
        {
            InitializeComponent();
            radioButtonMin.Checked = true;
            scriptLocation = String.Empty;
            countFileName = 0;
        }

        private void File1_Click(object sender, EventArgs e)
        {
            ChooseFile();
            comboBoxFile1.SelectedIndex = comboBoxFile1.Items.Count - 1;
        }

        private void File2_Click(object sender, EventArgs e)
        {
            ChooseFile();
            comboBoxFile2.SelectedIndex = comboBoxFile2.Items.Count - 1;
        }

        private void ChooseFile()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "pdb files (*.pdb)|*.pdb";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (comboBoxFile1.Items.Count > 0)
                {
                    openFileDialog.InitialDirectory = comboBoxFile1.Items[comboBoxFile1.Items.Count - 1].ToString();
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }

            comboBoxFile1.Items.Add(filePath);
            comboBoxFile2.Items.Add(filePath);
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxFile1.Text) || string.IsNullOrWhiteSpace(comboBoxFile2.Text))
            {
                MessageBox.Show("Choose files!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char chainFile1 = 'A';
            char chainFile2 = 'A';

            chainFile1 = char.Parse(comboBoxChainFile1.Text);
            chainFile2 = char.Parse(comboBoxChainFile2.Text);

            first_protein.ReadInfo(chainFile1);
            second_protein.ReadInfo(chainFile2);


            Graf first_graf = new Graf(first_protein.Alpha, first_protein.Beta, first_protein.Atom);
            Graf second_graf = new Graf(second_protein.Alpha, second_protein.Beta, second_protein.Atom);

            char mode = '<';
            if (radioButtonMax.Checked == true)
            {
                mode = '>';
            }

            first_graf.CreateGraf(mode);
            second_graf.CreateGraf(mode);

            richTextBoxProtein1.Text = first_graf.PrintGraf();
            richTextBoxProtein2.Text = second_graf.PrintGraf();

            DrawGraf(panelGraf1, first_graf.Count, first_graf.CountAlpha);
            DrawGraf(panelGraf2, second_graf.Count, second_graf.CountAlpha);

            CompareGrafs compare = new CompareGrafs(first_graf, second_graf);
            compare.Compare();

            if (compare.CompareValue == double.PositiveInfinity)
            {
                textBoxCompareRes.Text = $"{compare.CompareValue.ToString()} The proteins are the same!";
            }
            else
            {
                textBoxCompareRes.Text = compare.CompareValue.ToString();
            }
            textBoxBestFound.Text = compare.BestFound.ToString();
        }

        private void comboBoxFile1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChainFile1.Items.Clear();
            first_protein = new ParseInfoFromFile(comboBoxFile1.Text);
            string[] chains = first_protein.GetDifferentChains();
            comboBoxChainFile1.Items.AddRange(chains);

            if (chains.Length == 0)
            {
                MessageBox.Show("First file is not in expected format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxFile1.Items.Remove(comboBoxFile1.Text);
                comboBoxFile2.Items.Remove(comboBoxFile1.Text);
                return;
            }

            comboBoxChainFile1.SelectedIndex = 0;
        }

        private void comboBoxFile2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChainFile2.Items.Clear();
            second_protein = new ParseInfoFromFile(comboBoxFile2.Text);
            string[] chains = second_protein.GetDifferentChains();
            comboBoxChainFile2.Items.AddRange(chains);

            if (chains.Length == 0)
            {
                MessageBox.Show("Second file is not in expected format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxFile1.Items.Remove(comboBoxFile2.Text);
                comboBoxFile2.Items.Remove(comboBoxFile2.Text);
                return;
            }

            comboBoxChainFile2.SelectedIndex = 0;
        }

        void DrawGraf(Panel panel, int countNodes, int countAlpha)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(panel.BackColor);
            List<Point> points = new List<Point>();
            SolidBrush brush;
            Pen p;

            double x_centur = panel.Size.Width / 2;
            double y_centur = panel.Size.Height / 2;
            double r = panel.Size.Width / 5;
            double angle = 360 / countNodes;

            for (double i = 0; points.Count < countNodes; i += angle)
            {
                int x = Convert.ToInt32(x_centur + r * Math.Cos(i * Math.PI / 180));
                int y = Convert.ToInt32(y_centur + r * Math.Sin(i * Math.PI / 180));
                int rad = 10;

                if (points.Count < countAlpha)
                {
                    brush = new SolidBrush(Color.Blue);
                    p = new Pen(Color.Blue, 1);
                }
                else
                {
                    brush = new SolidBrush(Color.Green);
                    p = new Pen(Color.Green, 1);
                }

                g.FillEllipse(brush, x, y, rad * 2, rad * 2);

                foreach (Point point in points)
                {
                    g.DrawLine(p, new Point(x + rad, y + rad), new Point(point.X, point.Y));
                }
                points.Add(new Point(x + rad, y + rad));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenScript()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "bat files (*.bat)|*.bat";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    scriptLocation = openFileDialog.FileName;
                }
            }

            countFileName = Path.GetFileName(scriptLocation).Length;
        }

        private void Protein3DMOdel(ComboBox comboBox, PictureBox pictureBox)
        {
            if (scriptLocation == String.Empty)
            {
                OpenScript();
            }

            if (comboBox.Text == String.Empty)
            {
                MessageBox.Show("Choose first file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ExecutableFilePath = scriptLocation;
            StringBuilder sb = new StringBuilder();
            string imageLocation = comboBox.Text.Substring(0, comboBox.Text.Length - 4) + ".jpeg";

            sb.Append(scriptLocation.Substring(0, scriptLocation.Length - countFileName));
            sb.Append(" ");
            sb.Append(comboBox.Text);
            sb.Append(" ");
            sb.Append(imageLocation);
            string Arguments = sb.ToString().Trim();

            if (File.Exists(ExecutableFilePath))
            {
                ProcessStartInfo psi = new ProcessStartInfo(ExecutableFilePath, Arguments);
                Process process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
                process.Close();
            }

            pictureBox.ImageLocation = imageLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Protein3DMOdel(comboBoxFile1, pictureBoxProtein1);
        }

        private void button2_3DModel_Click(object sender, EventArgs e)
        {
            Protein3DMOdel(comboBoxFile2, pictureBoxProtein2);
        }
    }
}
