namespace CodingTheTweet
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
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.btwTweet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsumerSecret = new System.Windows.Forms.TextBox();
            this.txtConsumerKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTweet
            // 
            this.txtTweet.Location = new System.Drawing.Point(12, 12);
            this.txtTweet.Multiline = true;
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(443, 46);
            this.txtTweet.TabIndex = 0;
            // 
            // btwTweet
            // 
            this.btwTweet.Location = new System.Drawing.Point(12, 65);
            this.btwTweet.Name = "btwTweet";
            this.btwTweet.Size = new System.Drawing.Size(123, 23);
            this.btwTweet.TabIndex = 1;
            this.btwTweet.Text = "Tweet It";
            this.btwTweet.UseVisualStyleBackColor = true;
            this.btwTweet.Click += new System.EventHandler(this.btwTweet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(285, 140);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConsumerSecret);
            this.groupBox1.Controls.Add(this.txtConsumerKey);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Custom Application Settings ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the values specified on your Twitter custom application settings page. You " +
                "will only have to do this once.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumer secret:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consumer key:";
            // 
            // txtConsumerSecret
            // 
            this.txtConsumerSecret.Location = new System.Drawing.Point(117, 111);
            this.txtConsumerSecret.Name = "txtConsumerSecret";
            this.txtConsumerSecret.Size = new System.Drawing.Size(305, 20);
            this.txtConsumerSecret.TabIndex = 1;
            this.txtConsumerSecret.TextChanged += new System.EventHandler(this.txtConsumerKey_TextChanged);
            // 
            // txtConsumerKey
            // 
            this.txtConsumerKey.Location = new System.Drawing.Point(117, 79);
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.Size = new System.Drawing.Size(305, 20);
            this.txtConsumerKey.TabIndex = 0;
            this.txtConsumerKey.TextChanged += new System.EventHandler(this.txtConsumerKey_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save these settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btwTweet);
            this.Controls.Add(this.txtTweet);
            this.Name = "Form1";
            this.Text = "Generic Twitter Client (by Coding the Wheel)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.Button btwTweet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsumerSecret;
        private System.Windows.Forms.TextBox txtConsumerKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
    }
}

