using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_4
{
    public partial class frmCrear : Form
    {
        

        public frmCrear()
        {
            InitializeComponent();
            
        }

        private void frmCrear_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            frmLogin.usuario = txtUsarioCrear.Text;
            frmLogin.password = txtPasswordCrear.Text;
            Close();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            
        }
    }
}
