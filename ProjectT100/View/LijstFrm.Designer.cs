namespace ProjectT100.View
{
    partial class LijstFrm
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
            this.LvStud = new System.Windows.Forms.ListView();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvStud
            // 
            this.LvStud.HideSelection = false;
            this.LvStud.Location = new System.Drawing.Point(12, 21);
            this.LvStud.Name = "LvStud";
            this.LvStud.Size = new System.Drawing.Size(284, 394);
            this.LvStud.TabIndex = 0;
            this.LvStud.UseCompatibleStateImageBehavior = false;
            // 
            // BtnReg
            // 
            this.BtnReg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReg.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReg.Location = new System.Drawing.Point(12, 436);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(284, 42);
            this.BtnReg.TabIndex = 1;
            this.BtnReg.Text = "Registreren";
            this.BtnReg.UseVisualStyleBackColor = false;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnEmail
            // 
            this.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmail.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEmail.Location = new System.Drawing.Point(12, 484);
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.Size = new System.Drawing.Size(284, 44);
            this.BtnEmail.TabIndex = 2;
            this.BtnEmail.Text = "Email";
            this.BtnEmail.UseVisualStyleBackColor = true;
            this.BtnEmail.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // LijstFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 548);
            this.Controls.Add(this.BtnEmail);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.LvStud);
            this.Name = "LijstFrm";
            this.Text = "LijstFrm";
            this.Load += new System.EventHandler(this.LijstFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvStud;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnEmail;
    }
}