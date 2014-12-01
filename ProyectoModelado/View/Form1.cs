using ProyectoModelado.View;
using System;
using System.Windows.Forms;

namespace ProyectoModelado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Form1 form =new Form1();
            //form.Hide();
            //var wpf = new Main1();
            //ElementHost.EnableModelessKeyboardInterop(wpf);
            //wpf.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            AdmMenu menu = new AdmMenu();
            menu.Show();
            Hide();
        }
    }
}
