using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easycon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void srt_newBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.srt_newBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mvcDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mvcDataSet.srt_new' table. You can move, or remove it, as needed.
            this.srt_newTableAdapter.Fill(this.mvcDataSet.srt_new);


            this.reportViewer1.RefreshReport();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void srt_newDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void aaa()
        {
            Console.WriteLine("dddfrw");
        }
    }
}
