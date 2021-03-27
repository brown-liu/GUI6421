
namespace Kaioordinate_BoLiu
{
    partial class LocationManagementForm
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
            this.locationReturnBtn = new FontAwesome.Sharp.IconButton();
            this.locationDeleteBtn = new FontAwesome.Sharp.IconButton();
            this.locationUpdateBtn = new FontAwesome.Sharp.IconButton();
            this.locationAddBtn = new FontAwesome.Sharp.IconButton();
            this.locationDownBtn = new FontAwesome.Sharp.IconButton();
            this.locationUpBtn = new FontAwesome.Sharp.IconButton();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.locationAddress = new System.Windows.Forms.TextBox();
            this.displaylocationId = new System.Windows.Forms.TextBox();
            this.locationName = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelWID = new System.Windows.Forms.Label();
            this.panelAddLocation = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addPanelAddress = new System.Windows.Forms.TextBox();
            this.addPanelLocationName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addLocationCancelBtn = new FontAwesome.Sharp.IconButton();
            this.panelSaveLocationBtn = new FontAwesome.Sharp.IconButton();
            this.updateLocationBtn = new FontAwesome.Sharp.IconButton();
            this.panelAddLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // locationReturnBtn
            // 
            this.locationReturnBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.locationReturnBtn.IconColor = System.Drawing.Color.Black;
            this.locationReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locationReturnBtn.Location = new System.Drawing.Point(652, 357);
            this.locationReturnBtn.Name = "locationReturnBtn";
            this.locationReturnBtn.Size = new System.Drawing.Size(87, 78);
            this.locationReturnBtn.TabIndex = 84;
            this.locationReturnBtn.Text = "RETURN";
            this.locationReturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.locationReturnBtn.UseVisualStyleBackColor = true;
            this.locationReturnBtn.Click += new System.EventHandler(this.locationReturnBtn_Click);
            // 
            // locationDeleteBtn
            // 
            this.locationDeleteBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.locationDeleteBtn.IconColor = System.Drawing.Color.Black;
            this.locationDeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locationDeleteBtn.Location = new System.Drawing.Point(525, 357);
            this.locationDeleteBtn.Name = "locationDeleteBtn";
            this.locationDeleteBtn.Size = new System.Drawing.Size(87, 78);
            this.locationDeleteBtn.TabIndex = 83;
            this.locationDeleteBtn.Text = "DELETE";
            this.locationDeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.locationDeleteBtn.UseVisualStyleBackColor = true;
            this.locationDeleteBtn.Click += new System.EventHandler(this.locationDeleteBtn_Click);
            // 
            // locationUpdateBtn
            // 
            this.locationUpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.locationUpdateBtn.IconColor = System.Drawing.Color.Black;
            this.locationUpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locationUpdateBtn.Location = new System.Drawing.Point(430, 357);
            this.locationUpdateBtn.Name = "locationUpdateBtn";
            this.locationUpdateBtn.Size = new System.Drawing.Size(87, 78);
            this.locationUpdateBtn.TabIndex = 82;
            this.locationUpdateBtn.Text = "UPDATE";
            this.locationUpdateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.locationUpdateBtn.UseVisualStyleBackColor = true;
            this.locationUpdateBtn.Click += new System.EventHandler(this.locationUpdateBtn_Click);
            // 
            // locationAddBtn
            // 
            this.locationAddBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.locationAddBtn.IconColor = System.Drawing.Color.Black;
            this.locationAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locationAddBtn.Location = new System.Drawing.Point(337, 357);
            this.locationAddBtn.Name = "locationAddBtn";
            this.locationAddBtn.Size = new System.Drawing.Size(87, 78);
            this.locationAddBtn.TabIndex = 81;
            this.locationAddBtn.Text = "ADD";
            this.locationAddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.locationAddBtn.UseVisualStyleBackColor = true;
            this.locationAddBtn.Click += new System.EventHandler(this.locationAddBtn_Click);
            // 
            // locationDownBtn
            // 
            this.locationDownBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.locationDownBtn.IconColor = System.Drawing.Color.Black;
            this.locationDownBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locationDownBtn.Location = new System.Drawing.Point(201, 357);
            this.locationDownBtn.Name = "locationDownBtn";
            this.locationDownBtn.Size = new System.Drawing.Size(87, 78);
            this.locationDownBtn.TabIndex = 80;
            this.locationDownBtn.Text = "DOWN";
            this.locationDownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.locationDownBtn.UseVisualStyleBackColor = true;
            this.locationDownBtn.Click += new System.EventHandler(this.locationDownBtn_Click);
            // 
            // locationUpBtn
            // 
            this.locationUpBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.locationUpBtn.IconColor = System.Drawing.Color.Black;
            this.locationUpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locationUpBtn.Location = new System.Drawing.Point(108, 357);
            this.locationUpBtn.Name = "locationUpBtn";
            this.locationUpBtn.Size = new System.Drawing.Size(87, 78);
            this.locationUpBtn.TabIndex = 79;
            this.locationUpBtn.Text = "UP";
            this.locationUpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.locationUpBtn.UseVisualStyleBackColor = true;
            this.locationUpBtn.Click += new System.EventHandler(this.locationUpBtn_Click);
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(62, 21);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(226, 303);
            this.locationListBox.TabIndex = 70;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddress.Location = new System.Drawing.Point(344, 155);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(80, 24);
            this.labelAddress.TabIndex = 86;
            this.labelAddress.Text = "Address";
            // 
            // locationAddress
            // 
            this.locationAddress.Location = new System.Drawing.Point(467, 160);
            this.locationAddress.Multiline = true;
            this.locationAddress.Name = "locationAddress";
            this.locationAddress.ReadOnly = true;
            this.locationAddress.Size = new System.Drawing.Size(232, 120);
            this.locationAddress.TabIndex = 85;
            // 
            // displaylocationId
            // 
            this.displaylocationId.Location = new System.Drawing.Point(469, 36);
            this.displaylocationId.Name = "displaylocationId";
            this.displaylocationId.ReadOnly = true;
            this.displaylocationId.Size = new System.Drawing.Size(228, 20);
            this.displaylocationId.TabIndex = 74;
            // 
            // locationName
            // 
            this.locationName.Location = new System.Drawing.Point(468, 94);
            this.locationName.Name = "locationName";
            this.locationName.ReadOnly = true;
            this.locationName.Size = new System.Drawing.Size(228, 20);
            this.locationName.TabIndex = 73;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelFName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFName.Location = new System.Drawing.Point(294, 94);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(137, 24);
            this.labelFName.TabIndex = 72;
            this.labelFName.Text = "Location Name";
            // 
            // labelWID
            // 
            this.labelWID.AutoSize = true;
            this.labelWID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelWID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWID.Location = new System.Drawing.Point(327, 36);
            this.labelWID.Name = "labelWID";
            this.labelWID.Size = new System.Drawing.Size(103, 24);
            this.labelWID.TabIndex = 71;
            this.labelWID.Text = "Location ID";
            // 
            // panelAddLocation
            // 
            this.panelAddLocation.Controls.Add(this.updateLocationBtn);
            this.panelAddLocation.Controls.Add(this.panelSaveLocationBtn);
            this.panelAddLocation.Controls.Add(this.addLocationCancelBtn);
            this.panelAddLocation.Controls.Add(this.label1);
            this.panelAddLocation.Controls.Add(this.addPanelAddress);
            this.panelAddLocation.Controls.Add(this.addPanelLocationName);
            this.panelAddLocation.Controls.Add(this.label2);
            this.panelAddLocation.Location = new System.Drawing.Point(298, 11);
            this.panelAddLocation.Name = "panelAddLocation";
            this.panelAddLocation.Size = new System.Drawing.Size(433, 327);
            this.panelAddLocation.TabIndex = 87;
            this.panelAddLocation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "Address";
            // 
            // addPanelAddress
            // 
            this.addPanelAddress.Location = new System.Drawing.Point(187, 107);
            this.addPanelAddress.Multiline = true;
            this.addPanelAddress.Name = "addPanelAddress";
            this.addPanelAddress.Size = new System.Drawing.Size(232, 120);
            this.addPanelAddress.TabIndex = 89;
            // 
            // addPanelLocationName
            // 
            this.addPanelLocationName.Location = new System.Drawing.Point(188, 43);
            this.addPanelLocationName.Name = "addPanelLocationName";
            this.addPanelLocationName.Size = new System.Drawing.Size(228, 20);
            this.addPanelLocationName.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "Location Name";
            // 
            // addLocationCancelBtn
            // 
            this.addLocationCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Cross;
            this.addLocationCancelBtn.IconColor = System.Drawing.Color.Black;
            this.addLocationCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addLocationCancelBtn.IconSize = 26;
            this.addLocationCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLocationCancelBtn.Location = new System.Drawing.Point(293, 275);
            this.addLocationCancelBtn.Name = "addLocationCancelBtn";
            this.addLocationCancelBtn.Size = new System.Drawing.Size(93, 35);
            this.addLocationCancelBtn.TabIndex = 88;
            this.addLocationCancelBtn.Text = "CANCEL";
            this.addLocationCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addLocationCancelBtn.UseVisualStyleBackColor = true;
            this.addLocationCancelBtn.Click += new System.EventHandler(this.addLocationCancelBtn_Click);
            // 
            // panelSaveLocationBtn
            // 
            this.panelSaveLocationBtn.IconChar = FontAwesome.Sharp.IconChar.Cross;
            this.panelSaveLocationBtn.IconColor = System.Drawing.Color.Black;
            this.panelSaveLocationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelSaveLocationBtn.IconSize = 26;
            this.panelSaveLocationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelSaveLocationBtn.Location = new System.Drawing.Point(167, 275);
            this.panelSaveLocationBtn.Name = "panelSaveLocationBtn";
            this.panelSaveLocationBtn.Size = new System.Drawing.Size(93, 35);
            this.panelSaveLocationBtn.TabIndex = 91;
            this.panelSaveLocationBtn.TabStop = false;
            this.panelSaveLocationBtn.Text = "Save";
            this.panelSaveLocationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.panelSaveLocationBtn.UseVisualStyleBackColor = true;
            this.panelSaveLocationBtn.Click += new System.EventHandler(this.panelSaveLocationBtn_Click);
            // 
            // updateLocationBtn
            // 
            this.updateLocationBtn.IconChar = FontAwesome.Sharp.IconChar.Cross;
            this.updateLocationBtn.IconColor = System.Drawing.Color.Black;
            this.updateLocationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateLocationBtn.IconSize = 26;
            this.updateLocationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateLocationBtn.Location = new System.Drawing.Point(131, 275);
            this.updateLocationBtn.Name = "updateLocationBtn";
            this.updateLocationBtn.Size = new System.Drawing.Size(93, 35);
            this.updateLocationBtn.TabIndex = 92;
            this.updateLocationBtn.TabStop = false;
            this.updateLocationBtn.Text = "Update";
            this.updateLocationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateLocationBtn.UseVisualStyleBackColor = true;
            this.updateLocationBtn.Click += new System.EventHandler(this.updateLocationBtn_Click);
            // 
            // LocationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(785, 493);
            this.Controls.Add(this.panelAddLocation);
            this.Controls.Add(this.locationReturnBtn);
            this.Controls.Add(this.locationDeleteBtn);
            this.Controls.Add(this.locationUpdateBtn);
            this.Controls.Add(this.locationAddBtn);
            this.Controls.Add(this.locationDownBtn);
            this.Controls.Add(this.locationUpBtn);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.locationAddress);
            this.Controls.Add(this.displaylocationId);
            this.Controls.Add(this.locationName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelWID);
            this.Name = "LocationManagementForm";
            this.Text = "Location Management Form";
            this.panelAddLocation.ResumeLayout(false);
            this.panelAddLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton locationReturnBtn;
        private FontAwesome.Sharp.IconButton locationDeleteBtn;
        private FontAwesome.Sharp.IconButton locationUpdateBtn;
        private FontAwesome.Sharp.IconButton locationAddBtn;
        private FontAwesome.Sharp.IconButton locationDownBtn;
        private FontAwesome.Sharp.IconButton locationUpBtn;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox locationAddress;
        private System.Windows.Forms.TextBox displaylocationId;
        private System.Windows.Forms.TextBox locationName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelWID;
        private System.Windows.Forms.Panel panelAddLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addPanelAddress;
        private System.Windows.Forms.TextBox addPanelLocationName;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton panelSaveLocationBtn;
        private FontAwesome.Sharp.IconButton addLocationCancelBtn;
        private FontAwesome.Sharp.IconButton updateLocationBtn;
    }
}