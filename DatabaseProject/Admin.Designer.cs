namespace WindowsFormsApplication1
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Pridat = new System.Windows.Forms.Button();
            this.button_Upravit = new System.Windows.Forms.Button();
            this.button_Smazat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(12, 338);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            // 
            // button_Pridat
            // 
            this.button_Pridat.Location = new System.Drawing.Point(167, 338);
            this.button_Pridat.Name = "button_Pridat";
            this.button_Pridat.Size = new System.Drawing.Size(75, 23);
            this.button_Pridat.TabIndex = 2;
            this.button_Pridat.Text = "Přidat";
            this.button_Pridat.UseVisualStyleBackColor = true;
            this.button_Pridat.Click += new System.EventHandler(this.button_Pridat_Click);
            // 
            // button_Upravit
            // 
            this.button_Upravit.Location = new System.Drawing.Point(308, 338);
            this.button_Upravit.Name = "button_Upravit";
            this.button_Upravit.Size = new System.Drawing.Size(75, 23);
            this.button_Upravit.TabIndex = 3;
            this.button_Upravit.Text = "Upravit";
            this.button_Upravit.UseVisualStyleBackColor = true;
            this.button_Upravit.Click += new System.EventHandler(this.button_Upravit_Click);
            // 
            // button_Smazat
            // 
            this.button_Smazat.Location = new System.Drawing.Point(446, 338);
            this.button_Smazat.Name = "button_Smazat";
            this.button_Smazat.Size = new System.Drawing.Size(75, 23);
            this.button_Smazat.TabIndex = 4;
            this.button_Smazat.Text = "Smazat";
            this.button_Smazat.UseVisualStyleBackColor = true;
            this.button_Smazat.Click += new System.EventHandler(this.button_Smazat_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 373);
            this.Controls.Add(this.button_Smazat);
            this.Controls.Add(this.button_Upravit);
            this.Controls.Add(this.button_Pridat);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Pridat;
        private System.Windows.Forms.Button button_Upravit;
        private System.Windows.Forms.Button button_Smazat;
    }
}