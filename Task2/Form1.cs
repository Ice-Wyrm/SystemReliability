using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        const float OBJECTS_ON_INITIATE = 500;
        const float TIME_ON_INITIATE = 5000;
        const float BASIC_INTERVAL = 200;
        const float BASIC_OBJECTS_CRUSHED = 300;
        const float INTERVAL_OBJECTS_CRUSHED = 100;

        List<rowOfData> dataList = new List<rowOfData>();

        public Form1()
        {
            InitializeComponent();
            rowOfData initialObject = new rowOfData();
            initialObject.interval = 0;
            dataList.Add(initialObject);

            var bindingList  = new BindingList<rowOfData>(dataList);
            var source = new BindingSource(bindingList, null);
            mainGrid.DataSource = source;
        }

        public void calculateData(object sender, EventArgs e)
        {
            dataList.ForEach(row =>
            {
                row.p = row.objectsAmount/OBJECTS_ON_INITIATE;
                row.time = TIME_ON_INITIATE + row.interval;
                row.alpha = (OBJECTS_ON_INITIATE - row.objectsAmount) / (OBJECTS_ON_INITIATE * row.interval);
                row.lambda = row.alpha / row.p;

            });

            mainGrid.Refresh();
        }
    }
}
