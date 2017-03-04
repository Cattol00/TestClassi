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
            this.playerPanel = new System.Windows.Forms.Panel();
            this.pPicture = new System.Windows.Forms.PictureBox();
            this.pHpLbl = new System.Windows.Forms.Label();
            this.pHpBar = new System.Windows.Forms.ProgressBar();
            this.pNameLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enemyPanel = new System.Windows.Forms.Panel();
            this.ePicture = new System.Windows.Forms.PictureBox();
            this.eHpLbl = new System.Windows.Forms.Label();
            this.eHpBar = new System.Windows.Forms.ProgressBar();
            this.eNameLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.ListBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).BeginInit();
            this.enemyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPanel
            // 
            this.playerPanel.Controls.Add(this.pPicture);
            this.playerPanel.Controls.Add(this.pHpLbl);
            this.playerPanel.Controls.Add(this.pHpBar);
            this.playerPanel.Controls.Add(this.pNameLbl);
            this.playerPanel.Location = new System.Drawing.Point(12, 12);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(400, 450);
            this.playerPanel.TabIndex = 0;
            // 
            // pPicture
            // 
            this.pPicture.Location = new System.Drawing.Point(25, 161);
            this.pPicture.Name = "pPicture";
            this.pPicture.Size = new System.Drawing.Size(350, 250);
            this.pPicture.TabIndex = 5;
            this.pPicture.TabStop = false;
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
            // pHpBar
            // 
            this.pHpBar.Location = new System.Drawing.Point(25, 108);
            this.pHpBar.Name = "pHpBar";
            this.pHpBar.Size = new System.Drawing.Size(350, 25);
            this.pHpBar.TabIndex = 3;
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(938, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // enemyPanel
            // 
            this.enemyPanel.Controls.Add(this.ePicture);
            this.enemyPanel.Controls.Add(this.eHpLbl);
            this.enemyPanel.Controls.Add(this.eHpBar);
            this.enemyPanel.Controls.Add(this.eNameLbl);
            this.enemyPanel.Location = new System.Drawing.Point(938, 12);
            this.enemyPanel.Name = "enemyPanel";
            this.enemyPanel.Size = new System.Drawing.Size(400, 450);
            this.enemyPanel.TabIndex = 2;
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
            this.button1.Location = new System.Drawing.Point(337, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logs
            // 
            this.logs.FormattingEnabled = true;
            this.logs.ItemHeight = 16;
            this.logs.Location = new System.Drawing.Point(418, 298);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(514, 164);
            this.logs.TabIndex = 4;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(12, 468);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 5;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(179, 468);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(573, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 506);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enemyPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.playerPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).EndInit();
            this.enemyPanel.ResumeLayout(false);
            this.enemyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pPicture;
        private System.Windows.Forms.Label pHpLbl;
        private System.Windows.Forms.ProgressBar pHpBar;
        private System.Windows.Forms.Label pNameLbl;
        private System.Windows.Forms.Panel enemyPanel;
        private System.Windows.Forms.PictureBox ePicture;
        private System.Windows.Forms.Label eHpLbl;
        private System.Windows.Forms.ProgressBar eHpBar;
        private System.Windows.Forms.Label eNameLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox logs;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
    }
}

