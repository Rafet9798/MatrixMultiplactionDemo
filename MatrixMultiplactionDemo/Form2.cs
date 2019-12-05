using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixMultiplactionDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }
        private decimal m1Row = Form1.m1Row;
        private decimal m1Column = Form1.m1Column;
        private decimal m2Row = Form1.m2Row;
        private decimal m2Column = Form1.m2Column;
        TextBox[,] matrix1 = new TextBox[(int)Form1.m1Row, (int)Form1.m1Column];
        TextBox[,] matrix2 = new TextBox[(int)Form1.m2Row, (int)Form1.m2Column];
        TextBox[,] matrix1x2 = new TextBox[(int)Form1.m1Row, (int)Form1.m2Column];
        private void Form2_Load(object sender, EventArgs e)
        {
            CreateMatrix1();
            CreateMatrix2();
            CreateMatrix1x2();
            CreateCalculateButton();
        }
        private void CreateCalculateButton()
        {
            Button btnCalculate = new Button();
            btnCalculate.Text = "Calculate";
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.Left = this.Width - 150;
            btnCalculate.Top = this.Height - 80;
            btnCalculate.Click += BtnCalculate_Click;
            this.Controls.Add(btnCalculate);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateMultiplication();
            }
            catch (Exception)
            {

                MessageBox.Show("Input value was not in correct format","Error at input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                ClearTextBoxes(matrix1);
                ClearTextBoxes(matrix2);
            }
        }

        private void CreateMatrix1()
        {
            for (int i = 0; i < m1Row; i++)
            {
                for (int j = 0; j < m1Column; j++)
                {
                    matrix1[i, j] = new TextBox();
                    matrix1[i, j].Size = new Size(40, 20);
                    matrix1[i, j].Top = (i + 1) * 20;
                    matrix1[i, j].Left = (j + 1) * 40;
                    this.Controls.Add(matrix1[i, j]);
                }
            }

        }
        private void CreateMatrix2()
        {
            for (int i = 0; i < m2Row; i++)
            {
                for (int j = 0; j < m2Column; j++)
                {
                    matrix2[i, j] = new TextBox();
                    matrix2[i, j].Size = new Size(40, 20);
                    matrix2[i, j].Top = (i + 1) * 20;
                    matrix2[i, j].Left = (j + 1) * 40+(int)m1Column*40+40;
                    this.Controls.Add(matrix2[i, j]);
                }
            }

        }

        private void CreateMatrix1x2()
        {
            for (int i = 0; i < m1Row; i++)
            {
                for (int j = 0; j < m2Column; j++)
                {
                    matrix1x2[i, j] = new TextBox();
                    matrix1x2[i, j].Size = new Size(40, 20);
                    matrix1x2[i, j].Top = (i + 1) * 20;
                    matrix1x2[i, j].Left = (j + 1) * 40 + ((int)m1Column+(int)m2Column) * 40 + 80;
                    matrix1x2[i, j].ReadOnly = true;
                    this.Controls.Add(matrix1x2[i, j]);
                }
            }

        }
        private void CalculateMultiplication()
        {
            int cem = 0;
            for (int i = 0; i < m1Row; i++)
            {
                for (int j = 0; j < m2Column; j++)
                {
                    for (int k = 0; k < m2Row; k++)
                    {
                        cem +=int.Parse( matrix1[i, k].Text) * int.Parse(matrix2[k, j].Text);
                    }
                    matrix1x2[i, j].Text = cem.ToString();
                    cem = 0;
                }

            }
        }

        private void ClearTextBoxes(TextBox[,] textBoxes)
        {
            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {
                    textBoxes[i,j].Text = "";
                }
            }
         
        }
    }
}
