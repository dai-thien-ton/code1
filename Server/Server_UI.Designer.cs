namespace Server
{
    partial class Server_UI
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
            this.ServerSend = new System.Windows.Forms.Button();
            this.ServerMessage = new System.Windows.Forms.TextBox();
            this.ServerChat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ServerSend
            // 
            this.ServerSend.Location = new System.Drawing.Point(670, 386);
            this.ServerSend.Name = "ServerSend";
            this.ServerSend.Size = new System.Drawing.Size(93, 46);
            this.ServerSend.TabIndex = 5;
            this.ServerSend.Text = "Send";
            this.ServerSend.UseVisualStyleBackColor = true;
            this.ServerSend.Click += new System.EventHandler(this.ServerSend_Click);
            // 
            // ServerMessage
            // 
            this.ServerMessage.Location = new System.Drawing.Point(35, 386);
            this.ServerMessage.Multiline = true;
            this.ServerMessage.Name = "ServerMessage";
            this.ServerMessage.Size = new System.Drawing.Size(619, 46);
            this.ServerMessage.TabIndex = 4;
            // 
            // ServerChat
            // 
            this.ServerChat.HideSelection = false;
            this.ServerChat.Location = new System.Drawing.Point(12, 12);
            this.ServerChat.Name = "ServerChat";
            this.ServerChat.Size = new System.Drawing.Size(776, 354);
            this.ServerChat.TabIndex = 6;
            this.ServerChat.UseCompatibleStateImageBehavior = false;
            this.ServerChat.View = System.Windows.Forms.View.List;
            // 
            // Server_UI
            // 
            this.AcceptButton = this.ServerSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ServerChat);
            this.Controls.Add(this.ServerSend);
            this.Controls.Add(this.ServerMessage);
            this.Name = "Server_UI";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_UI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ServerSend;
        private System.Windows.Forms.TextBox ServerMessage;
        private System.Windows.Forms.ListView ServerChat;
    }
}

