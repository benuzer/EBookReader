using System.Windows.Forms;

namespace EBookReader
{
    partial class UserScreen
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flpStory = new System.Windows.Forms.FlowLayoutPanel();
            this.flpNovel = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCartoon = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTale = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(278, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flpStory
            // 
            this.flpStory.Location = new System.Drawing.Point(12, 50);
            this.flpStory.Name = "flpStory";
            this.flpStory.Size = new System.Drawing.Size(360, 100);
            this.flpStory.TabIndex = 2;
            this.flpStory.BorderStyle = BorderStyle.FixedSingle;
            this.flpStory.AutoScroll = true;
            // 
            // flpNovel
            // 
            this.flpNovel.Location = new System.Drawing.Point(12, 160);
            this.flpNovel.Name = "flpNovel";
            this.flpNovel.Size = new System.Drawing.Size(360, 100);
            this.flpNovel.TabIndex = 3;
            this.flpNovel.BorderStyle = BorderStyle.FixedSingle;
            this.flpNovel.AutoScroll = true;
            // 
            // flpCartoon
            // 
            this.flpCartoon.Location = new System.Drawing.Point(12, 270);
            this.flpCartoon.Name = "flpCartoon";
            this.flpCartoon.Size = new System.Drawing.Size(360, 100);
            this.flpCartoon.TabIndex = 4;
            this.flpCartoon.BorderStyle = BorderStyle.FixedSingle;
            this.flpCartoon.AutoScroll = true;
            // 
            // flpTale
            // 
            this.flpTale.Location = new System.Drawing.Point(12, 380);
            this.flpTale.Name = "flpTale";
            this.flpTale.Size = new System.Drawing.Size(360, 100);
            this.flpTale.TabIndex = 5;
            this.flpTale.BorderStyle = BorderStyle.FixedSingle;
            this.flpTale.AutoScroll = true;
            // 
            // UserScreen
            // 
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.flpTale);
            this.Controls.Add(this.flpCartoon);
            this.Controls.Add(this.flpNovel);
            this.Controls.Add(this.flpStory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "UserScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flpStory;
        private System.Windows.Forms.FlowLayoutPanel flpNovel;
        private System.Windows.Forms.FlowLayoutPanel flpCartoon;
        private System.Windows.Forms.FlowLayoutPanel flpTale;
    }
}