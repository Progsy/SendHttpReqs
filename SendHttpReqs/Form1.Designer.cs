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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(90, 13);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(503, 20);
            this.urlBox.TabIndex = 0;
            // 
            // reqpayloadBox
            // 
            this.reqpayloadBox.Location = new System.Drawing.Point(13, 186);
            this.reqpayloadBox.Name = "reqpayloadBox";
            this.reqpayloadBox.Size = new System.Drawing.Size(241, 125);
            this.reqpayloadBox.TabIndex = 1;
            this.reqpayloadBox.Text = "";
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
            this.contenttypeBox.Location = new System.Drawing.Point(90, 40);
            this.contenttypeBox.Name = "contenttypeBox";
            this.contenttypeBox.Size = new System.Drawing.Size(184, 20);
            this.contenttypeBox.TabIndex = 6;
            // 
            // statlab
            // 
            this.statlab.AutoSize = true;
            this.statlab.Location = new System.Drawing.Point(301, 166);
            this.statlab.Name = "statlab";
            this.statlab.Size = new System.Drawing.Size(0, 13);
            this.statlab.TabIndex = 7;
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
            this.savebutton.Location = new System.Drawing.Point(13, 317);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Content-Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Payload";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.textBox1.Location = new System.Drawing.Point(470, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "New Request";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 352);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

