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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static decimal m1Row,m1Column,m2Row,m2Column;
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void ndM1Column_ValueChanged(object sender, EventArgs e)
        {
            ndM2Row.Value = ndM1Column.Value;
        }

        private void btnCreateMatrix_Click(object sender, EventArgs e)
        {
            AssignDimension();
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void AssignDimension()
        {
            m1Row = ndM1Row.Value;
            m1Column = ndM1Column.Value;
            m2Row = ndM2Row.Value;
            m2Column = ndM2Column.Value;
        }
    }
}
