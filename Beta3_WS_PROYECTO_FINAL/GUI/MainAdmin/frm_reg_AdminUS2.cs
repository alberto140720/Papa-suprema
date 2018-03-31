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
    public partial class frm_reg_AdminUS2 : Form
    {
        public frm_reg_AdminUS2()
        {
            InitializeComponent();
        }

        private void btn_atrasRegAdminUS_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RegAdmin objRegAdmin = new frm_RegAdmin();
            objRegAdmin.ShowDialog();
        }
    }
}
