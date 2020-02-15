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
    public partial class Form_Lekar : Form
    {
        public Lekari lekari { get; set; }
        public Form_Lekar()
        {

        }

        public Form_Lekar(Lekari lkr)
        {
            InitializeComponent();

            this.comboBox1.Items.Add("Chirurg");
            this.comboBox1.Items.Add("Gynekolog");
            this.comboBox1.Items.Add("Kardiolog");
            this.comboBox1.Items.Add("Neurolog");
            this.comboBox1.Items.Add("Psychiatr");
            this.comboBox1.Items.Add("Sexuolog");
            this.comboBox1.SelectedItem = 0;

            this.lekari = lkr;

            this.textBox_Jmeno.Text = lkr.Jmeno;
            this.textBox_Prijemni.Text = lkr.Prijmeni;
            this.dateTimePicker1.Value = lkr.DatumNarozeni;
            this.comboBox1.SelectedItem = lkr.Specializace;
            this.dateTimePicker2.Value = lkr.DatumUkonceniSkoly;
            this.textBox_Email.Text = lkr.Email;
            this.textBox_Telefon.Text = lkr.Telefon.ToString();
            this.textBox_Role.Text = lkr.Role;
            this.textBox_Heslo.Text = lkr.Heslo;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                this.lekari.Jmeno = this.textBox_Jmeno.Text;
                this.lekari.Prijmeni = this.textBox_Prijemni.Text;
                this.lekari.DatumNarozeni = this.dateTimePicker1.Value;
                this.lekari.Specializace = this.comboBox1.ToString();
                this.lekari.DatumUkonceniSkoly = this.dateTimePicker2.Value;
                this.lekari.Email = this.textBox_Email.Text;
                this.lekari.Telefon = Convert.ToInt32(this.textBox_Telefon.Text);
                this.lekari.Role = this.textBox_Role.Text;
                this.lekari.Heslo = this.textBox_Heslo.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsValid()
        {
            bool valid = true;
            this.errorProvider1.Clear();

            return valid;
        }

        private bool IsNumber(string text)
        {
            try
            {
                Convert.ToInt32(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
