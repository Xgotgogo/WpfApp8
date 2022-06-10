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
    public partial class formIzmenit : Form
    {
        public formIzmenit()
        {
            InitializeComponent();
        }

        private void formizmenit_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formVitrina wauto = new formVitrina();
            wauto.Show();
            this.Hide();
        }
    }
}