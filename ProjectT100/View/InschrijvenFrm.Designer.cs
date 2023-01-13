namespace ProjectT100
{
    partial class InschrijvenFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TbStud = new System.Windows.Forms.TextBox();
            this.Tbvoor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(134, 183);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 53);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Registreer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Studentnummer";
            // 
            // TbStud
            // 
            this.TbStud.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TbStud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbStud.ForeColor = System.Drawing.Color.Black;
            this.TbStud.Location = new System.Drawing.Point(41, 122);
            this.TbStud.Multiline = true;
            this.TbStud.Name = "TbStud";
            this.TbStud.Size = new System.Drawing.Size(248, 27);
            this.TbStud.TabIndex = 30;
            // 
            // Tbvoor
            // 
            this.Tbvoor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.Tbvoor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Tbvoor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbvoor.ForeColor = System.Drawing.Color.Black;
            this.Tbvoor.Location = new System.Drawing.Point(41, 50);
            this.Tbvoor.Multiline = true;
            this.Tbvoor.Name = "Tbvoor";
            this.Tbvoor.Size = new System.Drawing.Size(252, 27);
            this.Tbvoor.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Voornaam";
            // 
            // InschrijvenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 270);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbStud);
            this.Controls.Add(this.Tbvoor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "InschrijvenFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbStud;
        private System.Windows.Forms.TextBox Tbvoor;
        private System.Windows.Forms.Label label1;
    }
}
