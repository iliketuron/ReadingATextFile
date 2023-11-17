namespace WindowsFormsApp2
{
    partial class FrmStudentRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.VrRegister = new System.Windows.Forms.Button();
            this.VrFind = new System.Windows.Forms.Button();
            this.VrUpload = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Record";
            // 
            // VrRegister
            // 
            this.VrRegister.BackColor = System.Drawing.Color.LightCyan;
            this.VrRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VrRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VrRegister.Location = new System.Drawing.Point(441, 41);
            this.VrRegister.Name = "VrRegister";
            this.VrRegister.Size = new System.Drawing.Size(116, 35);
            this.VrRegister.TabIndex = 40;
            this.VrRegister.Text = "Register";
            this.VrRegister.UseVisualStyleBackColor = false;
            this.VrRegister.Click += new System.EventHandler(this.VrRegister_Click);
            // 
            // VrFind
            // 
            this.VrFind.BackColor = System.Drawing.Color.LightCyan;
            this.VrFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VrFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VrFind.Location = new System.Drawing.Point(441, 97);
            this.VrFind.Name = "VrFind";
            this.VrFind.Size = new System.Drawing.Size(116, 35);
            this.VrFind.TabIndex = 41;
            this.VrFind.Text = "Find";
            this.VrFind.UseVisualStyleBackColor = false;
            this.VrFind.Click += new System.EventHandler(this.VrFind_Click);
            // 
            // VrUpload
            // 
            this.VrUpload.BackColor = System.Drawing.Color.LightCyan;
            this.VrUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VrUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VrUpload.Location = new System.Drawing.Point(441, 150);
            this.VrUpload.Name = "VrUpload";
            this.VrUpload.Size = new System.Drawing.Size(116, 35);
            this.VrUpload.TabIndex = 42;
            this.VrUpload.Text = "Upload";
            this.VrUpload.UseVisualStyleBackColor = false;
            this.VrUpload.Click += new System.EventHandler(this.VrUpload_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 238);
            this.listBox1.TabIndex = 43;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 308);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.VrUpload);
            this.Controls.Add(this.VrFind);
            this.Controls.Add(this.VrRegister);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VrRegister;
        private System.Windows.Forms.Button VrFind;
        private System.Windows.Forms.Button VrUpload;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}