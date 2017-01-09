using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformDataBind.Annotations;

namespace WinformDataBind
{
    public partial class frmMain : Form
    {
        private BindingSource _bs;
        private MyService _service;

        public frmMain()
        {
            _service = new MyService();
            _bs = new BindingSource();
            _bs.DataSource = _service.Data;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = _bs;

        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            _service.AddNew();
            //_bs.ResetBindings(false);

        }
    }

    public class MyService : INotifyPropertyChanged
    {
        private List<MasterType> _data;

        public MyService()
        {
            _data = GetData();
        }

        private List<MasterType> GetData()
        {
            return new List<MasterType>()
            {
                new MasterType() {Name="MyTest" }
            };
        }

        public List<MasterType> Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }

        public void AddNew()
        {
            _data.Add(new MasterType() { Name = DateTime.Now.ToShortTimeString() });
            Console.WriteLine(_data.Count.ToString());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MasterType
    {
        public string Name { get; set; }
    }
}
