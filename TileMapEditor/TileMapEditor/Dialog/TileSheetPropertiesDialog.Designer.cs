﻿namespace TileMapEditor.Dialog
{
    partial class TileSheetPropertiesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileSheetPropertiesDialog));
            this.m_buttonOk = new System.Windows.Forms.Button();
            this.m_buttonCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.m_customTabControl = new TileMapEditor.Control.CustomTabControl();
            this.m_tabGeneral = new System.Windows.Forms.TabPage();
            this.m_labelImageSource = new System.Windows.Forms.Label();
            this.m_buttonBrowse = new System.Windows.Forms.Button();
            this.m_textBoxImageSource = new System.Windows.Forms.TextBox();
            this.m_textBoxDescription = new System.Windows.Forms.TextBox();
            this.m_labelDescription = new System.Windows.Forms.Label();
            this.m_textBoxId = new System.Windows.Forms.TextBox();
            this.m_labelId = new System.Windows.Forms.Label();
            this.m_tabAlignment = new System.Windows.Forms.TabPage();
            this.m_panelImage = new System.Windows.Forms.Panel();
            this.m_trackBar = new System.Windows.Forms.TrackBar();
            this.m_labelZoom = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.m_textBoxTileHeight = new System.Windows.Forms.NumericUpDown();
            this.m_labelTileSizeBy = new System.Windows.Forms.Label();
            this.m_textBoxTileWidth = new System.Windows.Forms.NumericUpDown();
            this.m_labelTileSize = new System.Windows.Forms.Label();
            this.m_tabCustomProperties = new System.Windows.Forms.TabPage();
            this.m_customPropertyGrid = new TileMapEditor.Control.CustomPropertyGrid();
            this.m_customTabControl.SuspendLayout();
            this.m_tabGeneral.SuspendLayout();
            this.m_tabAlignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_textBoxTileHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_textBoxTileWidth)).BeginInit();
            this.m_tabCustomProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_buttonOk
            // 
            this.m_buttonOk.Location = new System.Drawing.Point(12, 377);
            this.m_buttonOk.Name = "m_buttonOk";
            this.m_buttonOk.Size = new System.Drawing.Size(75, 23);
            this.m_buttonOk.TabIndex = 1;
            this.m_buttonOk.Text = "OK";
            this.m_buttonOk.UseVisualStyleBackColor = true;
            this.m_buttonOk.Click += new System.EventHandler(this.m_buttonOk_Click);
            // 
            // m_buttonCancel
            // 
            this.m_buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_buttonCancel.Location = new System.Drawing.Point(497, 377);
            this.m_buttonCancel.Name = "m_buttonCancel";
            this.m_buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.m_buttonCancel.TabIndex = 2;
            this.m_buttonCancel.Text = "Cancel";
            this.m_buttonCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(150, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // m_customTabControl
            // 
            this.m_customTabControl.Controls.Add(this.m_tabGeneral);
            this.m_customTabControl.Controls.Add(this.m_tabAlignment);
            this.m_customTabControl.Controls.Add(this.m_tabCustomProperties);
            this.m_customTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.m_customTabControl.Location = new System.Drawing.Point(12, 12);
            this.m_customTabControl.Name = "m_customTabControl";
            this.m_customTabControl.SelectedIndex = 0;
            this.m_customTabControl.Size = new System.Drawing.Size(560, 359);
            this.m_customTabControl.TabIndex = 3;
            // 
            // m_tabGeneral
            // 
            this.m_tabGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.m_tabGeneral.Controls.Add(this.m_labelImageSource);
            this.m_tabGeneral.Controls.Add(this.m_buttonBrowse);
            this.m_tabGeneral.Controls.Add(this.m_textBoxImageSource);
            this.m_tabGeneral.Controls.Add(this.m_textBoxDescription);
            this.m_tabGeneral.Controls.Add(this.m_labelDescription);
            this.m_tabGeneral.Controls.Add(this.m_textBoxId);
            this.m_tabGeneral.Controls.Add(this.m_labelId);
            this.m_tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.m_tabGeneral.Name = "m_tabGeneral";
            this.m_tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabGeneral.Size = new System.Drawing.Size(552, 333);
            this.m_tabGeneral.TabIndex = 0;
            this.m_tabGeneral.Text = " General ";
            // 
            // m_labelImageSource
            // 
            this.m_labelImageSource.AutoSize = true;
            this.m_labelImageSource.Location = new System.Drawing.Point(6, 309);
            this.m_labelImageSource.Name = "m_labelImageSource";
            this.m_labelImageSource.Size = new System.Drawing.Size(73, 13);
            this.m_labelImageSource.TabIndex = 6;
            this.m_labelImageSource.Text = "Image Source";
            // 
            // m_buttonBrowse
            // 
            this.m_buttonBrowse.Location = new System.Drawing.Point(471, 304);
            this.m_buttonBrowse.Name = "m_buttonBrowse";
            this.m_buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.m_buttonBrowse.TabIndex = 5;
            this.m_buttonBrowse.Text = "Browse...";
            this.m_buttonBrowse.UseVisualStyleBackColor = true;
            this.m_buttonBrowse.Click += new System.EventHandler(this.m_buttonBrowse_Click);
            // 
            // m_textBoxImageSource
            // 
            this.m_textBoxImageSource.Location = new System.Drawing.Point(103, 306);
            this.m_textBoxImageSource.Name = "m_textBoxImageSource";
            this.m_textBoxImageSource.ReadOnly = true;
            this.m_textBoxImageSource.Size = new System.Drawing.Size(362, 20);
            this.m_textBoxImageSource.TabIndex = 4;
            // 
            // m_textBoxDescription
            // 
            this.m_textBoxDescription.Location = new System.Drawing.Point(103, 33);
            this.m_textBoxDescription.Multiline = true;
            this.m_textBoxDescription.Name = "m_textBoxDescription";
            this.m_textBoxDescription.Size = new System.Drawing.Size(443, 265);
            this.m_textBoxDescription.TabIndex = 3;
            // 
            // m_labelDescription
            // 
            this.m_labelDescription.AutoSize = true;
            this.m_labelDescription.Location = new System.Drawing.Point(6, 36);
            this.m_labelDescription.Name = "m_labelDescription";
            this.m_labelDescription.Size = new System.Drawing.Size(60, 13);
            this.m_labelDescription.TabIndex = 2;
            this.m_labelDescription.Text = "Description";
            // 
            // m_textBoxId
            // 
            this.m_textBoxId.Location = new System.Drawing.Point(103, 7);
            this.m_textBoxId.Name = "m_textBoxId";
            this.m_textBoxId.Size = new System.Drawing.Size(200, 20);
            this.m_textBoxId.TabIndex = 1;
            // 
            // m_labelId
            // 
            this.m_labelId.AutoSize = true;
            this.m_labelId.Location = new System.Drawing.Point(6, 10);
            this.m_labelId.Name = "m_labelId";
            this.m_labelId.Size = new System.Drawing.Size(18, 13);
            this.m_labelId.TabIndex = 0;
            this.m_labelId.Text = "ID";
            // 
            // m_tabAlignment
            // 
            this.m_tabAlignment.BackColor = System.Drawing.SystemColors.Control;
            this.m_tabAlignment.Controls.Add(this.m_panelImage);
            this.m_tabAlignment.Controls.Add(this.m_trackBar);
            this.m_tabAlignment.Controls.Add(this.m_labelZoom);
            this.m_tabAlignment.Controls.Add(this.numericUpDown3);
            this.m_tabAlignment.Controls.Add(this.label3);
            this.m_tabAlignment.Controls.Add(this.numericUpDown4);
            this.m_tabAlignment.Controls.Add(this.label4);
            this.m_tabAlignment.Controls.Add(this.numericUpDown1);
            this.m_tabAlignment.Controls.Add(this.label1);
            this.m_tabAlignment.Controls.Add(this.numericUpDown2);
            this.m_tabAlignment.Controls.Add(this.label2);
            this.m_tabAlignment.Controls.Add(this.m_textBoxTileHeight);
            this.m_tabAlignment.Controls.Add(this.m_labelTileSizeBy);
            this.m_tabAlignment.Controls.Add(this.m_textBoxTileWidth);
            this.m_tabAlignment.Controls.Add(this.m_labelTileSize);
            this.m_tabAlignment.Location = new System.Drawing.Point(4, 22);
            this.m_tabAlignment.Name = "m_tabAlignment";
            this.m_tabAlignment.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabAlignment.Size = new System.Drawing.Size(552, 333);
            this.m_tabAlignment.TabIndex = 2;
            this.m_tabAlignment.Text = "Alignment";
            // 
            // m_panelImage
            // 
            this.m_panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_panelImage.Location = new System.Drawing.Point(7, 57);
            this.m_panelImage.Name = "m_panelImage";
            this.m_panelImage.Size = new System.Drawing.Size(539, 270);
            this.m_panelImage.TabIndex = 13;
            this.m_panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.m_panelImage_Paint);
            // 
            // m_trackBar
            // 
            this.m_trackBar.Location = new System.Drawing.Point(75, 29);
            this.m_trackBar.Minimum = 1;
            this.m_trackBar.Name = "m_trackBar";
            this.m_trackBar.Size = new System.Drawing.Size(159, 45);
            this.m_trackBar.TabIndex = 15;
            this.m_trackBar.Value = 1;
            this.m_trackBar.Scroll += new System.EventHandler(this.m_trackBar_Scroll);
            // 
            // m_labelZoom
            // 
            this.m_labelZoom.AutoSize = true;
            this.m_labelZoom.Location = new System.Drawing.Point(7, 33);
            this.m_labelZoom.Name = "m_labelZoom";
            this.m_labelZoom.Size = new System.Drawing.Size(34, 13);
            this.m_labelZoom.TabIndex = 14;
            this.m_labelZoom.Text = "Zoom";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(478, 31);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "x";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(386, 31);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown4.TabIndex = 10;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown4.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Padding";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(479, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(387, 5);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Margin";
            // 
            // m_textBoxTileHeight
            // 
            this.m_textBoxTileHeight.Location = new System.Drawing.Point(167, 5);
            this.m_textBoxTileHeight.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.m_textBoxTileHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.m_textBoxTileHeight.Name = "m_textBoxTileHeight";
            this.m_textBoxTileHeight.Size = new System.Drawing.Size(67, 20);
            this.m_textBoxTileHeight.TabIndex = 4;
            this.m_textBoxTileHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_textBoxTileHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // m_labelTileSizeBy
            // 
            this.m_labelTileSizeBy.AutoSize = true;
            this.m_labelTileSizeBy.Location = new System.Drawing.Point(149, 7);
            this.m_labelTileSizeBy.Name = "m_labelTileSizeBy";
            this.m_labelTileSizeBy.Size = new System.Drawing.Size(12, 13);
            this.m_labelTileSizeBy.TabIndex = 3;
            this.m_labelTileSizeBy.Text = "x";
            // 
            // m_textBoxTileWidth
            // 
            this.m_textBoxTileWidth.Location = new System.Drawing.Point(75, 5);
            this.m_textBoxTileWidth.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.m_textBoxTileWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.m_textBoxTileWidth.Name = "m_textBoxTileWidth";
            this.m_textBoxTileWidth.Size = new System.Drawing.Size(67, 20);
            this.m_textBoxTileWidth.TabIndex = 2;
            this.m_textBoxTileWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_textBoxTileWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // m_labelTileSize
            // 
            this.m_labelTileSize.AutoSize = true;
            this.m_labelTileSize.Location = new System.Drawing.Point(7, 7);
            this.m_labelTileSize.Name = "m_labelTileSize";
            this.m_labelTileSize.Size = new System.Drawing.Size(47, 13);
            this.m_labelTileSize.TabIndex = 0;
            this.m_labelTileSize.Text = "Tile Size";
            // 
            // m_tabCustomProperties
            // 
            this.m_tabCustomProperties.BackColor = System.Drawing.SystemColors.Control;
            this.m_tabCustomProperties.Controls.Add(this.m_customPropertyGrid);
            this.m_tabCustomProperties.Location = new System.Drawing.Point(4, 22);
            this.m_tabCustomProperties.Name = "m_tabCustomProperties";
            this.m_tabCustomProperties.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabCustomProperties.Size = new System.Drawing.Size(552, 333);
            this.m_tabCustomProperties.TabIndex = 1;
            this.m_tabCustomProperties.Text = " Custom Properties ";
            // 
            // m_customPropertyGrid
            // 
            this.m_customPropertyGrid.Location = new System.Drawing.Point(6, 6);
            this.m_customPropertyGrid.Name = "m_customPropertyGrid";
            this.m_customPropertyGrid.Size = new System.Drawing.Size(540, 321);
            this.m_customPropertyGrid.TabIndex = 0;
            // 
            // TileSheetPropertiesDialog
            // 
            this.AcceptButton = this.m_buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_buttonCancel;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.m_customTabControl);
            this.Controls.Add(this.m_buttonCancel);
            this.Controls.Add(this.m_buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TileSheetPropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tile Sheet Properties";
            this.Load += new System.EventHandler(this.TileSheetPropertiesDialog_Load);
            this.m_customTabControl.ResumeLayout(false);
            this.m_tabGeneral.ResumeLayout(false);
            this.m_tabGeneral.PerformLayout();
            this.m_tabAlignment.ResumeLayout(false);
            this.m_tabAlignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_textBoxTileHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_textBoxTileWidth)).EndInit();
            this.m_tabCustomProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_buttonOk;
        private System.Windows.Forms.Button m_buttonCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private TileMapEditor.Control.CustomTabControl m_customTabControl;
        private System.Windows.Forms.TabPage m_tabGeneral;
        private System.Windows.Forms.TabPage m_tabCustomProperties;
        private System.Windows.Forms.TextBox m_textBoxDescription;
        private System.Windows.Forms.Label m_labelDescription;
        private System.Windows.Forms.TextBox m_textBoxId;
        private System.Windows.Forms.Label m_labelId;
        private TileMapEditor.Control.CustomPropertyGrid m_customPropertyGrid;
        private System.Windows.Forms.TabPage m_tabAlignment;
        private System.Windows.Forms.Label m_labelImageSource;
        private System.Windows.Forms.Button m_buttonBrowse;
        private System.Windows.Forms.Label m_labelTileSize;
        private System.Windows.Forms.NumericUpDown m_textBoxTileHeight;
        private System.Windows.Forms.Label m_labelTileSizeBy;
        private System.Windows.Forms.NumericUpDown m_textBoxTileWidth;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel m_panelImage;
        private System.Windows.Forms.TextBox m_textBoxImageSource;
        private System.Windows.Forms.Label m_labelZoom;
        private System.Windows.Forms.TrackBar m_trackBar;
    }
}