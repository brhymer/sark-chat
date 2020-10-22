namespace SARK_Chat2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.ComposeMessage = new System.Windows.Forms.TextBox();
            this.PostsPanel = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.EnterPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Location = new System.Drawing.Point(321, 599);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(54, 21);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Visible = false;
            // 
            // ComposeMessage
            // 
            this.ComposeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComposeMessage.Location = new System.Drawing.Point(56, 599);
            this.ComposeMessage.Multiline = true;
            this.ComposeMessage.Name = "ComposeMessage";
            this.ComposeMessage.PlaceholderText = "Enter a message";
            this.ComposeMessage.Size = new System.Drawing.Size(259, 52);
            this.ComposeMessage.TabIndex = 5;
            this.ComposeMessage.Visible = false;
            this.ComposeMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterMessage);
            // 
            // PostsPanel
            // 
            this.PostsPanel.AutoScroll = true;
            this.PostsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PostsPanel.Location = new System.Drawing.Point(32, 80);
            this.PostsPanel.Name = "PostsPanel";
            this.PostsPanel.Size = new System.Drawing.Size(357, 500);
            this.PostsPanel.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Label1.Location = new System.Drawing.Point(46, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(21, 15);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "+1";
            // 
            // EnterPhoneNumber
            // 
            this.EnterPhoneNumber.AcceptsReturn = true;
            this.EnterPhoneNumber.Location = new System.Drawing.Point(74, 40);
            this.EnterPhoneNumber.Name = "EnterPhoneNumber";
            this.EnterPhoneNumber.PlaceholderText = "Enter the phone number of the client...";
            this.EnterPhoneNumber.Size = new System.Drawing.Size(228, 23);
            this.EnterPhoneNumber.TabIndex = 1;
            this.EnterPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterPN_Return);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 663);
            this.Controls.Add(this.EnterPhoneNumber);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PostsPanel);
            this.Controls.Add(this.ComposeMessage);
            this.Controls.Add(this.SendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox ComposeMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterPhoneNumber;
        private System.Windows.Forms.Panel PostsPanel;
        private System.Windows.Forms.Label Label1;
    }
}

