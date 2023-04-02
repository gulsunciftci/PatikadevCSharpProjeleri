namespace Voting
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.emailT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerB = new System.Windows.Forms.Button();
            this.loginL = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "FullName";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(161, 186);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(233, 34);
            this.fullName.TabIndex = 1;
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(161, 247);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(233, 34);
            this.emailT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // registerB
            // 
            this.registerB.Location = new System.Drawing.Point(283, 308);
            this.registerB.Name = "registerB";
            this.registerB.Size = new System.Drawing.Size(111, 48);
            this.registerB.TabIndex = 4;
            this.registerB.Text = "Register";
            this.registerB.UseVisualStyleBackColor = true;
            this.registerB.Click += new System.EventHandler(this.registerB_Click);
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Location = new System.Drawing.Point(180, 319);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(68, 27);
            this.loginL.TabIndex = 5;
            this.loginL.TabStop = true;
            this.loginL.Text = "Login";
            this.loginL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginL_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Voting.Properties.Resources.Vote_paper_put_in_election_box_on_transparent_background_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.registerB);
            this.Controls.Add(this.emailT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerB;
        private System.Windows.Forms.LinkLabel loginL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}