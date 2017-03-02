namespace TestClassi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pNameLbl = new System.Windows.Forms.Label();
            this.pHpBar = new System.Windows.Forms.ProgressBar();
            this.pHpLbl = new System.Windows.Forms.Label();
            this.pPicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ePicture = new System.Windows.Forms.PictureBox();
            this.eHpLbl = new System.Windows.Forms.Label();
            this.eHpBar = new System.Windows.Forms.ProgressBar();
            this.eNameLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pPicture);
            this.panel1.Controls.Add(this.pHpLbl);
            this.panel1.Controls.Add(this.pHpBar);
            this.panel1.Controls.Add(this.pNameLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(938, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // pNameLbl
            // 
            this.pNameLbl.AutoSize = true;
            this.pNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pNameLbl.Location = new System.Drawing.Point(20, 17);
            this.pNameLbl.Name = "pNameLbl";
            this.pNameLbl.Size = new System.Drawing.Size(128, 25);
            this.pNameLbl.TabIndex = 2;
            this.pNameLbl.Text = "Nome mostro";
            // 
            // pHpBar
            // 
            this.pHpBar.Location = new System.Drawing.Point(25, 108);
            this.pHpBar.Name = "pHpBar";
            this.pHpBar.Size = new System.Drawing.Size(350, 25);
            this.pHpBar.TabIndex = 3;
            // 
            // pHpLbl
            // 
            this.pHpLbl.AutoSize = true;
            this.pHpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pHpLbl.Location = new System.Drawing.Point(20, 80);
            this.pHpLbl.Name = "pHpLbl";
            this.pHpLbl.Size = new System.Drawing.Size(116, 25);
            this.pHpLbl.TabIndex = 4;
            this.pHpLbl.Text = "100/100 HP";
            // 
            // pPicture
            // 
            this.pPicture.Location = new System.Drawing.Point(25, 161);
            this.pPicture.Name = "pPicture";
            this.pPicture.Size = new System.Drawing.Size(350, 250);
            this.pPicture.TabIndex = 5;
            this.pPicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ePicture);
            this.panel3.Controls.Add(this.eHpLbl);
            this.panel3.Controls.Add(this.eHpBar);
            this.panel3.Controls.Add(this.eNameLbl);
            this.panel3.Location = new System.Drawing.Point(938, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 450);
            this.panel3.TabIndex = 2;
            // 
            // ePicture
            // 
            this.ePicture.Location = new System.Drawing.Point(25, 161);
            this.ePicture.Name = "ePicture";
            this.ePicture.Size = new System.Drawing.Size(350, 250);
            this.ePicture.TabIndex = 5;
            this.ePicture.TabStop = false;
            // 
            // eHpLbl
            // 
            this.eHpLbl.AutoSize = true;
            this.eHpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eHpLbl.Location = new System.Drawing.Point(20, 80);
            this.eHpLbl.Name = "eHpLbl";
            this.eHpLbl.Size = new System.Drawing.Size(116, 25);
            this.eHpLbl.TabIndex = 4;
            this.eHpLbl.Text = "100/100 HP";
            // 
            // eHpBar
            // 
            this.eHpBar.Location = new System.Drawing.Point(25, 108);
            this.eHpBar.Name = "eHpBar";
            this.eHpBar.Size = new System.Drawing.Size(350, 25);
            this.eHpBar.TabIndex = 3;
            // 
            // eNameLbl
            // 
            this.eNameLbl.AutoSize = true;
            this.eNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eNameLbl.Location = new System.Drawing.Point(20, 17);
            this.eNameLbl.Name = "eNameLbl";
            this.eNameLbl.Size = new System.Drawing.Size(128, 25);
            this.eNameLbl.TabIndex = 2;
            this.eNameLbl.Text = "Nome mostro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pPicture;
        private System.Windows.Forms.Label pHpLbl;
        private System.Windows.Forms.ProgressBar pHpBar;
        private System.Windows.Forms.Label pNameLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ePicture;
        private System.Windows.Forms.Label eHpLbl;
        private System.Windows.Forms.ProgressBar eHpBar;
        private System.Windows.Forms.Label eNameLbl;
        private System.Windows.Forms.Button button1;
    }
}

