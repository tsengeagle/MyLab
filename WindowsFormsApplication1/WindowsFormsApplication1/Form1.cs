using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<MyType>()
            {
                new MyType()
                {
                    Status=true,Hosp="HL",YM="10510",CostID="000001",Value="10000"
                },
                new MyType()
                {
                    Status=false,Hosp="HL",YM="10510",CostID="000002",Value="10000"
                },
            };

            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var itemList=new List<MyType>()
            {
                new MyType() {Hosp = "HL",YM = "10511" },
                new MyType() {Hosp = "HL",YM = "10512" },

            };
            BindingSource bs = new BindingSource();
            bs.DataSource = itemList;
            comboBox1.DataSource = itemList;
            comboBox1.DisplayMember = "Hosp";
            comboBox1.ValueMember = "YM";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(((MyType)comboBox1.SelectedItem).YM);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e==null)
            {
                return;
            }

            var item = (MyType) dataGridView1.Rows[e.RowIndex].DataBoundItem;
            MessageBox.Show(item.Hosp+item.YM+item.CostID);
        }
    }

    internal class MyType
    {
        public string Value { get; set; }
        public string CostID { get; set; }
        public string YM { get; internal set; }
        public string Hosp { get; set; }
        public bool Status { get; set; }
    }
}
