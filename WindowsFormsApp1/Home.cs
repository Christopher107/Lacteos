using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {

        RegistroUsuarios frmUsuarios;
        RegistroPersonal frmPersonal;
        RegistroHoras frmHoras;

        public Home()
        {
            InitializeComponent();

            frmHoras = new RegistroHoras();
            frmHoras.MdiParent = this;

            frmPersonal = new RegistroPersonal();
            frmPersonal.MdiParent = this;

            frmUsuarios = new RegistroUsuarios();
            frmUsuarios.MdiParent = this;
        }

        private void btnIngresoPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal.Show();
        }

        private void btnIngresoUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios.Show();
        }

        private void btnIngresoHoras_Click(object sender, EventArgs e)
        {
            frmHoras.Show();
        }
    }
}
