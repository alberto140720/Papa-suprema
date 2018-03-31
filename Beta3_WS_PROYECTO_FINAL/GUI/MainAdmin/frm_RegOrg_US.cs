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
    public partial class frm_RegOrg_US : Form
    {
        public frm_RegOrg_US()
        {
            InitializeComponent();
        }

        private void btn_atrasRegORG_US_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RegOrg objRegORG = new frm_RegOrg();
            objRegORG.ShowDialog();
        }
    }
}
