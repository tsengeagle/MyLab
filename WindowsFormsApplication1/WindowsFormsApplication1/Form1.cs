using System;
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
                new MyType() {
                    Status=true,
                Hosp="HL",
                YM="10510",
                CostID="000001",
                Value="10000"},
                new MyType() {
                    Status=false,
                Hosp="HL",
                YM="10510",
                CostID="000002",
                Value="10000"},
            };

            dataGridView1.DataSource = list;
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
