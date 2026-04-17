namespace ÖğrenciYönetimSistemiform
{
    partial class Form1
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
            this.ogrenciAdiText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenciSoyadiText = new System.Windows.Forms.TextBox();
            this.ogrenciErkek = new System.Windows.Forms.RadioButton();
            this.ogrenciKadin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.eklebtn = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciAdiText
            // 
            this.ogrenciAdiText.Location = new System.Drawing.Point(44, 62);
            this.ogrenciAdiText.Name = "ogrenciAdiText";
            this.ogrenciAdiText.Size = new System.Drawing.Size(198, 22);
            this.ogrenciAdiText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrencinin Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrencinin Soyadı:";
            // 
            // ogrenciSoyadiText
            // 
            this.ogrenciSoyadiText.Location = new System.Drawing.Point(52, 145);
            this.ogrenciSoyadiText.Name = "ogrenciSoyadiText";
            this.ogrenciSoyadiText.Size = new System.Drawing.Size(201, 22);
            this.ogrenciSoyadiText.TabIndex = 3;
            // 
            // ogrenciErkek
            // 
            this.ogrenciErkek.AutoSize = true;
            this.ogrenciErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciErkek.Location = new System.Drawing.Point(59, 234);
            this.ogrenciErkek.Name = "ogrenciErkek";
            this.ogrenciErkek.Size = new System.Drawing.Size(70, 24);
            this.ogrenciErkek.TabIndex = 4;
            this.ogrenciErkek.TabStop = true;
            this.ogrenciErkek.Text = "erkek";
            this.ogrenciErkek.UseVisualStyleBackColor = true;
            // 
            // ogrenciKadin
            // 
            this.ogrenciKadin.AutoSize = true;
            this.ogrenciKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciKadin.Location = new System.Drawing.Point(173, 234);
            this.ogrenciKadin.Name = "ogrenciKadin";
            this.ogrenciKadin.Size = new System.Drawing.Size(69, 24);
            this.ogrenciKadin.TabIndex = 5;
            this.ogrenciKadin.TabStop = true;
            this.ogrenciKadin.Text = "kadın";
            this.ogrenciKadin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğrencinin Cinsiyeti:";
            // 
            // eklebtn
            // 
            this.eklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebtn.Location = new System.Drawing.Point(52, 293);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(138, 50);
            this.eklebtn.TabIndex = 7;
            this.eklebtn.Text = "Ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // Silbtn
            // 
            this.Silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Silbtn.Location = new System.Drawing.Point(52, 365);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(135, 51);
            this.Silbtn.TabIndex = 8;
            this.Silbtn.Text = "Sil";
            this.Silbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(376, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 450);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ogrenciKadin);
            this.Controls.Add(this.ogrenciErkek);
            this.Controls.Add(this.ogrenciSoyadiText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrenciAdiText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ogrenciAdiText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogrenciSoyadiText;
        private System.Windows.Forms.RadioButton ogrenciErkek;
        private System.Windows.Forms.RadioButton ogrenciKadin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

