namespace ProjectT100.View
{
    partial class FrmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmail));
            this.tbemail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbemail
            // 
            this.tbemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbemail.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbemail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbemail.Location = new System.Drawing.Point(26, 189);
            this.tbemail.Margin = new System.Windows.Forms.Padding(5);
            this.tbemail.Multiline = true;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(290, 30);
            this.tbemail.TabIndex = 0;
            this.tbemail.Text = " Email";
            //this.tbemail.Enter += new System.EventHandler(this.tbemail_Enter);
            //this.tbemail.Leave += new System.EventHandler(this.tbemail_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(78, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email Escape Room";
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSend.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSend.Location = new System.Drawing.Point(26, 306);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(290, 43);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send Email";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.ForeColor = System.Drawing.Color.Transparent;
            this.lbtext.Location = new System.Drawing.Point(60, 260);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(212, 15);
            this.lbtext.TabIndex = 8;
            this.lbtext.Text = "Uw registratie is succesvol geregistreed";
            // 
            // FrmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 503);
            this.Controls.Add(this.lbtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbemail);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmEmail";
            this.Text = "FrmEmail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtext;
    }
}