namespace tokcz
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
            this.panel1main = new System.Windows.Forms.Panel();
            this.button2birds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1main
            // 
            this.panel1main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1main.AutoSize = true;
            this.panel1main.Location = new System.Drawing.Point(22, 318);
            this.panel1main.Name = "panel1main";
            this.panel1main.Size = new System.Drawing.Size(878, 446);
            this.panel1main.TabIndex = 5;
            // 
            // button2birds
            // 
            this.button2birds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2birds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2birds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2birds.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2birds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2birds.Location = new System.Drawing.Point(22, 251);
            this.button2birds.Name = "button2birds";
            this.button2birds.Size = new System.Drawing.Size(202, 50);
            this.button2birds.TabIndex = 3;
            this.button2birds.Text = "Madárfaj hozzáadása";
            this.button2birds.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(926, 788);
            this.Controls.Add(this.button2birds);
            this.Controls.Add(this.panel1main);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1main;
        private System.Windows.Forms.Button button2birds;
    }
}

