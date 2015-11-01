namespace Convert_IT
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConvertToPdf = new System.Windows.Forms.Button();
            this.btnPathToPdf = new System.Windows.Forms.Button();
            this.btbbrowsedoctopdf = new System.Windows.Forms.Button();
            this.txtoutputLocationToPdf = new System.Windows.Forms.TextBox();
            this.txtdoctopdf = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnbrowseoutputLocation = new System.Windows.Forms.Button();
            this.txtoutputLocation = new System.Windows.Forms.TextBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnbrowsepdftodoc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 374);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConvertToPdf);
            this.tabPage1.Controls.Add(this.btnPathToPdf);
            this.tabPage1.Controls.Add(this.btbbrowsedoctopdf);
            this.tabPage1.Controls.Add(this.txtoutputLocationToPdf);
            this.tabPage1.Controls.Add(this.txtdoctopdf);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Red;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DOC To PDF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConvertToPdf
            // 
            this.btnConvertToPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConvertToPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConvertToPdf.Location = new System.Drawing.Point(179, 208);
            this.btnConvertToPdf.Name = "btnConvertToPdf";
            this.btnConvertToPdf.Size = new System.Drawing.Size(132, 46);
            this.btnConvertToPdf.TabIndex = 6;
            this.btnConvertToPdf.Text = "CONVERT";
            this.btnConvertToPdf.UseVisualStyleBackColor = false;
            this.btnConvertToPdf.Click += new System.EventHandler(this.btnConvertToPdf_Click);
            // 
            // btnPathToPdf
            // 
            this.btnPathToPdf.Location = new System.Drawing.Point(354, 146);
            this.btnPathToPdf.Name = "btnPathToPdf";
            this.btnPathToPdf.Size = new System.Drawing.Size(105, 31);
            this.btnPathToPdf.TabIndex = 5;
            this.btnPathToPdf.Text = "Browse";
            this.btnPathToPdf.UseVisualStyleBackColor = true;
            this.btnPathToPdf.Click += new System.EventHandler(this.btnPathToPdf_Click);
            // 
            // btbbrowsedoctopdf
            // 
            this.btbbrowsedoctopdf.Location = new System.Drawing.Point(354, 92);
            this.btbbrowsedoctopdf.Name = "btbbrowsedoctopdf";
            this.btbbrowsedoctopdf.Size = new System.Drawing.Size(105, 31);
            this.btbbrowsedoctopdf.TabIndex = 4;
            this.btbbrowsedoctopdf.Text = "Browse";
            this.btbbrowsedoctopdf.UseVisualStyleBackColor = true;
            this.btbbrowsedoctopdf.Click += new System.EventHandler(this.btbbrowsedoctopdf_Click);
            // 
            // txtoutputLocationToPdf
            // 
            this.txtoutputLocationToPdf.Location = new System.Drawing.Point(62, 146);
            this.txtoutputLocationToPdf.Multiline = true;
            this.txtoutputLocationToPdf.Name = "txtoutputLocationToPdf";
            this.txtoutputLocationToPdf.Size = new System.Drawing.Size(249, 31);
            this.txtoutputLocationToPdf.TabIndex = 3;
            // 
            // txtdoctopdf
            // 
            this.txtdoctopdf.Location = new System.Drawing.Point(62, 92);
            this.txtdoctopdf.Multiline = true;
            this.txtdoctopdf.Name = "txtdoctopdf";
            this.txtdoctopdf.Size = new System.Drawing.Size(249, 31);
            this.txtdoctopdf.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConvert);
            this.tabPage2.Controls.Add(this.btnbrowseoutputLocation);
            this.tabPage2.Controls.Add(this.txtoutputLocation);
            this.tabPage2.Controls.Add(this.txtpath);
            this.tabPage2.Controls.Add(this.btnbrowsepdftodoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PDF To DOC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConvert.Location = new System.Drawing.Point(179, 207);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(132, 46);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnbrowseoutputLocation
            // 
            this.btnbrowseoutputLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowseoutputLocation.ForeColor = System.Drawing.Color.Red;
            this.btnbrowseoutputLocation.Location = new System.Drawing.Point(354, 146);
            this.btnbrowseoutputLocation.Name = "btnbrowseoutputLocation";
            this.btnbrowseoutputLocation.Size = new System.Drawing.Size(105, 31);
            this.btnbrowseoutputLocation.TabIndex = 3;
            this.btnbrowseoutputLocation.Text = "Browse";
            this.btnbrowseoutputLocation.UseVisualStyleBackColor = true;
            this.btnbrowseoutputLocation.Click += new System.EventHandler(this.btnbrowseoutputLocation_Click);
            // 
            // txtoutputLocation
            // 
            this.txtoutputLocation.Location = new System.Drawing.Point(62, 146);
            this.txtoutputLocation.Multiline = true;
            this.txtoutputLocation.Name = "txtoutputLocation";
            this.txtoutputLocation.Size = new System.Drawing.Size(249, 31);
            this.txtoutputLocation.TabIndex = 2;
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(62, 92);
            this.txtpath.Multiline = true;
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(249, 31);
            this.txtpath.TabIndex = 1;
            // 
            // btnbrowsepdftodoc
            // 
            this.btnbrowsepdftodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowsepdftodoc.ForeColor = System.Drawing.Color.Red;
            this.btnbrowsepdftodoc.Location = new System.Drawing.Point(354, 92);
            this.btnbrowsepdftodoc.Name = "btnbrowsepdftodoc";
            this.btnbrowsepdftodoc.Size = new System.Drawing.Size(105, 31);
            this.btnbrowsepdftodoc.TabIndex = 0;
            this.btnbrowsepdftodoc.Text = "Browse";
            this.btnbrowsepdftodoc.UseVisualStyleBackColor = true;
            this.btnbrowsepdftodoc.Click += new System.EventHandler(this.btnbrowsepdftodoc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 374);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Convert-It";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnbrowsepdftodoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnbrowseoutputLocation;
        private System.Windows.Forms.TextBox txtoutputLocation;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnConvertToPdf;
        private System.Windows.Forms.Button btnPathToPdf;
        private System.Windows.Forms.Button btbbrowsedoctopdf;
        private System.Windows.Forms.TextBox txtoutputLocationToPdf;
        private System.Windows.Forms.TextBox txtdoctopdf;
    }
}

