﻿namespace tokcz
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
            this.buttoncsv = new System.Windows.Forms.Button();
            this.buttonexcel = new System.Windows.Forms.Button();
            this.dgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoncsv
            // 
            this.buttoncsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttoncsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncsv.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttoncsv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttoncsv.Location = new System.Drawing.Point(22, 251);
            this.buttoncsv.Name = "buttoncsv";
            this.buttoncsv.Size = new System.Drawing.Size(105, 50);
            this.buttoncsv.TabIndex = 3;
            this.buttoncsv.Text = "CSV file beolvasása";
            this.buttoncsv.UseVisualStyleBackColor = false;
            this.buttoncsv.Click += new System.EventHandler(this.buttoncsv_Click);
            // 
            // buttonexcel
            // 
            this.buttonexcel.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexcel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonexcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonexcel.Location = new System.Drawing.Point(147, 251);
            this.buttonexcel.Name = "buttonexcel";
            this.buttonexcel.Size = new System.Drawing.Size(105, 50);
            this.buttonexcel.TabIndex = 6;
            this.buttonexcel.Text = "Formázott excel";
            this.buttonexcel.UseVisualStyleBackColor = false;
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(22, 319);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 62;
            this.dgw.RowTemplate.Height = 28;
            this.dgw.Size = new System.Drawing.Size(892, 457);
            this.dgw.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(926, 788);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.buttonexcel);
            this.Controls.Add(this.buttoncsv);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttoncsv;
        private System.Windows.Forms.Button buttonexcel;
        private System.Windows.Forms.DataGridView dgw;
    }
}

