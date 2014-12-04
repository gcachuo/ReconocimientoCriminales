using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoModelado.Modelo;

namespace ProyectoModelado.View
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                DBDataContext db = new DBDataContext();
                user usuario = new user();
                usuario.Nombre = txtUser.Text;
                usuario.Contrasena = txtContrasena.Text;
                db.users.InsertOnSubmit(usuario);
                db.SubmitChanges();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
