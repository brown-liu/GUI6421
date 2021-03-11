
namespace Kaioordinate_BoLiu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.kai = new FontAwesome.Sharp.IconButton();
            this.eventBtn = new FontAwesome.Sharp.IconButton();
            this.whanauBtn = new FontAwesome.Sharp.IconButton();
            this.locationBtn = new FontAwesome.Sharp.IconButton();
            this.registBtn = new FontAwesome.Sharp.IconButton();
            this.reportBtn = new FontAwesome.Sharp.IconButton();
            this.homeExistBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(65, 43);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(517, 116);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // kai
            // 
            this.kai.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.kai.IconColor = System.Drawing.Color.Black;
            this.kai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kai.IconSize = 60;
            this.kai.Location = new System.Drawing.Point(29, 200);
            this.kai.Name = "kai";
            this.kai.Size = new System.Drawing.Size(128, 117);
            this.kai.TabIndex = 16;
            this.kai.Text = "KAI";
            this.kai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kai.UseVisualStyleBackColor = true;
            this.kai.Click += new System.EventHandler(this.kai_Click);
            // 
            // eventBtn
            // 
            this.eventBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.eventBtn.IconColor = System.Drawing.Color.Black;
            this.eventBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventBtn.IconSize = 60;
            this.eventBtn.Location = new System.Drawing.Point(183, 200);
            this.eventBtn.Name = "eventBtn";
            this.eventBtn.Size = new System.Drawing.Size(128, 117);
            this.eventBtn.TabIndex = 17;
            this.eventBtn.Text = "Events";
            this.eventBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eventBtn.UseVisualStyleBackColor = true;
            this.eventBtn.Click += new System.EventHandler(this.eventBtn_Click);
            // 
            // whanauBtn
            // 
            this.whanauBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.whanauBtn.IconColor = System.Drawing.Color.Black;
            this.whanauBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.whanauBtn.IconSize = 60;
            this.whanauBtn.Location = new System.Drawing.Point(336, 200);
            this.whanauBtn.Name = "whanauBtn";
            this.whanauBtn.Size = new System.Drawing.Size(128, 117);
            this.whanauBtn.TabIndex = 18;
            this.whanauBtn.Text = "Whānau";
            this.whanauBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.whanauBtn.UseVisualStyleBackColor = true;
            this.whanauBtn.Click += new System.EventHandler(this.whanauBtn_Click);
            // 
            // locationBtn
            // 
            this.locationBtn.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.locationBtn.IconColor = System.Drawing.Color.Black;
            this.locationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locationBtn.IconSize = 60;
            this.locationBtn.Location = new System.Drawing.Point(491, 200);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(130, 117);
            this.locationBtn.TabIndex = 19;
            this.locationBtn.Text = "Locations";
            this.locationBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.locationBtn.UseVisualStyleBackColor = true;
            this.locationBtn.Click += new System.EventHandler(this.locationBtn_Click);
            // 
            // registBtn
            // 
            this.registBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.registBtn.IconColor = System.Drawing.Color.Black;
            this.registBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registBtn.IconSize = 60;
            this.registBtn.Location = new System.Drawing.Point(29, 342);
            this.registBtn.Name = "registBtn";
            this.registBtn.Size = new System.Drawing.Size(128, 117);
            this.registBtn.TabIndex = 20;
            this.registBtn.Text = "Registration";
            this.registBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registBtn.UseVisualStyleBackColor = true;
            this.registBtn.Click += new System.EventHandler(this.registBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.reportBtn.IconColor = System.Drawing.Color.Black;
            this.reportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportBtn.IconSize = 60;
            this.reportBtn.Location = new System.Drawing.Point(183, 342);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(128, 117);
            this.reportBtn.TabIndex = 21;
            this.reportBtn.Text = "Report";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // homeExistBtn
            // 
            this.homeExistBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.homeExistBtn.IconColor = System.Drawing.Color.Black;
            this.homeExistBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeExistBtn.IconSize = 60;
            this.homeExistBtn.Location = new System.Drawing.Point(491, 342);
            this.homeExistBtn.Name = "homeExistBtn";
            this.homeExistBtn.Size = new System.Drawing.Size(130, 117);
            this.homeExistBtn.TabIndex = 22;
            this.homeExistBtn.Text = "EXIT";
            this.homeExistBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeExistBtn.UseVisualStyleBackColor = true;
            this.homeExistBtn.Click += new System.EventHandler(this.homeExistBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(651, 486);
            this.Controls.Add(this.homeExistBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.registBtn);
            this.Controls.Add(this.locationBtn);
            this.Controls.Add(this.whanauBtn);
            this.Controls.Add(this.eventBtn);
            this.Controls.Add(this.kai);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kaiooradinate - Community event management software";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox;
        private FontAwesome.Sharp.IconButton kai;
        private FontAwesome.Sharp.IconButton eventBtn;
        private FontAwesome.Sharp.IconButton whanauBtn;
        private FontAwesome.Sharp.IconButton locationBtn;
        private FontAwesome.Sharp.IconButton registBtn;
        private FontAwesome.Sharp.IconButton reportBtn;
        private FontAwesome.Sharp.IconButton homeExistBtn;
    }
}

