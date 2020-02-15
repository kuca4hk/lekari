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
    public partial class Admin : Form
    {

        private DBLekariDataModel model = new DBLekariDataModel(); 

        public Admin()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = this.model;
        }

        private void button_Pridat_Click(object sender, EventArgs e)
        {
            Form_Lekar lkr = new Form_Lekar(new Lekari());
            if (lkr.ShowDialog() == DialogResult.OK)
            {
                this.model.Add(lkr.lekari);
            }


            
        }

        private void button_Upravit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
                return;

            int index = this.dataGridView1.CurrentRow.Index;
            Form_Lekar lkr = new Form_Lekar(this.model.Lekari[index]);
            if (lkr.ShowDialog() == DialogResult.OK)
            {
                this.model.Update(index, lkr.lekari);
            }



        }

        private void button_Smazat_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
                return;

            int index = this.dataGridView1.CurrentRow.Index;
            this.model.Delete(index);
        }
    }
}
