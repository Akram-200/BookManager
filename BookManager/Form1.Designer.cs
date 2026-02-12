namespace DigitalBookViewer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.btnGoToPage = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPageContent = new System.Windows.Forms.RichTextBox();
            this.lblTotalPages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(12, 12);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(260, 20);
            this.txtBookName.TabIndex = 0;
            this.txtBookName.Text = "Entrer le chemin du dossier ici";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(278, 10);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Télécharger";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(12, 50);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPageNumber.TabIndex = 2;
            this.txtPageNumber.Text = "Numéro de page";
            // 
            // btnGoToPage
            // 
            this.btnGoToPage.Location = new System.Drawing.Point(118, 48);
            this.btnGoToPage.Name = "btnGoToPage";
            this.btnGoToPage.Size = new System.Drawing.Size(75, 23);
            this.btnGoToPage.TabIndex = 3;
            this.btnGoToPage.Text = "OK";
            this.btnGoToPage.UseVisualStyleBackColor = true;
            this.btnGoToPage.Click += new System.EventHandler(this.btnGoToPage_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 90);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Précédent";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(93, 90);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPageContent
            // 
            this.txtPageContent.Location = new System.Drawing.Point(12, 130);
            this.txtPageContent.Name = "txtPageContent";
            this.txtPageContent.Size = new System.Drawing.Size(341, 200);
            this.txtPageContent.TabIndex = 6;
            this.txtPageContent.Text = "";
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.AutoSize = true;
            this.lblTotalPages.Location = new System.Drawing.Point(12, 340);
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(54, 13);
            this.lblTotalPages.TabIndex = 7;
            this.lblTotalPages.Text = "Pages : 0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(365, 362);
            this.Controls.Add(this.lblTotalPages);
            this.Controls.Add(this.txtPageContent);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnGoToPage);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtBookName);
            this.Name = "Form1";
            this.Text = "Visualiseur de Livre Numérique";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnGoToPage;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RichTextBox txtPageContent;
        private System.Windows.Forms.Label lblTotalPages;
    }
}
