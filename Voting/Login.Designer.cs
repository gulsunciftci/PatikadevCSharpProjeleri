namespace Voting
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerR = new System.Windows.Forms.LinkLabel();
            this.loginB = new System.Windows.Forms.Button();
            this.emailT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Voting.Properties.Resources.Vote_paper_put_in_election_box_on_transparent_background_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(40, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // registerR
            // 
            this.registerR.AutoSize = true;
            this.registerR.Location = new System.Drawing.Point(156, 317);
            this.registerR.Name = "registerR";
            this.registerR.Size = new System.Drawing.Size(95, 27);
            this.registerR.TabIndex = 12;
            this.registerR.TabStop = true;
            this.registerR.Text = "Register";
            this.registerR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerR_LinkClicked);
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(278, 306);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(111, 48);
            this.loginB.TabIndex = 11;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(156, 245);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(233, 34);
            this.emailT.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(156, 184);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(233, 34);
            this.fullName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "FullName";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerR);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.emailT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel registerR;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label1;
    }
}
