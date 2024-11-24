namespace Bank1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_createnewaccount = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_passlogin = new System.Windows.Forms.TextBox();
            this.textBox_userlogin = new System.Windows.Forms.TextBox();
            this.label_passlogin = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_createnewaccount);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.textBox_passlogin);
            this.panel1.Controls.Add(this.textBox_userlogin);
            this.panel1.Controls.Add(this.label_passlogin);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Location = new System.Drawing.Point(135, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 414);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button_createnewaccount
            // 
            this.button_createnewaccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_createnewaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_createnewaccount.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createnewaccount.Location = new System.Drawing.Point(150, 365);
            this.button_createnewaccount.Name = "button_createnewaccount";
            this.button_createnewaccount.Size = new System.Drawing.Size(282, 46);
            this.button_createnewaccount.TabIndex = 5;
            this.button_createnewaccount.Text = "CREATE NEW ACCOUNT";
            this.button_createnewaccount.UseVisualStyleBackColor = false;
            this.button_createnewaccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(150, 295);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(282, 38);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_passlogin
            // 
            this.textBox_passlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passlogin.Location = new System.Drawing.Point(178, 227);
            this.textBox_passlogin.Multiline = true;
            this.textBox_passlogin.Name = "textBox_passlogin";
            this.textBox_passlogin.Size = new System.Drawing.Size(275, 35);
            this.textBox_passlogin.TabIndex = 3;
            // 
            // textBox_userlogin
            // 
            this.textBox_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userlogin.Location = new System.Drawing.Point(178, 157);
            this.textBox_userlogin.Multiline = true;
            this.textBox_userlogin.Name = "textBox_userlogin";
            this.textBox_userlogin.Size = new System.Drawing.Size(275, 38);
            this.textBox_userlogin.TabIndex = 2;
            // 
            // label_passlogin
            // 
            this.label_passlogin.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passlogin.Location = new System.Drawing.Point(3, 223);
            this.label_passlogin.Name = "label_passlogin";
            this.label_passlogin.Size = new System.Drawing.Size(183, 39);
            this.label_passlogin.TabIndex = 1;
            this.label_passlogin.Text = "PASSWORD";
            // 
            // label_username
            // 
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(-2, 157);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(174, 39);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "USERNAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_createnewaccount;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_passlogin;
        private System.Windows.Forms.TextBox textBox_userlogin;
        private System.Windows.Forms.Label label_passlogin;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

