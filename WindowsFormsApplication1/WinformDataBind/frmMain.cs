using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDataBind
{
    public partial class frmMain : Form
    {
        //private List<MasterType> _bindingList;
        //private BindingSource _bs;

        private BindingList<MasterType> _bindingList;
        private List<MasterType> _data;

        public frmMain()
        {
            InitializeComponent();
            _data= new List<MasterType>()
            {
                new MasterType()
                {
                    ID = 1,
                    Name = "test1"
                },
                new MasterType()
                {
                    ID = 2,
                    Name = "test2"
                },
            };

            _bindingList=new BindingList<MasterType>(GetData());
        }

        private List<MasterType> GetData()
        {
            return _data;
        }

        private void btnInitData_Click(object sender, EventArgs e)
        {
            //_bs = new BindingSource();
            //_bs.DataSource = _bindingList;
            //dgvMaster.DataSource = _bs;
            dgvMaster.DataSource = _bindingList;
        }

        private void dgvMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaster.SelectedRows == null)
            {
                return;
            }

            var item = (MasterType)dgvMaster.Rows[e.RowIndex].DataBoundItem;
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            _data.Add(new MasterType() {ID=3,Name="eeeee"});
            foreach (var masterType in _data)
            {
                Console.WriteLine(masterType.Name);
            }
            _bindingList.ResetBindings();
            //_bs.ResetBindings(false);
        }
    }

    internal class MasterType
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
    }
}
