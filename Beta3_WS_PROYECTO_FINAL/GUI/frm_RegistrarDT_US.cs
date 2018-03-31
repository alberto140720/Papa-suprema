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
    public partial class frm_RegistrarDT_US : Form
    {
        public frm_RegistrarDT_US()
        {
            InitializeComponent();
        }

        private void btn_atraspersona_registro_DTUS_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_registrarDTm objRegDT = new frm_registrarDTm();
            objRegDT.ShowDialog();
        }
    }
}
