namespace QuanTri_UI
{
    partial class Main_UI
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
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tadControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.tabDK = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMK_DK = new System.Windows.Forms.TextBox();
            this.btnDK = new System.Windows.Forms.Button();
            this.txtTK_DK = new System.Windows.Forms.TextBox();
            this.tabDoi = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.btndoi = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tadControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabDK.SuspendLayout();
            this.tabDoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // dangKyToolStripMenuItem
            // 
            this.dangKyToolStripMenuItem.Name = "dangKyToolStripMenuItem";
            this.dangKyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tadControl
            // 
            this.tadControl.Controls.Add(this.tabLogin);
            this.tadControl.Controls.Add(this.tabDK);
            this.tadControl.Controls.Add(this.tabDoi);
            this.tadControl.Location = new System.Drawing.Point(12, 12);
            this.tadControl.Name = "tadControl";
            this.tadControl.SelectedIndex = 0;
            this.tadControl.Size = new System.Drawing.Size(371, 351);
            this.tadControl.TabIndex = 1;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.label9);
            this.tabLogin.Controls.Add(this.txtName);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Controls.Add(this.txtPass);
            this.tabLogin.Controls.Add(this.btnlogin);
            this.tabLogin.Controls.Add(this.txtTK);
            this.tabLogin.Location = new System.Drawing.Point(4, 25);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(363, 322);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Dang nhap";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "mat khau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "tai khoan";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(105, 93);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(154, 22);
            this.txtPass.TabIndex = 9;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(96, 199);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(122, 45);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Dang nhap";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(105, 43);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(154, 22);
            this.txtTK.TabIndex = 6;
            // 
            // tabDK
            // 
            this.tabDK.Controls.Add(this.label5);
            this.tabDK.Controls.Add(this.txtIP);
            this.tabDK.Controls.Add(this.label3);
            this.tabDK.Controls.Add(this.label4);
            this.tabDK.Controls.Add(this.txtMK_DK);
            this.tabDK.Controls.Add(this.btnDK);
            this.tabDK.Controls.Add(this.txtTK_DK);
            this.tabDK.Location = new System.Drawing.Point(4, 25);
            this.tabDK.Name = "tabDK";
            this.tabDK.Padding = new System.Windows.Forms.Padding(3);
            this.tabDK.Size = new System.Drawing.Size(363, 322);
            this.tabDK.TabIndex = 1;
            this.tabDK.Text = "Dang ky";
            this.tabDK.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(123, 135);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(154, 22);
            this.txtIP.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "mat khau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "tai khoan";
            // 
            // txtMK_DK
            // 
            this.txtMK_DK.Location = new System.Drawing.Point(123, 80);
            this.txtMK_DK.Name = "txtMK_DK";
            this.txtMK_DK.Size = new System.Drawing.Size(154, 22);
            this.txtMK_DK.TabIndex = 9;
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(56, 192);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(122, 45);
            this.btnDK.TabIndex = 7;
            this.btnDK.Text = "Dang ky";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // txtTK_DK
            // 
            this.txtTK_DK.Location = new System.Drawing.Point(123, 30);
            this.txtTK_DK.Name = "txtTK_DK";
            this.txtTK_DK.Size = new System.Drawing.Size(154, 22);
            this.txtTK_DK.TabIndex = 6;
            // 
            // tabDoi
            // 
            this.tabDoi.Controls.Add(this.label6);
            this.tabDoi.Controls.Add(this.newPass);
            this.tabDoi.Controls.Add(this.label7);
            this.tabDoi.Controls.Add(this.label8);
            this.tabDoi.Controls.Add(this.oldPass);
            this.tabDoi.Controls.Add(this.btndoi);
            this.tabDoi.Controls.Add(this.user);
            this.tabDoi.Location = new System.Drawing.Point(4, 25);
            this.tabDoi.Name = "tabDoi";
            this.tabDoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoi.Size = new System.Drawing.Size(363, 322);
            this.tabDoi.TabIndex = 2;
            this.tabDoi.Text = "Doi mat khau";
            this.tabDoi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "mat khau moi";
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(123, 136);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(154, 22);
            this.newPass.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "mat khau cu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "tai khoan";
            // 
            // oldPass
            // 
            this.oldPass.Location = new System.Drawing.Point(121, 81);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(154, 22);
            this.oldPass.TabIndex = 16;
            // 
            // btndoi
            // 
            this.btndoi.Location = new System.Drawing.Point(44, 193);
            this.btndoi.Name = "btndoi";
            this.btndoi.Size = new System.Drawing.Size(122, 45);
            this.btndoi.TabIndex = 15;
            this.btndoi.Text = "Doi mat khau";
            this.btndoi.UseVisualStyleBackColor = true;
            this.btndoi.Click += new System.EventHandler(this.btndoi_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(120, 31);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(154, 22);
            this.user.TabIndex = 14;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(424, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 61);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(424, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 63);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close Server";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnout
            // 
            this.btnout.Location = new System.Drawing.Point(424, 61);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(113, 61);
            this.btnout.TabIndex = 16;
            this.btnout.Text = "Thoat";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 22);
            this.txtName.TabIndex = 12;
            // 
            // Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 367);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tadControl);
            this.Name = "Main_UI";
            this.Text = "Main";
            this.tadControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabDK.ResumeLayout(false);
            this.tabDK.PerformLayout();
            this.tabDoi.ResumeLayout(false);
            this.tabDoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangKyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.TabControl tadControl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMK_DK;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.TextBox txtTK_DK;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.TabPage tabDoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Button btndoi;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
    }
}

