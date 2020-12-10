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
            this.buttoncsv = new System.Windows.Forms.Button();
            this.buttonexcel = new System.Windows.Forms.Button();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.buttondelete = new System.Windows.Forms.Button();
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
            this.buttoncsv.Location = new System.Drawing.Point(22, 199);
            this.buttoncsv.Name = "buttoncsv";
            this.buttoncsv.Size = new System.Drawing.Size(122, 102);
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
            this.buttonexcel.Location = new System.Drawing.Point(278, 199);
            this.buttonexcel.Name = "buttonexcel";
            this.buttonexcel.Size = new System.Drawing.Size(122, 102);
            this.buttonexcel.TabIndex = 6;
            this.buttonexcel.Text = "Formázott excel";
            this.buttonexcel.UseVisualStyleBackColor = false;
            this.buttonexcel.Click += new System.EventHandler(this.buttonexcel_Click);
            // 
            // dgw
            // 
            this.dgw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(22, 319);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 62;
            this.dgw.RowTemplate.Height = 28;
            this.dgw.Size = new System.Drawing.Size(1587, 457);
            this.dgw.TabIndex = 8;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttondelete.Location = new System.Drawing.Point(150, 199);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(122, 102);
            this.buttondelete.TabIndex = 9;
            this.buttondelete.Text = "Törlés";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1630, 788);
            this.Controls.Add(this.buttondelete);
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
        private System.Windows.Forms.Button buttondelete;
    }
}

