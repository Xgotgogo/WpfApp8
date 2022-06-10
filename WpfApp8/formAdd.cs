using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp8
{
    public partial class formAdd : Form
    {
        public formAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formVitrina wauto = new formVitrina();
            wauto.Show();
            this.Hide();
        }

        private void formAdd_Load(object sender, EventArgs e)
        {

        }
    }
}