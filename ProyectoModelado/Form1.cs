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

            Form1 form =new Form1();
            form.Hide();
            var wpf = new Main1();
            ElementHost.EnableModelessKeyboardInterop(wpf);
            wpf.Show();
        }
    }
}
