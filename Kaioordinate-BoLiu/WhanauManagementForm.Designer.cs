
namespace Kaioordinate_BoLiu
{
    partial class WhanauManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhanauManagementForm));
            this.whanauReturnBtn = new FontAwesome.Sharp.IconButton();
            this.whanauDeleteBtn = new FontAwesome.Sharp.IconButton();
            this.whanauUpdateBtn = new FontAwesome.Sharp.IconButton();
            this.whanauAddBtn = new FontAwesome.Sharp.IconButton();
            this.whanauDownBtn = new FontAwesome.Sharp.IconButton();
            this.whanauUpBtn = new FontAwesome.Sharp.IconButton();
            this.labelEmail = new System.Windows.Forms.Label();
            this.displayEmail = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.displayLastName = new System.Windows.Forms.TextBox();
            this.displayWhanauId = new System.Windows.Forms.TextBox();
            this.displayFirstName = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelWID = new System.Windows.Forms.Label();
            this.whanauListBox = new System.Windows.Forms.ListBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.displayAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayPhone = new System.Windows.Forms.TextBox();
            this.panelAddWhannau = new System.Windows.Forms.Panel();
            this.panelUpdateWhanauBtn = new FontAwesome.Sharp.IconButton();
            this.panelCancel = new FontAwesome.Sharp.IconButton();
            this.panelAddWhanauBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAddPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAddAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAddEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAddLastName = new System.Windows.Forms.TextBox();
            this.panelAddFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAddWhannau.SuspendLayout();
            this.SuspendLayout();
            // 
            // whanauReturnBtn
            // 
            this.whanauReturnBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whanauReturnBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.whanauReturnBtn.IconColor = System.Drawing.Color.Black;
            this.whanauReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.whanauReturnBtn.Location = new System.Drawing.Point(629, 364);
            this.whanauReturnBtn.Name = "whanauReturnBtn";
            this.whanauReturnBtn.Size = new System.Drawing.Size(87, 78);
            this.whanauReturnBtn.TabIndex = 62;
            this.whanauReturnBtn.Text = "RETURN";
            this.whanauReturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.whanauReturnBtn.UseVisualStyleBackColor = true;
            this.whanauReturnBtn.Click += new System.EventHandler(this.whanauReturnBtn_Click);
            // 
            // whanauDeleteBtn
            // 
            this.whanauDeleteBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whanauDeleteBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.whanauDeleteBtn.IconColor = System.Drawing.Color.Black;
            this.whanauDeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.whanauDeleteBtn.Location = new System.Drawing.Point(502, 364);
            this.whanauDeleteBtn.Name = "whanauDeleteBtn";
            this.whanauDeleteBtn.Size = new System.Drawing.Size(87, 78);
            this.whanauDeleteBtn.TabIndex = 61;
            this.whanauDeleteBtn.Text = "DELETE";
            this.whanauDeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.whanauDeleteBtn.UseVisualStyleBackColor = true;
            this.whanauDeleteBtn.Click += new System.EventHandler(this.whanauDeleteBtn_Click);
            // 
            // whanauUpdateBtn
            // 
            this.whanauUpdateBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whanauUpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.whanauUpdateBtn.IconColor = System.Drawing.Color.Black;
            this.whanauUpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.whanauUpdateBtn.Location = new System.Drawing.Point(407, 364);
            this.whanauUpdateBtn.Name = "whanauUpdateBtn";
            this.whanauUpdateBtn.Size = new System.Drawing.Size(87, 78);
            this.whanauUpdateBtn.TabIndex = 60;
            this.whanauUpdateBtn.Text = "UPDATE";
            this.whanauUpdateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.whanauUpdateBtn.UseVisualStyleBackColor = true;
            this.whanauUpdateBtn.Click += new System.EventHandler(this.whanauUpdateBtn_Click);
            // 
            // whanauAddBtn
            // 
            this.whanauAddBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whanauAddBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.whanauAddBtn.IconColor = System.Drawing.Color.Black;
            this.whanauAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.whanauAddBtn.Location = new System.Drawing.Point(314, 364);
            this.whanauAddBtn.Name = "whanauAddBtn";
            this.whanauAddBtn.Size = new System.Drawing.Size(87, 78);
            this.whanauAddBtn.TabIndex = 59;
            this.whanauAddBtn.Text = "ADD";
            this.whanauAddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.whanauAddBtn.UseVisualStyleBackColor = true;
            this.whanauAddBtn.Click += new System.EventHandler(this.whanauAddBtn_Click);
            // 
            // whanauDownBtn
            // 
            this.whanauDownBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whanauDownBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.whanauDownBtn.IconColor = System.Drawing.Color.Black;
            this.whanauDownBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.whanauDownBtn.Location = new System.Drawing.Point(178, 364);
            this.whanauDownBtn.Name = "whanauDownBtn";
            this.whanauDownBtn.Size = new System.Drawing.Size(87, 78);
            this.whanauDownBtn.TabIndex = 58;
            this.whanauDownBtn.Text = "DOWN";
            this.whanauDownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.whanauDownBtn.UseVisualStyleBackColor = true;
            this.whanauDownBtn.Click += new System.EventHandler(this.whanauDownBtn_Click);
            // 
            // whanauUpBtn
            // 
            this.whanauUpBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whanauUpBtn.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.whanauUpBtn.IconColor = System.Drawing.Color.Black;
            this.whanauUpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.whanauUpBtn.Location = new System.Drawing.Point(85, 364);
            this.whanauUpBtn.Name = "whanauUpBtn";
            this.whanauUpBtn.Size = new System.Drawing.Size(87, 78);
            this.whanauUpBtn.TabIndex = 57;
            this.whanauUpBtn.Text = "UP";
            this.whanauUpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.whanauUpBtn.UseVisualStyleBackColor = true;
            this.whanauUpBtn.Click += new System.EventHandler(this.whanauUpBtn_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Location = new System.Drawing.Point(336, 166);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 24);
            this.labelEmail.TabIndex = 56;
            this.labelEmail.Text = "Email";
            // 
            // displayEmail
            // 
            this.displayEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmail.Location = new System.Drawing.Point(444, 165);
            this.displayEmail.Name = "displayEmail";
            this.displayEmail.ReadOnly = true;
            this.displayEmail.Size = new System.Drawing.Size(231, 29);
            this.displayEmail.TabIndex = 55;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLName.Location = new System.Drawing.Point(302, 120);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(99, 24);
            this.labelLName.TabIndex = 54;
            this.labelLName.Text = "Last Name";
            // 
            // displayLastName
            // 
            this.displayLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLastName.Location = new System.Drawing.Point(445, 123);
            this.displayLastName.Name = "displayLastName";
            this.displayLastName.ReadOnly = true;
            this.displayLastName.Size = new System.Drawing.Size(230, 29);
            this.displayLastName.TabIndex = 53;
            // 
            // displayWhanauId
            // 
            this.displayWhanauId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWhanauId.Location = new System.Drawing.Point(446, 38);
            this.displayWhanauId.Name = "displayWhanauId";
            this.displayWhanauId.ReadOnly = true;
            this.displayWhanauId.Size = new System.Drawing.Size(228, 29);
            this.displayWhanauId.TabIndex = 52;
            // 
            // displayFirstName
            // 
            this.displayFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFirstName.Location = new System.Drawing.Point(445, 78);
            this.displayFirstName.Name = "displayFirstName";
            this.displayFirstName.ReadOnly = true;
            this.displayFirstName.Size = new System.Drawing.Size(228, 29);
            this.displayFirstName.TabIndex = 51;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFName.Location = new System.Drawing.Point(300, 78);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(101, 24);
            this.labelFName.TabIndex = 50;
            this.labelFName.Text = "First Name";
            // 
            // labelWID
            // 
            this.labelWID.AutoSize = true;
            this.labelWID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWID.Location = new System.Drawing.Point(304, 38);
            this.labelWID.Name = "labelWID";
            this.labelWID.Size = new System.Drawing.Size(103, 24);
            this.labelWID.TabIndex = 49;
            this.labelWID.Text = "Whanau ID";
            // 
            // whanauListBox
            // 
            this.whanauListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whanauListBox.FormattingEnabled = true;
            this.whanauListBox.ItemHeight = 24;
            this.whanauListBox.Location = new System.Drawing.Point(39, 28);
            this.whanauListBox.Name = "whanauListBox";
            this.whanauListBox.Size = new System.Drawing.Size(226, 292);
            this.whanauListBox.TabIndex = 48;
            this.whanauListBox.SelectedIndexChanged += new System.EventHandler(this.whanauListBox_SelectedIndexChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddress.Location = new System.Drawing.Point(314, 248);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(80, 24);
            this.labelAddress.TabIndex = 65;
            this.labelAddress.Text = "Address";
            // 
            // displayAddress
            // 
            this.displayAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAddress.Location = new System.Drawing.Point(443, 251);
            this.displayAddress.Multiline = true;
            this.displayAddress.Name = "displayAddress";
            this.displayAddress.ReadOnly = true;
            this.displayAddress.Size = new System.Drawing.Size(232, 63);
            this.displayAddress.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(335, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Phone";
            // 
            // displayPhone
            // 
            this.displayPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPhone.Location = new System.Drawing.Point(444, 205);
            this.displayPhone.Name = "displayPhone";
            this.displayPhone.ReadOnly = true;
            this.displayPhone.Size = new System.Drawing.Size(231, 29);
            this.displayPhone.TabIndex = 66;
            // 
            // panelAddWhannau
            // 
            this.panelAddWhannau.Controls.Add(this.panelUpdateWhanauBtn);
            this.panelAddWhannau.Controls.Add(this.panelCancel);
            this.panelAddWhannau.Controls.Add(this.panelAddWhanauBtn);
            this.panelAddWhannau.Controls.Add(this.label2);
            this.panelAddWhannau.Controls.Add(this.panelAddPhone);
            this.panelAddWhannau.Controls.Add(this.label3);
            this.panelAddWhannau.Controls.Add(this.panelAddAddress);
            this.panelAddWhannau.Controls.Add(this.label4);
            this.panelAddWhannau.Controls.Add(this.panelAddEmail);
            this.panelAddWhannau.Controls.Add(this.label5);
            this.panelAddWhannau.Controls.Add(this.panelAddLastName);
            this.panelAddWhannau.Controls.Add(this.panelAddFirstName);
            this.panelAddWhannau.Controls.Add(this.label6);
            this.panelAddWhannau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAddWhannau.Location = new System.Drawing.Point(294, 22);
            this.panelAddWhannau.Name = "panelAddWhannau";
            this.panelAddWhannau.Size = new System.Drawing.Size(409, 320);
            this.panelAddWhannau.TabIndex = 69;
            this.panelAddWhannau.Visible = false;
            // 
            // panelUpdateWhanauBtn
            // 
            this.panelUpdateWhanauBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUpdateWhanauBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.panelUpdateWhanauBtn.IconColor = System.Drawing.Color.Black;
            this.panelUpdateWhanauBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelUpdateWhanauBtn.IconSize = 25;
            this.panelUpdateWhanauBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelUpdateWhanauBtn.Location = new System.Drawing.Point(81, 279);
            this.panelUpdateWhanauBtn.Name = "panelUpdateWhanauBtn";
            this.panelUpdateWhanauBtn.Size = new System.Drawing.Size(92, 35);
            this.panelUpdateWhanauBtn.TabIndex = 80;
            this.panelUpdateWhanauBtn.TabStop = false;
            this.panelUpdateWhanauBtn.Text = "Save";
            this.panelUpdateWhanauBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.panelUpdateWhanauBtn.UseVisualStyleBackColor = true;
            this.panelUpdateWhanauBtn.Click += new System.EventHandler(this.panelUpdateWhanauBtn_Click);
            // 
            // panelCancel
            // 
            this.panelCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.panelCancel.IconColor = System.Drawing.Color.Black;
            this.panelCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelCancel.IconSize = 25;
            this.panelCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelCancel.Location = new System.Drawing.Point(220, 280);
            this.panelCancel.Name = "panelCancel";
            this.panelCancel.Size = new System.Drawing.Size(92, 35);
            this.panelCancel.TabIndex = 79;
            this.panelCancel.Text = "Cancel";
            this.panelCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.panelCancel.UseVisualStyleBackColor = true;
            this.panelCancel.Click += new System.EventHandler(this.panelCancel_Click);
            // 
            // panelAddWhanauBtn
            // 
            this.panelAddWhanauBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAddWhanauBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.panelAddWhanauBtn.IconColor = System.Drawing.Color.Black;
            this.panelAddWhanauBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.panelAddWhanauBtn.IconSize = 25;
            this.panelAddWhanauBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelAddWhanauBtn.Location = new System.Drawing.Point(55, 279);
            this.panelAddWhanauBtn.Name = "panelAddWhanauBtn";
            this.panelAddWhanauBtn.Size = new System.Drawing.Size(92, 35);
            this.panelAddWhanauBtn.TabIndex = 78;
            this.panelAddWhanauBtn.Text = "Save";
            this.panelAddWhanauBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.panelAddWhanauBtn.UseVisualStyleBackColor = true;
            this.panelAddWhanauBtn.Click += new System.EventHandler(this.panelAddWhanau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(50, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 77;
            this.label2.Text = "Phone";
            // 
            // panelAddPhone
            // 
            this.panelAddPhone.Location = new System.Drawing.Point(159, 145);
            this.panelAddPhone.Name = "panelAddPhone";
            this.panelAddPhone.Size = new System.Drawing.Size(231, 29);
            this.panelAddPhone.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "Address";
            // 
            // panelAddAddress
            // 
            this.panelAddAddress.Location = new System.Drawing.Point(158, 191);
            this.panelAddAddress.Multiline = true;
            this.panelAddAddress.Name = "panelAddAddress";
            this.panelAddAddress.Size = new System.Drawing.Size(232, 63);
            this.panelAddAddress.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(51, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 73;
            this.label4.Text = "Email";
            // 
            // panelAddEmail
            // 
            this.panelAddEmail.Location = new System.Drawing.Point(159, 105);
            this.panelAddEmail.Name = "panelAddEmail";
            this.panelAddEmail.Size = new System.Drawing.Size(231, 29);
            this.panelAddEmail.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Last Name";
            // 
            // panelAddLastName
            // 
            this.panelAddLastName.Location = new System.Drawing.Point(160, 63);
            this.panelAddLastName.Name = "panelAddLastName";
            this.panelAddLastName.Size = new System.Drawing.Size(230, 29);
            this.panelAddLastName.TabIndex = 70;
            // 
            // panelAddFirstName
            // 
            this.panelAddFirstName.Location = new System.Drawing.Point(160, 18);
            this.panelAddFirstName.Name = "panelAddFirstName";
            this.panelAddFirstName.Size = new System.Drawing.Size(228, 29);
            this.panelAddFirstName.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "First Name";
            // 
            // WhanauManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(767, 488);
            this.Controls.Add(this.panelAddWhannau);
            this.Controls.Add(this.whanauReturnBtn);
            this.Controls.Add(this.whanauDeleteBtn);
            this.Controls.Add(this.whanauUpdateBtn);
            this.Controls.Add(this.whanauAddBtn);
            this.Controls.Add(this.whanauDownBtn);
            this.Controls.Add(this.whanauUpBtn);
            this.Controls.Add(this.whanauListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.displayAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.displayEmail);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.displayLastName);
            this.Controls.Add(this.displayWhanauId);
            this.Controls.Add(this.displayFirstName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelWID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhanauManagementForm";
            this.Text = "Whanau Management Form";
            this.panelAddWhannau.ResumeLayout(false);
            this.panelAddWhannau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton whanauReturnBtn;
        private FontAwesome.Sharp.IconButton whanauDeleteBtn;
        private FontAwesome.Sharp.IconButton whanauUpdateBtn;
        private FontAwesome.Sharp.IconButton whanauAddBtn;
        private FontAwesome.Sharp.IconButton whanauDownBtn;
        private FontAwesome.Sharp.IconButton whanauUpBtn;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox displayEmail;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox displayLastName;
        private System.Windows.Forms.TextBox displayWhanauId;
        private System.Windows.Forms.TextBox displayFirstName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelWID;
        private System.Windows.Forms.ListBox whanauListBox;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox displayAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayPhone;
        private System.Windows.Forms.Panel panelAddWhannau;
        private FontAwesome.Sharp.IconButton panelCancel;
        private FontAwesome.Sharp.IconButton panelAddWhanauBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox panelAddPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox panelAddAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox panelAddEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox panelAddLastName;
        private System.Windows.Forms.TextBox panelAddFirstName;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton panelUpdateWhanauBtn;
    }
}