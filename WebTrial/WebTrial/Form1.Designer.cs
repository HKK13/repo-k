namespace WebTrial
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPASS = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.howItWorks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(1, 44);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1416, 607);
            this.webBrowser1.TabIndex = 0;
            // 
            // urlBox
            // 
            this.urlBox.BackColor = System.Drawing.SystemColors.Window;
            this.urlBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.urlBox.Location = new System.Drawing.Point(13, 13);
            this.urlBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(715, 22);
            this.urlBox.TabIndex = 1;
            this.urlBox.Text = "https://suis.sabanciuniv.edu/prod/twbkwbis.P_SabanciLogin";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textID.Location = new System.Drawing.Point(1064, 10);
            this.textID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(133, 26);
            this.textID.TabIndex = 2;
            // 
            // textPASS
            // 
            this.textPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPASS.Location = new System.Drawing.Point(1256, 10);
            this.textPASS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPASS.Name = "textPASS";
            this.textPASS.PasswordChar = '*';
            this.textPASS.Size = new System.Drawing.Size(157, 26);
            this.textPASS.TabIndex = 3;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(1425, 18);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(133, 42);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "GO!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStop.Location = new System.Drawing.Point(1425, 71);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(133, 42);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "STOP!";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1031, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1205, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pass:";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(1426, 121);
            this.logBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(132, 530);
            this.logBox.TabIndex = 8;
            this.logBox.Text = "";
            // 
            // howItWorks
            // 
            this.howItWorks.AutoSize = true;
            this.howItWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.howItWorks.Location = new System.Drawing.Point(735, 14);
            this.howItWorks.Name = "howItWorks";
            this.howItWorks.Size = new System.Drawing.Size(121, 18);
            this.howItWorks.TabIndex = 9;
            this.howItWorks.TabStop = true;
            this.howItWorks.Text = "How it works ?";
            this.howItWorks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.howItWorks_LinkClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonStop;
            this.ClientSize = new System.Drawing.Size(1575, 650);
            this.Controls.Add(this.howItWorks);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textPASS);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "BannerRunner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPASS;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.LinkLabel howItWorks;
    }
}

