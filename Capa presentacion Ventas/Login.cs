using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_presentacion_Ventas
{
    public partial class Login : Form
    {
        private object frms;
        private object form;
        private int frm_Closing;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Inicio forms = new Inicio();
            forms.Show();
            this.Hide();

            forms.FormsClosing += frm_Closing;



        }

        private void frms_closing(object sender, formsClosingEventArg e)
        {
            this.Show();

        }

        private CancelEventHandler Form_Closing()
        {
            throw new NotImplementedException();
        }

        private Func<CancelEventHandler> frm_FormClosing()
        {
            throw new NotImplementedException();
        }

   

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private class formsClosingEventArg
        {
        }
    }
}
