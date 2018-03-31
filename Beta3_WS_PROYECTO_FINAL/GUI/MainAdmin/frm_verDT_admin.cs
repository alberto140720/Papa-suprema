using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin;
using Beta3_WS_PROYECTO_FINAL.GUI;

namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    public partial class frm_verDT_admin : Form
    {
        public frm_verDT_admin()
        {
            InitializeComponent();
        }

        private void btn_cerrar_vDT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cerrar_vDT_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_reDT_vDT_Click(object sender, EventArgs e)
        {
            frm_registrarDTm objRegDT = new frm_registrarDTm();
            objRegDT.ShowDialog();
        }

        private void btn_changeUsPass_VerDT_Click(object sender, EventArgs e)
        {
            frm_RegistrarDT_US2 objRegDatUS = new frm_RegistrarDT_US2();
            objRegDatUS.ShowDialog();
        }
    }
}
