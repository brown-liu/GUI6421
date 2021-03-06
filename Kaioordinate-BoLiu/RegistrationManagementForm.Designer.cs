
namespace Kaioordinate_BoLiu
{
    partial class RegistrationManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationManagementForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSetKaioordinate = new Kaioordinate_BoLiu.DataSetKaioordinate();
            this.locationReturnBtn = new FontAwesome.Sharp.IconButton();
            this.deleteEventAndWhanauBtn = new FontAwesome.Sharp.IconButton();
            this.linkEventAndWhanauBtn = new FontAwesome.Sharp.IconButton();
            this.checkBoxRegistrationHome = new System.Windows.Forms.CheckBox();
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.dataGridViewRegistrations = new System.Windows.Forms.DataGridView();
            this.dataGridViewWhanau = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKaioordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWhanau)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(638, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Whanau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(135, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registrations";
            // 
            // dataSetKaioordinate
            // 
            this.dataSetKaioordinate.DataSetName = "DataSetKaioordinate";
            this.dataSetKaioordinate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationReturnBtn
            // 
            this.locationReturnBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationReturnBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.locationReturnBtn.IconColor = System.Drawing.Color.Black;
            this.locationReturnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locationReturnBtn.Location = new System.Drawing.Point(770, 440);
            this.locationReturnBtn.Margin = new System.Windows.Forms.Padding(6);
            this.locationReturnBtn.Name = "locationReturnBtn";
            this.locationReturnBtn.Size = new System.Drawing.Size(117, 101);
            this.locationReturnBtn.TabIndex = 88;
            this.locationReturnBtn.Text = "RETURN";
            this.locationReturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.locationReturnBtn.UseVisualStyleBackColor = true;
            this.locationReturnBtn.Click += new System.EventHandler(this.locationReturnBtn_Click);
            // 
            // deleteEventAndWhanauBtn
            // 
            this.deleteEventAndWhanauBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventAndWhanauBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteEventAndWhanauBtn.IconColor = System.Drawing.Color.Black;
            this.deleteEventAndWhanauBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteEventAndWhanauBtn.Location = new System.Drawing.Point(602, 440);
            this.deleteEventAndWhanauBtn.Margin = new System.Windows.Forms.Padding(6);
            this.deleteEventAndWhanauBtn.Name = "deleteEventAndWhanauBtn";
            this.deleteEventAndWhanauBtn.Size = new System.Drawing.Size(117, 101);
            this.deleteEventAndWhanauBtn.TabIndex = 87;
            this.deleteEventAndWhanauBtn.Text = "DELETE";
            this.deleteEventAndWhanauBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteEventAndWhanauBtn.UseVisualStyleBackColor = true;
            this.deleteEventAndWhanauBtn.Click += new System.EventHandler(this.deleteEventAndWhanauBtn_Click);
            // 
            // linkEventAndWhanauBtn
            // 
            this.linkEventAndWhanauBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEventAndWhanauBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.linkEventAndWhanauBtn.IconColor = System.Drawing.Color.Black;
            this.linkEventAndWhanauBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.linkEventAndWhanauBtn.Location = new System.Drawing.Point(471, 440);
            this.linkEventAndWhanauBtn.Margin = new System.Windows.Forms.Padding(6);
            this.linkEventAndWhanauBtn.Name = "linkEventAndWhanauBtn";
            this.linkEventAndWhanauBtn.Size = new System.Drawing.Size(117, 101);
            this.linkEventAndWhanauBtn.TabIndex = 85;
            this.linkEventAndWhanauBtn.Text = "ADD";
            this.linkEventAndWhanauBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkEventAndWhanauBtn.UseVisualStyleBackColor = true;
            this.linkEventAndWhanauBtn.Click += new System.EventHandler(this.linkEventAndWhanauBtn_Click);
            // 
            // checkBoxRegistrationHome
            // 
            this.checkBoxRegistrationHome.AutoSize = true;
            this.checkBoxRegistrationHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRegistrationHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxRegistrationHome.Location = new System.Drawing.Point(485, 323);
            this.checkBoxRegistrationHome.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxRegistrationHome.Name = "checkBoxRegistrationHome";
            this.checkBoxRegistrationHome.Size = new System.Drawing.Size(479, 48);
            this.checkBoxRegistrationHome.TabIndex = 89;
            this.checkBoxRegistrationHome.Text = "Kai Preparation Assistant";
            this.checkBoxRegistrationHome.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Location = new System.Drawing.Point(15, 39);
            this.dataGridViewEvent.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.ReadOnly = true;
            this.dataGridViewEvent.RowHeadersWidth = 82;
            this.dataGridViewEvent.Size = new System.Drawing.Size(418, 248);
            this.dataGridViewEvent.TabIndex = 90;
            this.dataGridViewEvent.SelectionChanged += new System.EventHandler(this.dataGridViewEvent_SelectionChanged);
            // 
            // dataGridViewRegistrations
            // 
            this.dataGridViewRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrations.Location = new System.Drawing.Point(15, 323);
            this.dataGridViewRegistrations.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewRegistrations.Name = "dataGridViewRegistrations";
            this.dataGridViewRegistrations.ReadOnly = true;
            this.dataGridViewRegistrations.RowHeadersWidth = 82;
            this.dataGridViewRegistrations.Size = new System.Drawing.Size(418, 261);
            this.dataGridViewRegistrations.TabIndex = 91;
            // 
            // dataGridViewWhanau
            // 
            this.dataGridViewWhanau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWhanau.Location = new System.Drawing.Point(478, 39);
            this.dataGridViewWhanau.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewWhanau.Name = "dataGridViewWhanau";
            this.dataGridViewWhanau.ReadOnly = true;
            this.dataGridViewWhanau.RowHeadersWidth = 82;
            this.dataGridViewWhanau.Size = new System.Drawing.Size(409, 248);
            this.dataGridViewWhanau.TabIndex = 92;
            // 
            // RegistrationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1369, 1027);
            this.Controls.Add(this.dataGridViewWhanau);
            this.Controls.Add(this.dataGridViewRegistrations);
            this.Controls.Add(this.dataGridViewEvent);
            this.Controls.Add(this.checkBoxRegistrationHome);
            this.Controls.Add(this.locationReturnBtn);
            this.Controls.Add(this.deleteEventAndWhanauBtn);
            this.Controls.Add(this.linkEventAndWhanauBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegistrationManagementForm";
            this.Text = "Registration Management Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKaioordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWhanau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataSetKaioordinate dataSetKaioordinate;
        private FontAwesome.Sharp.IconButton locationReturnBtn;
        private FontAwesome.Sharp.IconButton deleteEventAndWhanauBtn;
        private FontAwesome.Sharp.IconButton linkEventAndWhanauBtn;
        private System.Windows.Forms.CheckBox checkBoxRegistrationHome;
        private System.Windows.Forms.DataGridView dataGridViewEvent;
        private System.Windows.Forms.DataGridView dataGridViewRegistrations;
        private System.Windows.Forms.DataGridView dataGridViewWhanau;
    }
}