namespace tokcz
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxfile = new System.Windows.Forms.TextBox();
            this.textBoxdatas = new System.Windows.Forms.TextBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonbrowse = new System.Windows.Forms.Button();
            this.buttonstart = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Záróév";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Népességfájl";
            // 
            // textBoxfile
            // 
            this.textBoxfile.Location = new System.Drawing.Point(375, 22);
            this.textBoxfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxfile.Name = "textBoxfile";
            this.textBoxfile.Size = new System.Drawing.Size(493, 26);
            this.textBoxfile.TabIndex = 7;
            // 
            // textBoxdatas
            // 
            this.textBoxdatas.Location = new System.Drawing.Point(49, 106);
            this.textBoxdatas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxdatas.Multiline = true;
            this.textBoxdatas.Name = "textBoxdatas";
            this.textBoxdatas.Size = new System.Drawing.Size(835, 650);
            this.textBoxdatas.TabIndex = 11;
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsave.Font = new System.Drawing.Font("Calibri", 8F);
            this.buttonsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonsave.Location = new System.Drawing.Point(722, 61);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(80, 35);
            this.buttonsave.TabIndex = 14;
            this.buttonsave.Text = "Mentés";
            this.buttonsave.UseVisualStyleBackColor = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttonbrowse
            // 
            this.buttonbrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbrowse.Font = new System.Drawing.Font("Calibri", 8F);
            this.buttonbrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonbrowse.Location = new System.Drawing.Point(447, 58);
            this.buttonbrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonbrowse.Name = "buttonbrowse";
            this.buttonbrowse.Size = new System.Drawing.Size(112, 35);
            this.buttonbrowse.TabIndex = 13;
            this.buttonbrowse.Text = "Böngészés";
            this.buttonbrowse.UseVisualStyleBackColor = false;
            this.buttonbrowse.Click += new System.EventHandler(this.buttonbrowse_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.BackColor = System.Drawing.Color.Tan;
            this.buttonstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonstart.Font = new System.Drawing.Font("Calibri", 8F);
            this.buttonstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonstart.Location = new System.Drawing.Point(568, 58);
            this.buttonstart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(146, 38);
            this.buttonstart.TabIndex = 12;
            this.buttonstart.Text = "Indít";
            this.buttonstart.UseVisualStyleBackColor = false;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(102, 26);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(926, 788);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttonbrowse);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.textBoxdatas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxfile);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxfile;
        private System.Windows.Forms.TextBox textBoxdatas;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonbrowse;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}