namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHastaGirişi = new System.Windows.Forms.Button();
            this.BtnDoktorGirişi = new System.Windows.Forms.Button();
            this.BtnSekreterGirişi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHastaGirişi
            // 
            this.BtnHastaGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGirişi.BackgroundImage")));
            this.BtnHastaGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGirişi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHastaGirişi.Location = new System.Drawing.Point(12, 201);
            this.BtnHastaGirişi.Name = "BtnHastaGirişi";
            this.BtnHastaGirişi.Size = new System.Drawing.Size(261, 137);
            this.BtnHastaGirişi.TabIndex = 0;
            this.BtnHastaGirişi.UseVisualStyleBackColor = true;
            this.BtnHastaGirişi.Click += new System.EventHandler(this.BtnHastaGirişi_Click);
            // 
            // BtnDoktorGirişi
            // 
            this.BtnDoktorGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGirişi.BackgroundImage")));
            this.BtnDoktorGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGirişi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDoktorGirişi.Location = new System.Drawing.Point(289, 201);
            this.BtnDoktorGirişi.Name = "BtnDoktorGirişi";
            this.BtnDoktorGirişi.Size = new System.Drawing.Size(292, 137);
            this.BtnDoktorGirişi.TabIndex = 1;
            this.BtnDoktorGirişi.UseVisualStyleBackColor = true;
            this.BtnDoktorGirişi.Click += new System.EventHandler(this.BtnDoktorGirişi_Click);
            // 
            // BtnSekreterGirişi
            // 
            this.BtnSekreterGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGirişi.BackgroundImage")));
            this.BtnSekreterGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGirişi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSekreterGirişi.Location = new System.Drawing.Point(602, 201);
            this.BtnSekreterGirişi.Name = "BtnSekreterGirişi";
            this.BtnSekreterGirişi.Size = new System.Drawing.Size(265, 137);
            this.BtnSekreterGirişi.TabIndex = 3;
            this.BtnSekreterGirişi.UseVisualStyleBackColor = true;
            this.BtnSekreterGirişi.Click += new System.EventHandler(this.BtnSekreterGirişi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(402, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(695, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Light sea green hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(906, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGirişi);
            this.Controls.Add(this.BtnDoktorGirişi);
            this.Controls.Add(this.BtnHastaGirişi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea Green Hospital Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGirişi;
        private System.Windows.Forms.Button BtnDoktorGirişi;
        private System.Windows.Forms.Button BtnSekreterGirişi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

