using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta3_WS_PROYECTO_FINAL.GUI
{
    public partial class frm_registrarDTm : Form
    {
        public frm_registrarDTm()
        {
            InitializeComponent();
        }

        private void btn_cancelarpersona_registroDT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_siguientepersona_registro_DT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RegistrarDT_US objRegDTUS = new frm_RegistrarDT_US();
            objRegDTUS.ShowDialog();
        }
    }
}
