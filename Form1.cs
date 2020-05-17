using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        List<type> typeList = new List<type>();
        List<rowOfData> rowList = new List<rowOfData>();

        public Form1()
        {
            InitializeComponent();
            rowOfData initialObject = new rowOfData();
            initialObject.time = 0;
            rowList.Add(initialObject);

            var bindingList = new BindingList<rowOfData>(rowList);
            var source = new BindingSource(bindingList, null);
            dataGrid.DataSource = source;


            typeList.Add(new type(1, "Экспоненциальный"));
            typeList.Add(new type(2, "Рэлея"));
            typeList.Add(new type(3, "Нормальный"));
            typeList.Add(new type(4, "Вейбулла"));

            typeCombo.DataSource = typeList;
            typeCombo.DisplayMember = "name";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            rowList.ForEach(row =>
            {
                row.p = mathFormulas.calculateErrorProbability((double)paramOneField.Value, (double)paramTwoField.Value, row.time, typeCombo.SelectedIndex + 1);
                row.alpha = mathFormulas.calculateErrorIntensivity((double)paramOneField.Value, (double)paramTwoField.Value, row.time, typeCombo.SelectedIndex + 1);
                row.lambda = mathFormulas.calculateAverageTimeUntilError((double)paramOneField.Value, (double)paramTwoField.Value, row.time, typeCombo.SelectedIndex + 1);
            });

            dataGrid.Refresh();
        }
    }
}
