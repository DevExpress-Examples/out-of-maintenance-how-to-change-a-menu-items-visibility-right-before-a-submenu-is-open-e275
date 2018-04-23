using System;
using System.Collections.Generic;
using System.Text;

namespace GetItemData {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bbOpenText = new DevExpress.XtraBars.BarButtonItem();
            this.bbOpenImage = new DevExpress.XtraBars.BarButtonItem();
            this.bbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbAcquire = new DevExpress.XtraBars.BarButtonItem();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.bbOpenText,
            this.bbOpenImage,
            this.bbAcquire,
            this.bbExit});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "&File";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbOpenText),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbOpenImage),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbExit, true)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.GetItemData += new System.EventHandler(this.barSubItem1_GetItemData);
            // 
            // bbOpenText
            // 
            this.bbOpenText.Caption = "Open text";
            this.bbOpenText.Id = 1;
            this.bbOpenText.Name = "bbOpenText";
            // 
            // bbOpenImage
            // 
            this.bbOpenImage.Caption = "Open image";
            this.bbOpenImage.Id = 2;
            this.bbOpenImage.Name = "bbOpenImage";
            // 
            // bbExit
            // 
            this.bbExit.Caption = "Exit";
            this.bbExit.Id = 4;
            this.bbExit.Name = "bbExit";
            // 
            // bbAcquire
            // 
            this.bbAcquire.Caption = "Acquire image";
            this.bbAcquire.Id = 3;
            this.bbAcquire.Name = "bbAcquire";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = 1;
            this.radioGroup1.Location = new System.Drawing.Point(140, 132);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Word processor"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Image editor")});
            this.radioGroup1.Size = new System.Drawing.Size(113, 69);
            this.radioGroup1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 227);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraBars.BarButtonItem bbOpenText;
        private DevExpress.XtraBars.BarButtonItem bbOpenImage;
        private DevExpress.XtraBars.BarButtonItem bbAcquire;
        private DevExpress.XtraBars.BarButtonItem bbExit;
    }
}
