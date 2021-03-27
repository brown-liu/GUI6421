
namespace Kaioordinate_BoLiu
{
    partial class KaiMaintenanceForm
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
            this.kaiMaintinanceListBox = new System.Windows.Forms.ListBox();
            this.labelKaiId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventDisplay = new System.Windows.Forms.TextBox();
            this.kaiNameDisplay = new System.Windows.Forms.TextBox();
            this.kaiIDdislay = new System.Windows.Forms.TextBox();
            this.preparationDisplay = new System.Windows.Forms.TextBox();
            this.preparationTimeDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serveQuantityDisplay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kaiUpBtn = new FontAwesome.Sharp.IconButton();
            this.kaiDownBtn = new FontAwesome.Sharp.IconButton();
            this.kaiAddBtn = new FontAwesome.Sharp.IconButton();
            this.kaiUpdateBtn = new FontAwesome.Sharp.IconButton();
            this.kaiDeleteBtn = new FontAwesome.Sharp.IconButton();
            this.kaiReturnBtn = new FontAwesome.Sharp.IconButton();
            this.addKaiSaveBtn = new FontAwesome.Sharp.IconButton();
            this.addKaiCancelBtn = new FontAwesome.Sharp.IconButton();
            this.addKaiPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kaiAddCheckBox = new System.Windows.Forms.CheckBox();
            this.addPanelServingQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addPanelPreparationTime = new System.Windows.Forms.TextBox();
            this.addPanelEventName = new System.Windows.Forms.TextBox();
            this.addFormKaiName = new System.Windows.Forms.TextBox();
            this.updateKaiBtn = new FontAwesome.Sharp.IconButton();
            this.addKaiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaiMaintinanceListBox
            // 
            this.kaiMaintinanceListBox.FormattingEnabled = true;
            this.kaiMaintinanceListBox.Location = new System.Drawing.Point(39, 45);
            this.kaiMaintinanceListBox.Name = "kaiMaintinanceListBox";
            this.kaiMaintinanceListBox.Size = new System.Drawing.Size(193, 264);
            this.kaiMaintinanceListBox.TabIndex = 0;
            this.kaiMaintinanceListBox.SelectedIndexChanged += new System.EventHandler(this.kaiMaintinanceListBox_SelectedIndexChanged);
            // 
            // labelKaiId
            // 
            this.labelKaiId.AutoSize = true;
            this.labelKaiId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelKaiId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKaiId.Location = new System.Drawing.Point(357, 52);
            this.labelKaiId.Name = "labelKaiId";
            this.labelKaiId.Size = new System.Drawing.Size(58, 24);
            this.labelKaiId.TabIndex = 1;
            this.labelKaiId.Text = "Kai ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(357, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(327, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kai Name";
            // 
            // eventDisplay
            // 
            this.eventDisplay.Location = new System.Drawing.Point(456, 97);
            this.eventDisplay.Name = "eventDisplay";
            this.eventDisplay.ReadOnly = true;
            this.eventDisplay.Size = new System.Drawing.Size(148, 20);
            this.eventDisplay.TabIndex = 5;
            // 
            // kaiNameDisplay
            // 
            this.kaiNameDisplay.Location = new System.Drawing.Point(456, 143);
            this.kaiNameDisplay.Name = "kaiNameDisplay";
            this.kaiNameDisplay.ReadOnly = true;
            this.kaiNameDisplay.Size = new System.Drawing.Size(148, 20);
            this.kaiNameDisplay.TabIndex = 6;
            // 
            // kaiIDdislay
            // 
            this.kaiIDdislay.Location = new System.Drawing.Point(456, 52);
            this.kaiIDdislay.Name = "kaiIDdislay";
            this.kaiIDdislay.ReadOnly = true;
            this.kaiIDdislay.Size = new System.Drawing.Size(148, 20);
            this.kaiIDdislay.TabIndex = 7;
            // 
            // preparationDisplay
            // 
            this.preparationDisplay.Location = new System.Drawing.Point(456, 192);
            this.preparationDisplay.Name = "preparationDisplay";
            this.preparationDisplay.ReadOnly = true;
            this.preparationDisplay.Size = new System.Drawing.Size(148, 20);
            this.preparationDisplay.TabIndex = 8;
            // 
            // preparationTimeDisplay
            // 
            this.preparationTimeDisplay.Location = new System.Drawing.Point(456, 242);
            this.preparationTimeDisplay.Name = "preparationTimeDisplay";
            this.preparationTimeDisplay.ReadOnly = true;
            this.preparationTimeDisplay.Size = new System.Drawing.Size(148, 20);
            this.preparationTimeDisplay.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(313, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prepration?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(265, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preparation Time";
            // 
            // serveQuantityDisplay
            // 
            this.serveQuantityDisplay.Location = new System.Drawing.Point(456, 289);
            this.serveQuantityDisplay.Name = "serveQuantityDisplay";
            this.serveQuantityDisplay.ReadOnly = true;
            this.serveQuantityDisplay.Size = new System.Drawing.Size(148, 20);
            this.serveQuantityDisplay.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(272, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Serving Quantity";
            // 
            // kaiUpBtn
            // 
            this.kaiUpBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.kaiUpBtn.IconColor = System.Drawing.Color.Black;
            this.kaiUpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiUpBtn.Location = new System.Drawing.Point(40, 399);
            this.kaiUpBtn.Name = "kaiUpBtn";
            this.kaiUpBtn.Size = new System.Drawing.Size(87, 78);
            this.kaiUpBtn.TabIndex = 14;
            this.kaiUpBtn.Text = "UP";
            this.kaiUpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiUpBtn.UseVisualStyleBackColor = true;
            this.kaiUpBtn.Click += new System.EventHandler(this.kaiUpBtn_Click);
            // 
            // kaiDownBtn
            // 
            this.kaiDownBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.kaiDownBtn.IconColor = System.Drawing.Color.Black;
            this.kaiDownBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiDownBtn.Location = new System.Drawing.Point(133, 399);
            this.kaiDownBtn.Name = "kaiDownBtn";
            this.kaiDownBtn.Size = new System.Drawing.Size(87, 78);
            this.kaiDownBtn.TabIndex = 15;
            this.kaiDownBtn.Text = "DOWN";
            this.kaiDownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiDownBtn.UseVisualStyleBackColor = true;
            this.kaiDownBtn.Click += new System.EventHandler(this.kaiDownBtn_Click);
            // 
            // kaiAddBtn
            // 
            this.kaiAddBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.kaiAddBtn.IconColor = System.Drawing.Color.Black;
            this.kaiAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiAddBtn.Location = new System.Drawing.Point(269, 399);
            this.kaiAddBtn.Name = "kaiAddBtn";
            this.kaiAddBtn.Size = new System.Drawing.Size(87, 78);
            this.kaiAddBtn.TabIndex = 16;
            this.kaiAddBtn.Text = "ADD";
            this.kaiAddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiAddBtn.UseVisualStyleBackColor = true;
            this.kaiAddBtn.Click += new System.EventHandler(this.kaiAddBtn_Click);
            // 
            // kaiUpdateBtn
            // 
            this.kaiUpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.kaiUpdateBtn.IconColor = System.Drawing.Color.Black;
            this.kaiUpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiUpdateBtn.Location = new System.Drawing.Point(362, 399);
            this.kaiUpdateBtn.Name = "kaiUpdateBtn";
            this.kaiUpdateBtn.Size = new System.Drawing.Size(87, 78);
            this.kaiUpdateBtn.TabIndex = 17;
            this.kaiUpdateBtn.Text = "UPDATE";
            this.kaiUpdateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiUpdateBtn.UseVisualStyleBackColor = true;
            this.kaiUpdateBtn.Click += new System.EventHandler(this.kaiUpdateBtn_Click);
            // 
            // kaiDeleteBtn
            // 
            this.kaiDeleteBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.kaiDeleteBtn.IconColor = System.Drawing.Color.Black;
            this.kaiDeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiDeleteBtn.Location = new System.Drawing.Point(457, 399);
            this.kaiDeleteBtn.Name = "kaiDeleteBtn";
            this.kaiDeleteBtn.Size = new System.Drawing.Size(87, 78);
            this.kaiDeleteBtn.TabIndex = 18;
            this.kaiDeleteBtn.Text = "DELETE";
            this.kaiDeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiDeleteBtn.UseVisualStyleBackColor = true;
            this.kaiDeleteBtn.Click += new System.EventHandler(this.kaiDeleteBtn_Click);
            // 
            // kaiReturnBtn
            // 
            this.kaiReturnBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.kaiReturnBtn.IconColor = System.Drawing.Color.Black;
            this.kaiReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiReturnBtn.Location = new System.Drawing.Point(584, 399);
            this.kaiReturnBtn.Name = "kaiReturnBtn";
            this.kaiReturnBtn.Size = new System.Drawing.Size(87, 78);
            this.kaiReturnBtn.TabIndex = 19;
            this.kaiReturnBtn.Text = "RETURN";
            this.kaiReturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiReturnBtn.UseVisualStyleBackColor = true;
            this.kaiReturnBtn.Click += new System.EventHandler(this.kaiReturnBtn_Click);
            // 
            // addKaiSaveBtn
            // 
            this.addKaiSaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.addKaiSaveBtn.IconColor = System.Drawing.Color.Black;
            this.addKaiSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addKaiSaveBtn.IconSize = 25;
            this.addKaiSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addKaiSaveBtn.Location = new System.Drawing.Point(432, 337);
            this.addKaiSaveBtn.Name = "addKaiSaveBtn";
            this.addKaiSaveBtn.Size = new System.Drawing.Size(92, 35);
            this.addKaiSaveBtn.TabIndex = 20;
            this.addKaiSaveBtn.Text = "SAVE";
            this.addKaiSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addKaiSaveBtn.UseVisualStyleBackColor = true;
            this.addKaiSaveBtn.Visible = false;
            this.addKaiSaveBtn.Click += new System.EventHandler(this.addKaiSaveBtn_Click);
            // 
            // addKaiCancelBtn
            // 
            this.addKaiCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Cross;
            this.addKaiCancelBtn.IconColor = System.Drawing.Color.Black;
            this.addKaiCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addKaiCancelBtn.IconSize = 26;
            this.addKaiCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addKaiCancelBtn.Location = new System.Drawing.Point(559, 337);
            this.addKaiCancelBtn.Name = "addKaiCancelBtn";
            this.addKaiCancelBtn.Size = new System.Drawing.Size(93, 35);
            this.addKaiCancelBtn.TabIndex = 21;
            this.addKaiCancelBtn.Text = "CANCEL";
            this.addKaiCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addKaiCancelBtn.UseVisualStyleBackColor = true;
            this.addKaiCancelBtn.Visible = false;
            this.addKaiCancelBtn.Click += new System.EventHandler(this.addKaiCancelBtn_Click);
            // 
            // addKaiPanel
            // 
            this.addKaiPanel.Controls.Add(this.label1);
            this.addKaiPanel.Controls.Add(this.kaiAddCheckBox);
            this.addKaiPanel.Controls.Add(this.addPanelServingQuantity);
            this.addKaiPanel.Controls.Add(this.label8);
            this.addKaiPanel.Controls.Add(this.label7);
            this.addKaiPanel.Controls.Add(this.label10);
            this.addKaiPanel.Controls.Add(this.label9);
            this.addKaiPanel.Controls.Add(this.addPanelPreparationTime);
            this.addKaiPanel.Controls.Add(this.addPanelEventName);
            this.addKaiPanel.Controls.Add(this.addFormKaiName);
            this.addKaiPanel.Location = new System.Drawing.Point(266, 36);
            this.addKaiPanel.Name = "addKaiPanel";
            this.addKaiPanel.Size = new System.Drawing.Size(376, 295);
            this.addKaiPanel.TabIndex = 22;
            this.addKaiPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Serving Quantity";
            // 
            // kaiAddCheckBox
            // 
            this.kaiAddCheckBox.AutoSize = true;
            this.kaiAddCheckBox.Location = new System.Drawing.Point(211, 135);
            this.kaiAddCheckBox.Name = "kaiAddCheckBox";
            this.kaiAddCheckBox.Size = new System.Drawing.Size(15, 14);
            this.kaiAddCheckBox.TabIndex = 23;
            this.kaiAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // addPanelServingQuantity
            // 
            this.addPanelServingQuantity.Location = new System.Drawing.Point(211, 227);
            this.addPanelServingQuantity.Name = "addPanelServingQuantity";
            this.addPanelServingQuantity.Size = new System.Drawing.Size(148, 20);
            this.addPanelServingQuantity.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(68, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Prepration?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(20, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Preparation Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(112, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Event";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(82, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kai Name";
            // 
            // addPanelPreparationTime
            // 
            this.addPanelPreparationTime.Location = new System.Drawing.Point(211, 180);
            this.addPanelPreparationTime.Name = "addPanelPreparationTime";
            this.addPanelPreparationTime.Size = new System.Drawing.Size(148, 20);
            this.addPanelPreparationTime.TabIndex = 28;
            // 
            // addPanelEventName
            // 
            this.addPanelEventName.Location = new System.Drawing.Point(211, 35);
            this.addPanelEventName.Name = "addPanelEventName";
            this.addPanelEventName.Size = new System.Drawing.Size(148, 20);
            this.addPanelEventName.TabIndex = 25;
            // 
            // addFormKaiName
            // 
            this.addFormKaiName.Location = new System.Drawing.Point(211, 81);
            this.addFormKaiName.Name = "addFormKaiName";
            this.addFormKaiName.Size = new System.Drawing.Size(148, 20);
            this.addFormKaiName.TabIndex = 26;
            // 
            // updateKaiBtn
            // 
            this.updateKaiBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.updateKaiBtn.IconColor = System.Drawing.Color.Black;
            this.updateKaiBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateKaiBtn.IconSize = 25;
            this.updateKaiBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateKaiBtn.Location = new System.Drawing.Point(417, 337);
            this.updateKaiBtn.Name = "updateKaiBtn";
            this.updateKaiBtn.Size = new System.Drawing.Size(92, 35);
            this.updateKaiBtn.TabIndex = 23;
            this.updateKaiBtn.Text = "Update";
            this.updateKaiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateKaiBtn.UseVisualStyleBackColor = true;
            this.updateKaiBtn.Visible = false;
            this.updateKaiBtn.Click += new System.EventHandler(this.updateKaiBtn_Click);
            // 
            // KaiMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(728, 523);
            this.Controls.Add(this.updateKaiBtn);
            this.Controls.Add(this.addKaiPanel);
            this.Controls.Add(this.addKaiCancelBtn);
            this.Controls.Add(this.addKaiSaveBtn);
            this.Controls.Add(this.kaiReturnBtn);
            this.Controls.Add(this.kaiDeleteBtn);
            this.Controls.Add(this.kaiUpdateBtn);
            this.Controls.Add(this.kaiAddBtn);
            this.Controls.Add(this.kaiDownBtn);
            this.Controls.Add(this.kaiUpBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serveQuantityDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.preparationTimeDisplay);
            this.Controls.Add(this.preparationDisplay);
            this.Controls.Add(this.kaiIDdislay);
            this.Controls.Add(this.kaiNameDisplay);
            this.Controls.Add(this.eventDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKaiId);
            this.Controls.Add(this.kaiMaintinanceListBox);
            this.Name = "KaiMaintenanceForm";
            this.Text = "Kai Maintenance";
            this.addKaiPanel.ResumeLayout(false);
            this.addKaiPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kaiMaintinanceListBox;
        private System.Windows.Forms.Label labelKaiId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventDisplay;
        private System.Windows.Forms.TextBox kaiNameDisplay;
        private System.Windows.Forms.TextBox kaiIDdislay;
        private System.Windows.Forms.TextBox preparationDisplay;
        private System.Windows.Forms.TextBox preparationTimeDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox serveQuantityDisplay;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton kaiUpBtn;
        private FontAwesome.Sharp.IconButton kaiDownBtn;
        private FontAwesome.Sharp.IconButton kaiAddBtn;
        private FontAwesome.Sharp.IconButton kaiUpdateBtn;
        private FontAwesome.Sharp.IconButton kaiDeleteBtn;
        private FontAwesome.Sharp.IconButton kaiReturnBtn;
        private FontAwesome.Sharp.IconButton addKaiSaveBtn;
        private FontAwesome.Sharp.IconButton addKaiCancelBtn;
        private System.Windows.Forms.Panel addKaiPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox kaiAddCheckBox;
        private System.Windows.Forms.TextBox addPanelServingQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addPanelPreparationTime;
        private System.Windows.Forms.TextBox addPanelEventName;
        private System.Windows.Forms.TextBox addFormKaiName;
        private FontAwesome.Sharp.IconButton updateKaiBtn;
    }
}