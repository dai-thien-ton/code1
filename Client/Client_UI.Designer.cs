namespace WindowsFormsApp1
{
    partial class Client_UI
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.lbip = new System.Windows.Forms.Label();
            this.ChatBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(35, 380);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(619, 46);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(670, 380);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(93, 46);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // lbip
            // 
            this.lbip.AutoSize = true;
            this.lbip.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbip.Location = new System.Drawing.Point(373, 9);
            this.lbip.Name = "lbip";
            this.lbip.Size = new System.Drawing.Size(41, 19);
            this.lbip.TabIndex = 4;
            this.lbip.Text = "........";
            // 
            // ChatBox
            // 
            this.ChatBox.HideSelection = false;
            this.ChatBox.Location = new System.Drawing.Point(12, 31);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(776, 343);
            this.ChatBox.TabIndex = 7;
            this.ChatBox.UseCompatibleStateImageBehavior = false;
            this.ChatBox.View = System.Windows.Forms.View.List;
            // 
            // Client_UI
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.lbip);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.txtMessage);
            this.Name = "Client_UI";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label lbip;
        private System.Windows.Forms.ListView ChatBox;
    }
}

