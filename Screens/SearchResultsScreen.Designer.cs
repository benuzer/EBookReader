namespace EBookReader
{
    partial class SearchResultsScreen
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
            this.flpSearchResults = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpSearchResults
            // 
            this.flpSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSearchResults.Location = new System.Drawing.Point(0, 0);
            this.flpSearchResults.Name = "flpSearchResults";
            this.flpSearchResults.Size = new System.Drawing.Size(800, 450);
            this.flpSearchResults.TabIndex = 0;
            // 
            // SearchResultsForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpSearchResults);
            this.Name = "SearchResultsForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FlowLayoutPanel flpSearchResults;

    }

        #endregion
    }
