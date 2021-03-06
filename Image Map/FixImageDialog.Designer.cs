﻿namespace Image_Map
{
    partial class FixImageDialog
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.FixImageInfo = new System.Windows.Forms.Label();
            this.StretchRadio = new System.Windows.Forms.RadioButton();
            this.CropRadio = new System.Windows.Forms.RadioButton();
            this.ColumnsInput = new System.Windows.Forms.NumericUpDown();
            this.RowsInput = new System.Windows.Forms.NumericUpDown();
            this.ColumnInfo = new System.Windows.Forms.Label();
            this.RowInfo = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.Location = new System.Drawing.Point(18, 18);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(191, 196);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // FixImageInfo
            // 
            this.FixImageInfo.AutoSize = true;
            this.FixImageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FixImageInfo.Location = new System.Drawing.Point(237, 18);
            this.FixImageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FixImageInfo.Name = "FixImageInfo";
            this.FixImageInfo.Size = new System.Drawing.Size(381, 72);
            this.FixImageInfo.TabIndex = 1;
            this.FixImageInfo.Text = "Your image is not 128×128.\r\nWhat should be done?";
            // 
            // StretchRadio
            // 
            this.StretchRadio.AutoSize = true;
            this.StretchRadio.Checked = true;
            this.StretchRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StretchRadio.Location = new System.Drawing.Point(244, 125);
            this.StretchRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StretchRadio.Name = "StretchRadio";
            this.StretchRadio.Size = new System.Drawing.Size(163, 33);
            this.StretchRadio.TabIndex = 2;
            this.StretchRadio.TabStop = true;
            this.StretchRadio.Text = "Stretch to fit";
            this.StretchRadio.UseVisualStyleBackColor = true;
            this.StretchRadio.CheckedChanged += new System.EventHandler(this.StretchRadio_CheckedChanged);
            // 
            // CropRadio
            // 
            this.CropRadio.AutoSize = true;
            this.CropRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CropRadio.Location = new System.Drawing.Point(244, 171);
            this.CropRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CropRadio.Name = "CropRadio";
            this.CropRadio.Size = new System.Drawing.Size(149, 33);
            this.CropRadio.TabIndex = 4;
            this.CropRadio.Text = "Crop extra";
            this.CropRadio.UseVisualStyleBackColor = true;
            // 
            // ColumnsInput
            // 
            this.ColumnsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ColumnsInput.Location = new System.Drawing.Point(244, 263);
            this.ColumnsInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColumnsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnsInput.Name = "ColumnsInput";
            this.ColumnsInput.Size = new System.Drawing.Size(76, 39);
            this.ColumnsInput.TabIndex = 5;
            this.ColumnsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnsInput.ValueChanged += new System.EventHandler(this.ColumnsInput_ValueChanged);
            // 
            // RowsInput
            // 
            this.RowsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RowsInput.Location = new System.Drawing.Point(339, 263);
            this.RowsInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RowsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowsInput.Name = "RowsInput";
            this.RowsInput.Size = new System.Drawing.Size(76, 39);
            this.RowsInput.TabIndex = 6;
            this.RowsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowsInput.ValueChanged += new System.EventHandler(this.RowsInput_ValueChanged);
            // 
            // ColumnInfo
            // 
            this.ColumnInfo.AutoSize = true;
            this.ColumnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ColumnInfo.Location = new System.Drawing.Point(237, 312);
            this.ColumnInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColumnInfo.Name = "ColumnInfo";
            this.ColumnInfo.Size = new System.Drawing.Size(90, 25);
            this.ColumnInfo.TabIndex = 7;
            this.ColumnInfo.Text = "Columns";
            // 
            // RowInfo
            // 
            this.RowInfo.AutoSize = true;
            this.RowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RowInfo.Location = new System.Drawing.Point(339, 312);
            this.RowInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RowInfo.Name = "RowInfo";
            this.RowInfo.Size = new System.Drawing.Size(60, 25);
            this.RowInfo.TabIndex = 8;
            this.RowInfo.Text = "Rows";
            // 
            // ResultBox
            // 
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Location = new System.Drawing.Point(18, 225);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(191, 196);
            this.ResultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResultBox.TabIndex = 9;
            this.ResultBox.TabStop = false;
            // 
            // FixImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 437);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.RowInfo);
            this.Controls.Add(this.ColumnInfo);
            this.Controls.Add(this.RowsInput);
            this.Controls.Add(this.ColumnsInput);
            this.Controls.Add(this.CropRadio);
            this.Controls.Add(this.StretchRadio);
            this.Controls.Add(this.FixImageInfo);
            this.Controls.Add(this.ImageBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FixImageDialog";
            this.Text = "Fix Image";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label FixImageInfo;
        private System.Windows.Forms.RadioButton StretchRadio;
        private System.Windows.Forms.RadioButton CropRadio;
        private System.Windows.Forms.NumericUpDown ColumnsInput;
        private System.Windows.Forms.NumericUpDown RowsInput;
        private System.Windows.Forms.Label ColumnInfo;
        private System.Windows.Forms.Label RowInfo;
        private System.Windows.Forms.PictureBox ResultBox;
    }
}