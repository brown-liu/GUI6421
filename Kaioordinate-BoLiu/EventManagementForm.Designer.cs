
namespace Kaioordinate_BoLiu
{
    partial class EventManagementForm
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
            this.addEventCancelBtn = new FontAwesome.Sharp.IconButton();
            this.panelAddEventSaveBtn = new FontAwesome.Sharp.IconButton();
            this.eventReturnBtn = new FontAwesome.Sharp.IconButton();
            this.eventDeleteBtn = new FontAwesome.Sharp.IconButton();
            this.eventUpdateBtn = new FontAwesome.Sharp.IconButton();
            this.eventAddBtn = new FontAwesome.Sharp.IconButton();
            this.eventDownBtn = new FontAwesome.Sharp.IconButton();
            this.eventUpBtn = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.displayEventDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.displayLocationName = new System.Windows.Forms.TextBox();
            this.displayEventId = new System.Windows.Forms.TextBox();
            this.eventDisplay = new System.Windows.Forms.TextBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventID = new System.Windows.Forms.Label();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.panelAddEvent = new System.Windows.Forms.Panel();
            this.panelUpdateEvent = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.eventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLocations = new System.Windows.Forms.ComboBox();
            this.panelAddEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEventCancelBtn
            // 
            this.addEventCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Cross;
            this.addEventCancelBtn.IconColor = System.Drawing.Color.Black;
            this.addEventCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addEventCancelBtn.IconSize = 26;
            this.addEventCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEventCancelBtn.Location = new System.Drawing.Point(194, 246);
            this.addEventCancelBtn.Name = "addEventCancelBtn";
            this.addEventCancelBtn.Size = new System.Drawing.Size(93, 35);
            this.addEventCancelBtn.TabIndex = 44;
            this.addEventCancelBtn.Text = "CANCEL";
            this.addEventCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addEventCancelBtn.UseVisualStyleBackColor = true;
            this.addEventCancelBtn.Click += new System.EventHandler(this.addEventCancelBtn_Click);
            // 
            // panelAddEventSaveBtn
            // 
            this.panelAddEventSaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.panelAddEventSaveBtn.IconColor = System.Drawing.Color.Black;
            this.panelAddEventSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelAddEventSaveBtn.IconSize = 25;
            this.panelAddEventSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelAddEventSaveBtn.Location = new System.Drawing.Point(67, 246);
            this.panelAddEventSaveBtn.Name = "panelAddEventSaveBtn";
            this.panelAddEventSaveBtn.Size = new System.Drawing.Size(92, 35);
            this.panelAddEventSaveBtn.TabIndex = 43;
            this.panelAddEventSaveBtn.Text = "SAVE";
            this.panelAddEventSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.panelAddEventSaveBtn.UseVisualStyleBackColor = true;
            this.panelAddEventSaveBtn.Click += new System.EventHandler(this.addEventSaveBtn_Click);
            // 
            // eventReturnBtn
            // 
            this.eventReturnBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.eventReturnBtn.IconColor = System.Drawing.Color.Black;
            this.eventReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventReturnBtn.Location = new System.Drawing.Point(629, 368);
            this.eventReturnBtn.Name = "eventReturnBtn";
            this.eventReturnBtn.Size = new System.Drawing.Size(87, 78);
            this.eventReturnBtn.TabIndex = 42;
            this.eventReturnBtn.Text = "RETURN";
            this.eventReturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eventReturnBtn.UseVisualStyleBackColor = true;
            this.eventReturnBtn.Click += new System.EventHandler(this.eventReturnBtn_Click);
            // 
            // eventDeleteBtn
            // 
            this.eventDeleteBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.eventDeleteBtn.IconColor = System.Drawing.Color.Black;
            this.eventDeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventDeleteBtn.Location = new System.Drawing.Point(502, 368);
            this.eventDeleteBtn.Name = "eventDeleteBtn";
            this.eventDeleteBtn.Size = new System.Drawing.Size(87, 78);
            this.eventDeleteBtn.TabIndex = 41;
            this.eventDeleteBtn.Text = "DELETE";
            this.eventDeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eventDeleteBtn.UseVisualStyleBackColor = true;
            this.eventDeleteBtn.Click += new System.EventHandler(this.eventDeleteBtn_Click);
            // 
            // eventUpdateBtn
            // 
            this.eventUpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.eventUpdateBtn.IconColor = System.Drawing.Color.Black;
            this.eventUpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventUpdateBtn.Location = new System.Drawing.Point(407, 368);
            this.eventUpdateBtn.Name = "eventUpdateBtn";
            this.eventUpdateBtn.Size = new System.Drawing.Size(87, 78);
            this.eventUpdateBtn.TabIndex = 40;
            this.eventUpdateBtn.Text = "UPDATE";
            this.eventUpdateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eventUpdateBtn.UseVisualStyleBackColor = true;
            this.eventUpdateBtn.Click += new System.EventHandler(this.eventUpdateBtn_Click);
            // 
            // eventAddBtn
            // 
            this.eventAddBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.eventAddBtn.IconColor = System.Drawing.Color.Black;
            this.eventAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventAddBtn.Location = new System.Drawing.Point(314, 368);
            this.eventAddBtn.Name = "eventAddBtn";
            this.eventAddBtn.Size = new System.Drawing.Size(87, 78);
            this.eventAddBtn.TabIndex = 39;
            this.eventAddBtn.Text = "ADD";
            this.eventAddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eventAddBtn.UseVisualStyleBackColor = true;
            this.eventAddBtn.Click += new System.EventHandler(this.eventAddBtn_Click);
            // 
            // eventDownBtn
            // 
            this.eventDownBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.eventDownBtn.IconColor = System.Drawing.Color.Black;
            this.eventDownBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventDownBtn.Location = new System.Drawing.Point(178, 368);
            this.eventDownBtn.Name = "eventDownBtn";
            this.eventDownBtn.Size = new System.Drawing.Size(87, 78);
            this.eventDownBtn.TabIndex = 38;
            this.eventDownBtn.Text = "DOWN";
            this.eventDownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eventDownBtn.UseVisualStyleBackColor = true;
            this.eventDownBtn.Click += new System.EventHandler(this.eventDownBtn_Click);
            // 
            // eventUpBtn
            // 
            this.eventUpBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.eventUpBtn.IconColor = System.Drawing.Color.Black;
            this.eventUpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventUpBtn.Location = new System.Drawing.Point(85, 368);
            this.eventUpBtn.Name = "eventUpBtn";
            this.eventUpBtn.Size = new System.Drawing.Size(87, 78);
            this.eventUpBtn.TabIndex = 37;
            this.eventUpBtn.Text = "UP";
            this.eventUpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eventUpBtn.UseVisualStyleBackColor = true;
            this.eventUpBtn.Click += new System.EventHandler(this.eventUpBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(381, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Event Date";
            // 
            // displayEventDate
            // 
            this.displayEventDate.Location = new System.Drawing.Point(507, 223);
            this.displayEventDate.Name = "displayEventDate";
            this.displayEventDate.ReadOnly = true;
            this.displayEventDate.Size = new System.Drawing.Size(148, 20);
            this.displayEventDate.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(403, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Location";
            // 
            // displayLocationName
            // 
            this.displayLocationName.Location = new System.Drawing.Point(507, 166);
            this.displayLocationName.Name = "displayLocationName";
            this.displayLocationName.ReadOnly = true;
            this.displayLocationName.Size = new System.Drawing.Size(148, 20);
            this.displayLocationName.TabIndex = 32;
            // 
            // displayEventId
            // 
            this.displayEventId.Location = new System.Drawing.Point(508, 42);
            this.displayEventId.Name = "displayEventId";
            this.displayEventId.ReadOnly = true;
            this.displayEventId.Size = new System.Drawing.Size(148, 20);
            this.displayEventId.TabIndex = 30;
            // 
            // eventDisplay
            // 
            this.eventDisplay.Location = new System.Drawing.Point(508, 102);
            this.eventDisplay.Name = "eventDisplay";
            this.eventDisplay.ReadOnly = true;
            this.eventDisplay.Size = new System.Drawing.Size(148, 20);
            this.eventDisplay.TabIndex = 28;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEventName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEventName.Location = new System.Drawing.Point(375, 102);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(114, 24);
            this.labelEventName.TabIndex = 26;
            this.labelEventName.Text = "Event Name";
            // 
            // labelEventID
            // 
            this.labelEventID.AutoSize = true;
            this.labelEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEventID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEventID.Location = new System.Drawing.Point(407, 42);
            this.labelEventID.Name = "labelEventID";
            this.labelEventID.Size = new System.Drawing.Size(80, 24);
            this.labelEventID.TabIndex = 25;
            this.labelEventID.Text = "Event ID";
            // 
            // eventListBox
            // 
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.Location = new System.Drawing.Point(84, 14);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(193, 264);
            this.eventListBox.TabIndex = 24;
            this.eventListBox.SelectedIndexChanged += new System.EventHandler(this.eventListBox_SelectedIndexChanged);
            // 
            // panelAddEvent
            // 
            this.panelAddEvent.Controls.Add(this.panelUpdateEvent);
            this.panelAddEvent.Controls.Add(this.label3);
            this.panelAddEvent.Controls.Add(this.addEventCancelBtn);
            this.panelAddEvent.Controls.Add(this.eventDatePicker);
            this.panelAddEvent.Controls.Add(this.panelAddEventSaveBtn);
            this.panelAddEvent.Controls.Add(this.label2);
            this.panelAddEvent.Controls.Add(this.comboBoxLocations);
            this.panelAddEvent.Controls.Add(this.panelAddEventName);
            this.panelAddEvent.Controls.Add(this.label1);
            this.panelAddEvent.Location = new System.Drawing.Point(354, 12);
            this.panelAddEvent.Name = "panelAddEvent";
            this.panelAddEvent.Size = new System.Drawing.Size(358, 299);
            this.panelAddEvent.TabIndex = 47;
            this.panelAddEvent.Visible = false;
            // 
            // panelUpdateEvent
            // 
            this.panelUpdateEvent.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.panelUpdateEvent.IconColor = System.Drawing.Color.Black;
            this.panelUpdateEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelUpdateEvent.IconSize = 25;
            this.panelUpdateEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelUpdateEvent.Location = new System.Drawing.Point(48, 246);
            this.panelUpdateEvent.Name = "panelUpdateEvent";
            this.panelUpdateEvent.Size = new System.Drawing.Size(92, 35);
            this.panelUpdateEvent.TabIndex = 45;
            this.panelUpdateEvent.Text = "Update";
            this.panelUpdateEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.panelUpdateEvent.UseVisualStyleBackColor = true;
            this.panelUpdateEvent.Click += new System.EventHandler(this.panelUpdateEvent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Event Date";
            // 
            // eventDatePicker
            // 
            this.eventDatePicker.Location = new System.Drawing.Point(135, 164);
            this.eventDatePicker.Name = "eventDatePicker";
            this.eventDatePicker.Size = new System.Drawing.Size(200, 20);
            this.eventDatePicker.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Location";
            // 
            // comboBoxLocations
            // 
            this.comboBoxLocations.FormattingEnabled = true;
            this.comboBoxLocations.Location = new System.Drawing.Point(135, 96);
            this.comboBoxLocations.Name = "comboBoxLocations";
            this.comboBoxLocations.Size = new System.Drawing.Size(148, 21);
            this.comboBoxLocations.TabIndex = 33;
            // 
            // panelAddEventName
            // 
            this.panelAddEventName.Location = new System.Drawing.Point(135, 24);
            this.panelAddEventName.Name = "panelAddEventName";
            this.panelAddEventName.Size = new System.Drawing.Size(148, 20);
            this.panelAddEventName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Event Name";
            // 
            // EventManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(790, 491);
            this.Controls.Add(this.panelAddEvent);
            this.Controls.Add(this.eventReturnBtn);
            this.Controls.Add(this.eventDeleteBtn);
            this.Controls.Add(this.eventUpdateBtn);
            this.Controls.Add(this.eventAddBtn);
            this.Controls.Add(this.eventDownBtn);
            this.Controls.Add(this.eventUpBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.displayEventDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.displayLocationName);
            this.Controls.Add(this.displayEventId);
            this.Controls.Add(this.eventDisplay);
            this.Controls.Add(this.labelEventName);
            this.Controls.Add(this.labelEventID);
            this.Controls.Add(this.eventListBox);
            this.Name = "EventManagementForm";
            this.Text = "Event Management Form";
            this.panelAddEvent.ResumeLayout(false);
            this.panelAddEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton addEventCancelBtn;
        private FontAwesome.Sharp.IconButton panelAddEventSaveBtn;
        private FontAwesome.Sharp.IconButton eventReturnBtn;
        private FontAwesome.Sharp.IconButton eventDeleteBtn;
        private FontAwesome.Sharp.IconButton eventUpdateBtn;
        private FontAwesome.Sharp.IconButton eventAddBtn;
        private FontAwesome.Sharp.IconButton eventDownBtn;
        private FontAwesome.Sharp.IconButton eventUpBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox displayEventDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox displayLocationName;
        private System.Windows.Forms.TextBox displayEventId;
        private System.Windows.Forms.TextBox eventDisplay;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelEventID;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.Panel panelAddEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLocations;
        private System.Windows.Forms.TextBox panelAddEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker eventDatePicker;
        private FontAwesome.Sharp.IconButton panelUpdateEvent;
    }
}