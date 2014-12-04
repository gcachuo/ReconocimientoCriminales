using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

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

        private void btnVerCriminales_Click(object sender, EventArgs e)
        {
            var wpf = new Main1();
            wpf.Show();
            this.Hide();
        }

    }
}
