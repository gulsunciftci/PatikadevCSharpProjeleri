namespace Voting
{
    partial class Vote
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voteB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutB = new System.Windows.Forms.Button();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Voting.Properties.Resources.Vote_paper_put_in_election_box_on_transparent_background_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(36, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // voteB
            // 
            this.voteB.Location = new System.Drawing.Point(274, 312);
            this.voteB.Name = "voteB";
            this.voteB.Size = new System.Drawing.Size(111, 48);
            this.voteB.TabIndex = 11;
            this.voteB.Text = "Vote";
            this.voteB.UseVisualStyleBackColor = true;
            this.voteB.Click += new System.EventHandler(this.voteB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // logoutB
            // 
            this.logoutB.Location = new System.Drawing.Point(70, 312);
            this.logoutB.Name = "logoutB";
            this.logoutB.Size = new System.Drawing.Size(111, 48);
            this.logoutB.TabIndex = 14;
            this.logoutB.Text = "Logout";
            this.logoutB.UseVisualStyleBackColor = true;
            // 
            // categoryCb
            // 
            this.categoryCb.DataSource = this.dataSetBindingSource1;
            this.categoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Location = new System.Drawing.Point(181, 190);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(204, 35);
            this.categoryCb.TabIndex = 15;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource.Position = 0;
            // 
            // dataSetBindingSource1
            // 
            this.dataSetBindingSource1.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource1.Position = 0;
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.logoutB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.voteB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vote";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button voteB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutB;
        private System.Windows.Forms.ComboBox categoryCb;
        private System.Windows.Forms.BindingSource dataSetBindingSource1;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
    }
}