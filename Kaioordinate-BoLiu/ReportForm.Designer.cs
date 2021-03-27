
namespace Kaioordinate_BoLiu
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.kaiDownBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.printDocumentPrintReport = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogPrintReport = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // kaiDownBtn
            // 
            this.kaiDownBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.kaiDownBtn.IconColor = System.Drawing.Color.Black;
            this.kaiDownBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiDownBtn.Location = new System.Drawing.Point(83, 58);
            this.kaiDownBtn.Name = "kaiDownBtn";
            this.kaiDownBtn.Size = new System.Drawing.Size(113, 100);
            this.kaiDownBtn.TabIndex = 17;
            this.kaiDownBtn.Text = "GENERATE REPORT";
            this.kaiDownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiDownBtn.UseVisualStyleBackColor = true;
            this.kaiDownBtn.Click += new System.EventHandler(this.kaiDownBtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(245, 58);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(113, 100);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.Text = "RETURN";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // printDocumentPrintReport
            // 
            this.printDocumentPrintReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentPrintReport_PrintPage);
            // 
            // printPreviewDialogPrintReport
            // 
            this.printPreviewDialogPrintReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPrintReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPrintReport.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogPrintReport.Document = this.printDocumentPrintReport;
            this.printPreviewDialogPrintReport.Enabled = true;
            this.printPreviewDialogPrintReport.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogPrintReport.Icon")));
            this.printPreviewDialogPrintReport.Name = "printPreviewDialogPrintReport";
            this.printPreviewDialogPrintReport.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(445, 228);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.kaiDownBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton kaiDownBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Drawing.Printing.PrintDocument printDocumentPrintReport;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogPrintReport;
    }
}