namespace Bioskop
{
    partial class Rezervisi
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
            this.Datum = new System.Windows.Forms.ComboBox();
            this.Vreme = new System.Windows.Forms.ComboBox();
            this.Mesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(201, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Datum
            // 
            this.Datum.FormattingEnabled = true;
            this.Datum.Location = new System.Drawing.Point(454, 72);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(121, 21);
            this.Datum.TabIndex = 1;
            this.Datum.SelectedIndexChanged += new System.EventHandler(this.Datum_SelectedIndexChanged);
            // 
            // Vreme
            // 
            this.Vreme.FormattingEnabled = true;
            this.Vreme.Location = new System.Drawing.Point(454, 135);
            this.Vreme.Name = "Vreme";
            this.Vreme.Size = new System.Drawing.Size(121, 21);
            this.Vreme.TabIndex = 2;
            this.Vreme.SelectedIndexChanged += new System.EventHandler(this.Vreme_SelectedIndexChanged);
            // 
            // Mesto
            // 
            this.Mesto.FormattingEnabled = true;
            this.Mesto.Location = new System.Drawing.Point(454, 193);
            this.Mesto.Name = "Mesto";
            this.Mesto.Size = new System.Drawing.Size(121, 21);
            this.Mesto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vreme: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mesto: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Napravi rezervaciju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nazad
            // 
            this.Nazad.Location = new System.Drawing.Point(637, 356);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(141, 82);
            this.Nazad.TabIndex = 8;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Rezervisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mesto);
            this.Controls.Add(this.Vreme);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rezervisi";
            this.Text = "Rezervisi";
            this.Load += new System.EventHandler(this.Rezervisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Datum;
        private System.Windows.Forms.ComboBox Vreme;
        private System.Windows.Forms.ComboBox Mesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Nazad;
    }
}