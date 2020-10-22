namespace SARK_Chat2
{
    partial class PostItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoundedPanel = new SARK_Chat2.RoundedPanel();
            this.MessageBody = new System.Windows.Forms.TextBox();
            this.TimeSentLabel = new System.Windows.Forms.Label();
            this.PostContainer = new System.Windows.Forms.Panel();
            this.RoundedPanel.SuspendLayout();
            this.PostContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoundedPanel
            // 
            this.RoundedPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RoundedPanel.Controls.Add(this.MessageBody);
            this.RoundedPanel.Location = new System.Drawing.Point(0, 0);
            this.RoundedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RoundedPanel.MaximumSize = new System.Drawing.Size(198, 595);
            this.RoundedPanel.MinimumSize = new System.Drawing.Size(100, 20);
            this.RoundedPanel.Name = "RoundedPanel";
            this.RoundedPanel.Padding = new System.Windows.Forms.Padding(9, 6, 9, 0);
            this.RoundedPanel.Size = new System.Drawing.Size(198, 20);
            this.RoundedPanel.TabIndex = 2;
            // 
            // MessageBody
            // 
            this.MessageBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessageBody.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MessageBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageBody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MessageBody.Location = new System.Drawing.Point(0, 1);
            this.MessageBody.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.MessageBody.MaximumSize = new System.Drawing.Size(190, 590);
            this.MessageBody.MinimumSize = new System.Drawing.Size(38, 30);
            this.MessageBody.Multiline = true;
            this.MessageBody.Name = "MessageBody";
            this.MessageBody.ReadOnly = true;
            this.MessageBody.Size = new System.Drawing.Size(190, 30);
            this.MessageBody.TabIndex = 2;
            // 
            // TimeSentLabel
            // 
            this.TimeSentLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TimeSentLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimeSentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TimeSentLabel.Location = new System.Drawing.Point(0, 25);
            this.TimeSentLabel.MaximumSize = new System.Drawing.Size(198, 15);
            this.TimeSentLabel.MinimumSize = new System.Drawing.Size(40, 15);
            this.TimeSentLabel.Name = "TimeSentLabel";
            this.TimeSentLabel.Size = new System.Drawing.Size(40, 15);
            this.TimeSentLabel.TabIndex = 1;
            // 
            // PostContainer
            // 
            this.PostContainer.Controls.Add(this.TimeSentLabel);
            this.PostContainer.Controls.Add(this.RoundedPanel);
            this.PostContainer.Location = new System.Drawing.Point(0, 0);
            this.PostContainer.MaximumSize = new System.Drawing.Size(198, 650);
            this.PostContainer.MinimumSize = new System.Drawing.Size(198, 20);
            this.PostContainer.Name = "PostContainer";
            this.PostContainer.Size = new System.Drawing.Size(198, 44);
            this.PostContainer.TabIndex = 3;
            // 
            // PostItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.PostContainer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.MaximumSize = new System.Drawing.Size(340, 655);
            this.MinimumSize = new System.Drawing.Size(300, 40);
            this.Name = "PostItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Size = new System.Drawing.Size(300, 46);
            this.RoundedPanel.ResumeLayout(false);
            this.RoundedPanel.PerformLayout();
            this.PostContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel RoundedPanel;
        private System.Windows.Forms.Label TimeSentLabel;
        private System.Windows.Forms.TextBox MessageBody;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel PostContainer;
    }
}
