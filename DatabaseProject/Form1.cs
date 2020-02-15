using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_LogIn_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            Admin adm = new Admin();
            Form_Lekar lkr = new Form_Lekar();

            if (this.textBox1.Text == "Admin" && this.textBox2.Text == "ABCD")
            {
                MessageBox.Show("Přihlášení proběhlo uspěšně");
                adm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Špatně zadané heslo nebo email");
            }

            if (this.textBox1.Text == "Lekar" && this.textBox2.Text == "123456")
            {
                MessageBox.Show("Přihlášení proběhlo uspěšně");
                lkr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Špatně zadané heslo nebo email");
            }
        }
    }
}
