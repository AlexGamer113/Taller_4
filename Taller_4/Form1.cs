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
    public partial class frmLogin : Form
    {
        public static string usuario;
        public static string password;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrear frm = new frmCrear();
            frm.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (txtUsarioLogin.Text == usuario && txtPasswordLogin.Text == password){
                frmPrincipal frm = new frmPrincipal();
                frm.ShowDialog();
            }
            else if (txtUsarioLogin.Text == "" && txtPasswordLogin.Text == ""){
                MessageBox.Show("Ingrese Usuario y Contraseña", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else{
                MessageBox.Show("Usuario o contraseña incorrecta", "Error de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
