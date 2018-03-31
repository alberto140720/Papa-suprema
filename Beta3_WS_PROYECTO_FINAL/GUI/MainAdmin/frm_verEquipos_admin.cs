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
    public partial class frm_verEquipos_admin : Form
    {
        public frm_verEquipos_admin()
        {
            InitializeComponent();
        }

        private void btn_cerrar_VerEquipos_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_agregarEquipo_verEquipo_Click(object sender, EventArgs e)
        {
            frm_agregar_equipos_DT_Administrador objAgregarEquipo = new frm_agregar_equipos_DT_Administrador();
            objAgregarEquipo.ShowDialog();
        }
    }
}
