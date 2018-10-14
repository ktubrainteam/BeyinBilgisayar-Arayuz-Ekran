namespace BrainTeam
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_anlikveri = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_ortalamaodaklanma = new System.Windows.Forms.Label();
            this.lbl_odaklanmadegisimi = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.grpbx_sonuclarintumu = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_amblem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.grpbx_sonuclarintumu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_amblem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_anlikveri
            // 
            this.lbl_anlikveri.AutoSize = true;
            this.lbl_anlikveri.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_anlikveri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_anlikveri.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anlikveri.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_anlikveri.Image = ((System.Drawing.Image)(resources.GetObject("lbl_anlikveri.Image")));
            this.lbl_anlikveri.Location = new System.Drawing.Point(338, 408);
            this.lbl_anlikveri.Name = "lbl_anlikveri";
            this.lbl_anlikveri.Size = new System.Drawing.Size(142, 25);
            this.lbl_anlikveri.TabIndex = 1;
            this.lbl_anlikveri.Text = "Anlık Veri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(56, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 160);
            this.dataGridView2.TabIndex = 2;
            // 
            // lbl_ortalamaodaklanma
            // 
            this.lbl_ortalamaodaklanma.AutoSize = true;
            this.lbl_ortalamaodaklanma.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ortalamaodaklanma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ortalamaodaklanma.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ortalamaodaklanma.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ortalamaodaklanma.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ortalamaodaklanma.Image")));
            this.lbl_ortalamaodaklanma.Location = new System.Drawing.Point(56, 175);
            this.lbl_ortalamaodaklanma.Name = "lbl_ortalamaodaklanma";
            this.lbl_ortalamaodaklanma.Size = new System.Drawing.Size(246, 25);
            this.lbl_ortalamaodaklanma.TabIndex = 3;
            this.lbl_ortalamaodaklanma.Text = "Ortalama Odaklanma";
            // 
            // lbl_odaklanmadegisimi
            // 
            this.lbl_odaklanmadegisimi.AutoSize = true;
            this.lbl_odaklanmadegisimi.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_odaklanmadegisimi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_odaklanmadegisimi.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_odaklanmadegisimi.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_odaklanmadegisimi.Image = ((System.Drawing.Image)(resources.GetObject("lbl_odaklanmadegisimi.Image")));
            this.lbl_odaklanmadegisimi.Location = new System.Drawing.Point(515, 175);
            this.lbl_odaklanmadegisimi.Name = "lbl_odaklanmadegisimi";
            this.lbl_odaklanmadegisimi.Size = new System.Drawing.Size(239, 25);
            this.lbl_odaklanmadegisimi.TabIndex = 5;
            this.lbl_odaklanmadegisimi.Text = "Odaklanma Değişimi";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(515, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(246, 160);
            this.dataGridView3.TabIndex = 4;
            // 
            // grpbx_sonuclarintumu
            // 
            this.grpbx_sonuclarintumu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpbx_sonuclarintumu.BackgroundImage")));
            this.grpbx_sonuclarintumu.Controls.Add(this.pictureBox1);
            this.grpbx_sonuclarintumu.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.grpbx_sonuclarintumu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbx_sonuclarintumu.Location = new System.Drawing.Point(204, 451);
            this.grpbx_sonuclarintumu.Name = "grpbx_sonuclarintumu";
            this.grpbx_sonuclarintumu.Size = new System.Drawing.Size(447, 262);
            this.grpbx_sonuclarintumu.TabIndex = 6;
            this.grpbx_sonuclarintumu.TabStop = false;
            this.grpbx_sonuclarintumu.Text = "SONUÇLAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_amblem
            // 
            this.pictureBox_amblem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_amblem.BackgroundImage")));
            this.pictureBox_amblem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_amblem.Image")));
            this.pictureBox_amblem.Location = new System.Drawing.Point(3, 1);
            this.pictureBox_amblem.Name = "pictureBox_amblem";
            this.pictureBox_amblem.Size = new System.Drawing.Size(47, 48);
            this.pictureBox_amblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_amblem.TabIndex = 12;
            this.pictureBox_amblem.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(817, 749);
            this.Controls.Add(this.pictureBox_amblem);
            this.Controls.Add(this.grpbx_sonuclarintumu);
            this.Controls.Add(this.lbl_odaklanmadegisimi);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lbl_ortalamaodaklanma);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbl_anlikveri);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.grpbx_sonuclarintumu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_amblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_anlikveri;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_ortalamaodaklanma;
        private System.Windows.Forms.Label lbl_odaklanmadegisimi;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox grpbx_sonuclarintumu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_amblem;
    }
}