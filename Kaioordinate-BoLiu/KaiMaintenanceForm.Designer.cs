﻿
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
            this.kaiAddCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // kaiMaintinanceListBox
            // 
            this.kaiMaintinanceListBox.FormattingEnabled = true;
            this.kaiMaintinanceListBox.ItemHeight = 25;
            this.kaiMaintinanceListBox.Location = new System.Drawing.Point(78, 87);
            this.kaiMaintinanceListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiMaintinanceListBox.Name = "kaiMaintinanceListBox";
            this.kaiMaintinanceListBox.Size = new System.Drawing.Size(382, 504);
            this.kaiMaintinanceListBox.TabIndex = 0;
            this.kaiMaintinanceListBox.SelectedIndexChanged += new System.EventHandler(this.kaiMaintinanceListBox_SelectedIndexChanged);
            // 
            // labelKaiId
            // 
            this.labelKaiId.AutoSize = true;
            this.labelKaiId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelKaiId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKaiId.Location = new System.Drawing.Point(714, 100);
            this.labelKaiId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelKaiId.Name = "labelKaiId";
            this.labelKaiId.Size = new System.Drawing.Size(122, 44);
            this.labelKaiId.TabIndex = 1;
            this.labelKaiId.Text = "Kai ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(714, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(654, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kai Name";
            // 
            // eventDisplay
            // 
            this.eventDisplay.Location = new System.Drawing.Point(912, 187);
            this.eventDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventDisplay.Name = "eventDisplay";
            this.eventDisplay.ReadOnly = true;
            this.eventDisplay.Size = new System.Drawing.Size(292, 31);
            this.eventDisplay.TabIndex = 5;
            // 
            // kaiNameDisplay
            // 
            this.kaiNameDisplay.Location = new System.Drawing.Point(912, 275);
            this.kaiNameDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiNameDisplay.Name = "kaiNameDisplay";
            this.kaiNameDisplay.ReadOnly = true;
            this.kaiNameDisplay.Size = new System.Drawing.Size(292, 31);
            this.kaiNameDisplay.TabIndex = 6;
            // 
            // kaiIDdislay
            // 
            this.kaiIDdislay.Location = new System.Drawing.Point(912, 100);
            this.kaiIDdislay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiIDdislay.Name = "kaiIDdislay";
            this.kaiIDdislay.ReadOnly = true;
            this.kaiIDdislay.Size = new System.Drawing.Size(292, 31);
            this.kaiIDdislay.TabIndex = 7;
            // 
            // preparationDisplay
            // 
            this.preparationDisplay.Location = new System.Drawing.Point(912, 369);
            this.preparationDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.preparationDisplay.Name = "preparationDisplay";
            this.preparationDisplay.ReadOnly = true;
            this.preparationDisplay.Size = new System.Drawing.Size(292, 31);
            this.preparationDisplay.TabIndex = 8;
            // 
            // preparationTimeDisplay
            // 
            this.preparationTimeDisplay.Location = new System.Drawing.Point(912, 465);
            this.preparationTimeDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.preparationTimeDisplay.Name = "preparationTimeDisplay";
            this.preparationTimeDisplay.ReadOnly = true;
            this.preparationTimeDisplay.Size = new System.Drawing.Size(292, 31);
            this.preparationTimeDisplay.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(626, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prepration?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(530, 456);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 44);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preparation Time";
            // 
            // serveQuantityDisplay
            // 
            this.serveQuantityDisplay.Location = new System.Drawing.Point(912, 556);
            this.serveQuantityDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serveQuantityDisplay.Name = "serveQuantityDisplay";
            this.serveQuantityDisplay.ReadOnly = true;
            this.serveQuantityDisplay.Size = new System.Drawing.Size(292, 31);
            this.serveQuantityDisplay.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(544, 546);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 44);
            this.label6.TabIndex = 13;
            this.label6.Text = "Serving Quantity";
            // 
            // kaiUpBtn
            // 
            this.kaiUpBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.kaiUpBtn.IconColor = System.Drawing.Color.Black;
            this.kaiUpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiUpBtn.Location = new System.Drawing.Point(80, 767);
            this.kaiUpBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiUpBtn.Name = "kaiUpBtn";
            this.kaiUpBtn.Size = new System.Drawing.Size(174, 150);
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
            this.kaiDownBtn.Location = new System.Drawing.Point(266, 767);
            this.kaiDownBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiDownBtn.Name = "kaiDownBtn";
            this.kaiDownBtn.Size = new System.Drawing.Size(174, 150);
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
            this.kaiAddBtn.Location = new System.Drawing.Point(538, 767);
            this.kaiAddBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiAddBtn.Name = "kaiAddBtn";
            this.kaiAddBtn.Size = new System.Drawing.Size(174, 150);
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
            this.kaiUpdateBtn.Location = new System.Drawing.Point(724, 767);
            this.kaiUpdateBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiUpdateBtn.Name = "kaiUpdateBtn";
            this.kaiUpdateBtn.Size = new System.Drawing.Size(174, 150);
            this.kaiUpdateBtn.TabIndex = 17;
            this.kaiUpdateBtn.Text = "UPDATE";
            this.kaiUpdateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // kaiDeleteBtn
            // 
            this.kaiDeleteBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.kaiDeleteBtn.IconColor = System.Drawing.Color.Black;
            this.kaiDeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiDeleteBtn.Location = new System.Drawing.Point(914, 767);
            this.kaiDeleteBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiDeleteBtn.Name = "kaiDeleteBtn";
            this.kaiDeleteBtn.Size = new System.Drawing.Size(174, 150);
            this.kaiDeleteBtn.TabIndex = 18;
            this.kaiDeleteBtn.Text = "DELETE";
            this.kaiDeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaiDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // kaiReturnBtn
            // 
            this.kaiReturnBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.kaiReturnBtn.IconColor = System.Drawing.Color.Black;
            this.kaiReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaiReturnBtn.Location = new System.Drawing.Point(1168, 767);
            this.kaiReturnBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiReturnBtn.Name = "kaiReturnBtn";
            this.kaiReturnBtn.Size = new System.Drawing.Size(174, 150);
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
            this.addKaiSaveBtn.Location = new System.Drawing.Point(864, 648);
            this.addKaiSaveBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addKaiSaveBtn.Name = "addKaiSaveBtn";
            this.addKaiSaveBtn.Size = new System.Drawing.Size(184, 67);
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
            this.addKaiCancelBtn.Location = new System.Drawing.Point(1118, 648);
            this.addKaiCancelBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addKaiCancelBtn.Name = "addKaiCancelBtn";
            this.addKaiCancelBtn.Size = new System.Drawing.Size(186, 67);
            this.addKaiCancelBtn.TabIndex = 21;
            this.addKaiCancelBtn.Text = "CANCEL";
            this.addKaiCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addKaiCancelBtn.UseVisualStyleBackColor = true;
            this.addKaiCancelBtn.Visible = false;
            this.addKaiCancelBtn.Click += new System.EventHandler(this.addKaiCancelBtn_Click);
            // 
            // kaiAddCheckBox
            // 
            this.kaiAddCheckBox.AutoSize = true;
            this.kaiAddCheckBox.Location = new System.Drawing.Point(912, 381);
            this.kaiAddCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaiAddCheckBox.Name = "kaiAddCheckBox";
            this.kaiAddCheckBox.Size = new System.Drawing.Size(28, 27);
            this.kaiAddCheckBox.TabIndex = 22;
            this.kaiAddCheckBox.UseVisualStyleBackColor = true;
            this.kaiAddCheckBox.Visible = false;
            // 
            // KaiMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1482, 990);
            this.Controls.Add(this.kaiAddCheckBox);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "KaiMaintenanceForm";
            this.Text = "Kai Maintenance";
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
        private System.Windows.Forms.CheckBox kaiAddCheckBox;
    }
}