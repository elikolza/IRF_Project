﻿namespace tokcz
{
    partial class Form2
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttoncsv = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonxls = new System.Windows.Forms.Button();
            this.buttonmikro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(178, 228);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(521, 488);
            this.dataGridView.TabIndex = 0;
            // 
            // buttoncsv
            // 
            this.buttoncsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttoncsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncsv.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttoncsv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttoncsv.Location = new System.Drawing.Point(39, 228);
            this.buttoncsv.Name = "buttoncsv";
            this.buttoncsv.Size = new System.Drawing.Size(122, 61);
            this.buttoncsv.TabIndex = 4;
            this.buttoncsv.Text = "CSV file beolvasása";
            this.buttoncsv.UseVisualStyleBackColor = false;
            this.buttoncsv.Click += new System.EventHandler(this.buttoncsv_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.Tan;
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttondelete.Location = new System.Drawing.Point(39, 294);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(122, 45);
            this.buttondelete.TabIndex = 10;
            this.buttondelete.Text = "Törlés";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Üdvözlünk az oldalunkon!";
            // 
            // buttonxls
            // 
            this.buttonxls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonxls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonxls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonxls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonxls.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonxls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonxls.Location = new System.Drawing.Point(752, 293);
            this.buttonxls.Name = "buttonxls";
            this.buttonxls.Size = new System.Drawing.Size(132, 46);
            this.buttonxls.TabIndex = 12;
            this.buttonxls.Text = "Excel";
            this.buttonxls.UseVisualStyleBackColor = false;
            this.buttonxls.Click += new System.EventHandler(this.buttonxls_Click);
            // 
            // buttonmikro
            // 
            this.buttonmikro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmikro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonmikro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmikro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmikro.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonmikro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonmikro.Location = new System.Drawing.Point(722, 228);
            this.buttonmikro.Name = "buttonmikro";
            this.buttonmikro.Size = new System.Drawing.Size(192, 45);
            this.buttonmikro.TabIndex = 18;
            this.buttonmikro.Text = "Mikroszimuláció";
            this.buttonmikro.UseVisualStyleBackColor = false;
            this.buttonmikro.Click += new System.EventHandler(this.buttonmikro_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(926, 788);
            this.Controls.Add(this.buttonmikro);
            this.Controls.Add(this.buttonxls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttoncsv);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttoncsv;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonxls;
        private System.Windows.Forms.Button buttonmikro;
    }
}