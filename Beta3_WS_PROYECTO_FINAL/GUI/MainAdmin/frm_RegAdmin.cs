using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    public partial class frm_RegAdmin : Form
    {
        public frm_RegAdmin()
        {
            InitializeComponent();
        }

        private void btn_cancelarDatRegAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_siguienteRegDatAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RegistrarDT_US objRegUs = new frm_RegistrarDT_US();
            objRegUs.ShowDialog();
        }
    }
}
