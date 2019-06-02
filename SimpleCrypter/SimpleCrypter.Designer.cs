namespace SimpleCrypter
{
    partial class SimpleCrypter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleCrypter));
            this.filedialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_randpw = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filedialog
            // 
            this.filedialog.FileName = "File to encrypt";
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.BackColor = System.Drawing.Color.Black;
            this.btn_encrypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_encrypt.Location = new System.Drawing.Point(353, 189);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(80, 26);
            this.btn_encrypt.TabIndex = 0;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = false;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // tb_file
            // 
            this.tb_file.BackColor = System.Drawing.Color.Black;
            this.tb_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_file.ForeColor = System.Drawing.Color.White;
            this.tb_file.Location = new System.Drawing.Point(32, 54);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(315, 26);
            this.tb_file.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Black;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(32, 99);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(315, 26);
            this.tb_password.TabIndex = 2;
            // 
            // btn_file
            // 
            this.btn_file.BackColor = System.Drawing.Color.Black;
            this.btn_file.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.ForeColor = System.Drawing.Color.White;
            this.btn_file.Location = new System.Drawing.Point(353, 54);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(80, 26);
            this.btn_file.TabIndex = 4;
            this.btn_file.Text = "Choose";
            this.btn_file.UseVisualStyleBackColor = false;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_randpw
            // 
            this.btn_randpw.BackColor = System.Drawing.Color.Black;
            this.btn_randpw.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_randpw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_randpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_randpw.ForeColor = System.Drawing.Color.White;
            this.btn_randpw.Location = new System.Drawing.Point(353, 99);
            this.btn_randpw.Name = "btn_randpw";
            this.btn_randpw.Size = new System.Drawing.Size(80, 26);
            this.btn_randpw.TabIndex = 9;
            this.btn_randpw.Text = "Random";
            this.btn_randpw.UseVisualStyleBackColor = false;
            this.btn_randpw.Click += new System.EventHandler(this.btn_randpw_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Black;
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(32, 229);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status";
            // 
            // folder_dialog
            // 
            this.folder_dialog.Description = "Select output location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SimpleCrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(465, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_randpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_file);
            this.Controls.Add(this.btn_encrypt);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimpleCrypter";
            this.Text = "SimpleCrypter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog filedialog;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_randpw;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.FolderBrowserDialog folder_dialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

