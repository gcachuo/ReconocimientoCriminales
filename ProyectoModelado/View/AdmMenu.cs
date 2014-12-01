using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoModelado.View
{
    public partial class AdmMenu : Form
    {
        public AdmMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarCriminal_Click(object sender, EventArgs e)
        {
            NewCriminal addCriminal = new NewCriminal();
            addCriminal.Show();
            this.Hide();
        }

    }
}
