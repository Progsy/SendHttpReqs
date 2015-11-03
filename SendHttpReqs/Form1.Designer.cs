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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.reqpayloadBox = new System.Windows.Forms.RichTextBox();
            this.sendReqButton = new System.Windows.Forms.Button();
            this.serverrespBox = new System.Windows.Forms.RichTextBox();
            this.contenttypeBox = new System.Windows.Forms.TextBox();
            this.statlab = new System.Windows.Forms.Label();
            this.savedreqs = new System.Windows.Forms.ListBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(13, 13);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(580, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "Url";
            // 
            // reqpayloadBox
            // 
            this.reqpayloadBox.Location = new System.Drawing.Point(13, 186);
            this.reqpayloadBox.Name = "reqpayloadBox";
            this.reqpayloadBox.Size = new System.Drawing.Size(241, 125);
            this.reqpayloadBox.TabIndex = 1;
            this.reqpayloadBox.Text = "Payload";
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
            this.contenttypeBox.Text = "Content-Type";
            // 
            // statlab
            // 
            this.statlab.AutoSize = true;
            this.statlab.Location = new System.Drawing.Point(260, 170);
            this.statlab.Name = "statlab";
            this.statlab.Size = new System.Drawing.Size(43, 13);
            this.statlab.TabIndex = 7;
            this.statlab.Text = "Status: ";
            // 
            // savedreqs
            // 
            this.savedreqs.FormattingEnabled = true;
            this.savedreqs.Location = new System.Drawing.Point(412, 39);
            this.savedreqs.Name = "savedreqs";
            this.savedreqs.Size = new System.Drawing.Size(181, 121);
            this.savedreqs.TabIndex = 8;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(437, 317);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 352);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.savedreqs);
            this.Controls.Add(this.statlab);
            this.Controls.Add(this.contenttypeBox);
            this.Controls.Add(this.serverrespBox);
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
        private System.Windows.Forms.RichTextBox serverrespBox;
        private System.Windows.Forms.TextBox contenttypeBox;
        private System.Windows.Forms.Label statlab;
        private System.Windows.Forms.ListBox savedreqs;
        private System.Windows.Forms.Button savebutton;
    }
}

