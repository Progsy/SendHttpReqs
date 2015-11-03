namespace SendHttpReqs
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.reqpayloadBox = new System.Windows.Forms.RichTextBox();
            this.sendReqButton = new System.Windows.Forms.Button();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.serverrespBox = new System.Windows.Forms.RichTextBox();
            this.contenttypeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(13, 13);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(580, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = resources.GetString("urlBox.Text");
            // 
            // reqpayloadBox
            // 
            this.reqpayloadBox.Location = new System.Drawing.Point(13, 185);
            this.reqpayloadBox.Name = "reqpayloadBox";
            this.reqpayloadBox.Size = new System.Drawing.Size(241, 155);
            this.reqpayloadBox.TabIndex = 1;
            this.reqpayloadBox.Text = resources.GetString("reqpayloadBox.Text");
            // 
            // sendReqButton
            // 
            this.sendReqButton.Location = new System.Drawing.Point(518, 317);
            this.sendReqButton.Name = "sendReqButton";
            this.sendReqButton.Size = new System.Drawing.Size(75, 23);
            this.sendReqButton.TabIndex = 3;
            this.sendReqButton.Text = "Send";
            this.sendReqButton.UseVisualStyleBackColor = true;
            this.sendReqButton.Click += new System.EventHandler(this.sendReqButton_Click);
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(261, 40);
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(332, 139);
            this.responseBox.TabIndex = 4;
            this.responseBox.Text = "Response";
            // 
            // serverrespBox
            // 
            this.serverrespBox.Location = new System.Drawing.Point(261, 186);
            this.serverrespBox.Name = "serverrespBox";
            this.serverrespBox.Size = new System.Drawing.Size(332, 125);
            this.serverrespBox.TabIndex = 5;
            this.serverrespBox.Text = "Response From Server";
            // 
            // contenttypeBox
            // 
            this.contenttypeBox.Location = new System.Drawing.Point(13, 40);
            this.contenttypeBox.Name = "contenttypeBox";
            this.contenttypeBox.Size = new System.Drawing.Size(241, 20);
            this.contenttypeBox.TabIndex = 6;
            this.contenttypeBox.Text = "application/x-www-form-urlencoded;charset=UTF-8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 352);
            this.Controls.Add(this.contenttypeBox);
            this.Controls.Add(this.serverrespBox);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.sendReqButton);
            this.Controls.Add(this.reqpayloadBox);
            this.Controls.Add(this.urlBox);
            this.Name = "Form1";
            this.Text = "HttpRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.RichTextBox reqpayloadBox;
        private System.Windows.Forms.Button sendReqButton;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.RichTextBox serverrespBox;
        private System.Windows.Forms.TextBox contenttypeBox;
    }
}

