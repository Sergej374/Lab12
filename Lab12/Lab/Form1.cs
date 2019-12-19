using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        public string sort;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.testTableTableAdapter.Fill(this.database1DataSet.TestTable);
            int ColCount = this.database1DataSet.TestTable.Columns.Count;

            for (int i = 0; i < ColCount; i++)
            {
                this.FieldChooser.Items.Add(this.database1DataSet.TestTable.Columns[i].ToString());
            }

            this.ASCButton.Checked = true;
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            this.testTableBindingSource.Sort = this.FieldChooser.Text + sort;
        }
        private void ASC_Click(object sender, EventArgs e)
        {
            if (DESCButton.Checked)
            {
                DESCButton.Checked = false;
            }
            sort = " ASC";
            ASCButton.Checked = true;
        }
        private void DESC_Click(object sender, EventArgs e)
        {
            if (ASCButton.Checked)
            {
                ASCButton.Checked = false;
            }
            sort = " DESC";
            DESCButton.Checked = true;
        }
    }
}
