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
    public partial class formVitrinaAdmin : Form
    {
        public formVitrinaAdmin()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            windowAuthorization wauto = new windowAuthorization();
            wauto.Show();
            this.Hide();
        }

        private void btnDobavit_Click(object sender, EventArgs e)
        {
            formAdd wauto = new formAdd();
            wauto.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIzmenit_Click(object sender, EventArgs e)
        {
            formIzmenit wauto = new formIzmenit();
            wauto.Show();
            this.Hide();
        }
    }
}