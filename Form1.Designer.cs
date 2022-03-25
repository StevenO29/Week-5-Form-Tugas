namespace Week5_WinForm
{
    partial class FormTugas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblData = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.TxtBoxData = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.leftListBox = new System.Windows.Forms.ListBox();
            this.btnMoveAllToRight = new System.Windows.Forms.Button();
            this.btnMoveToRight = new System.Windows.Forms.Button();
            this.btnMoveToLeft = new System.Windows.Forms.Button();
            this.btnMoveAllToLeft = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chBoxBlock = new System.Windows.Forms.CheckBox();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(29, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 25);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data :";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(29, 91);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(73, 25);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Mode : ";
            // 
            // TxtBoxData
            // 
            this.TxtBoxData.Location = new System.Drawing.Point(108, 25);
            this.TxtBoxData.Name = "TxtBoxData";
            this.TxtBoxData.Size = new System.Drawing.Size(331, 31);
            this.TxtBoxData.TabIndex = 2;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Add",
            "Replace"});
            this.comboBoxMode.Location = new System.Drawing.Point(108, 91);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(331, 33);
            this.comboBoxMode.TabIndex = 3;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(29, 149);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(112, 34);
            this.btnProses.TabIndex = 4;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // leftListBox
            // 
            this.leftListBox.FormattingEnabled = true;
            this.leftListBox.ItemHeight = 25;
            this.leftListBox.Location = new System.Drawing.Point(28, 212);
            this.leftListBox.Name = "leftListBox";
            this.leftListBox.Size = new System.Drawing.Size(253, 429);
            this.leftListBox.TabIndex = 5;
            // 
            // btnMoveAllToRight
            // 
            this.btnMoveAllToRight.Location = new System.Drawing.Point(308, 318);
            this.btnMoveAllToRight.Name = "btnMoveAllToRight";
            this.btnMoveAllToRight.Size = new System.Drawing.Size(64, 34);
            this.btnMoveAllToRight.TabIndex = 7;
            this.btnMoveAllToRight.Text = ">>";
            this.btnMoveAllToRight.UseVisualStyleBackColor = true;
            this.btnMoveAllToRight.Click += new System.EventHandler(this.btnMoveAllToRight_Click);
            // 
            // btnMoveToRight
            // 
            this.btnMoveToRight.Location = new System.Drawing.Point(308, 367);
            this.btnMoveToRight.Name = "btnMoveToRight";
            this.btnMoveToRight.Size = new System.Drawing.Size(64, 34);
            this.btnMoveToRight.TabIndex = 8;
            this.btnMoveToRight.Text = ">";
            this.btnMoveToRight.UseVisualStyleBackColor = true;
            this.btnMoveToRight.Click += new System.EventHandler(this.btnMoveToRight_Click);
            // 
            // btnMoveToLeft
            // 
            this.btnMoveToLeft.Location = new System.Drawing.Point(308, 418);
            this.btnMoveToLeft.Name = "btnMoveToLeft";
            this.btnMoveToLeft.Size = new System.Drawing.Size(64, 34);
            this.btnMoveToLeft.TabIndex = 9;
            this.btnMoveToLeft.Text = "<";
            this.btnMoveToLeft.UseVisualStyleBackColor = true;
            this.btnMoveToLeft.Click += new System.EventHandler(this.btnMoveToLeft_Click);
            // 
            // btnMoveAllToLeft
            // 
            this.btnMoveAllToLeft.Location = new System.Drawing.Point(308, 470);
            this.btnMoveAllToLeft.Name = "btnMoveAllToLeft";
            this.btnMoveAllToLeft.Size = new System.Drawing.Size(64, 34);
            this.btnMoveAllToLeft.TabIndex = 10;
            this.btnMoveAllToLeft.Text = "<<";
            this.btnMoveAllToLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllToLeft.Click += new System.EventHandler(this.btnMoveAllToLeft_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(308, 523);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chBoxBlock
            // 
            this.chBoxBlock.AutoSize = true;
            this.chBoxBlock.Location = new System.Drawing.Point(318, 154);
            this.chBoxBlock.Name = "chBoxBlock";
            this.chBoxBlock.Size = new System.Drawing.Size(80, 29);
            this.chBoxBlock.TabIndex = 12;
            this.chBoxBlock.Text = "Block";
            this.chBoxBlock.UseVisualStyleBackColor = true;
            this.chBoxBlock.CheckedChanged += new System.EventHandler(this.chBoxBlock_CheckedChanged);
            // 
            // listBoxRight
            // 
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.ItemHeight = 25;
            this.listBoxRight.Location = new System.Drawing.Point(405, 212);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(253, 429);
            this.listBoxRight.TabIndex = 13;
            // 
            // FormTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 661);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.chBoxBlock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMoveAllToLeft);
            this.Controls.Add(this.btnMoveToLeft);
            this.Controls.Add(this.btnMoveToRight);
            this.Controls.Add(this.btnMoveAllToRight);
            this.Controls.Add(this.leftListBox);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.TxtBoxData);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblData);
            this.Name = "FormTugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tugas";
            this.Load += new System.EventHandler(this.FormTugas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox TxtBoxData;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.ListBox leftListBox;
        private System.Windows.Forms.Button btnMoveAllToRight;
        private System.Windows.Forms.Button btnMoveToRight;
        private System.Windows.Forms.Button btnMoveToLeft;
        private System.Windows.Forms.Button btnMoveAllToLeft;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chBoxBlock;
        private System.Windows.Forms.ListBox listBoxRight;
    }
}
