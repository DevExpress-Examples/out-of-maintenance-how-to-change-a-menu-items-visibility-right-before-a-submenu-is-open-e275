using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraBars;

namespace GetItemData {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void barSubItem1_GetItemData(object sender, System.EventArgs e) {
            switch(radioGroup1.SelectedIndex) {
                case 0:
                    bbOpenText.Visibility = BarItemVisibility.Always;
                    bbOpenImage.Visibility = BarItemVisibility.OnlyInCustomizing;
                    break;
                case 1:
                    bbOpenText.Visibility = BarItemVisibility.OnlyInCustomizing;
                    bbOpenImage.Visibility = BarItemVisibility.Always;
                    break;
            }
        }
    }
}
