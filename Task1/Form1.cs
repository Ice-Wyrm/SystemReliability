using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (averageTimeField.Value == 0 || recoveryTimeField.Value == 0)
            {
                resultBox.Text = "Ошибка данных";

                return;
            }

            resultBox.Text = (averageTimeField.Value / (averageTimeField.Value + recoveryTimeField.Value)).ToString();
        }
    }
}
