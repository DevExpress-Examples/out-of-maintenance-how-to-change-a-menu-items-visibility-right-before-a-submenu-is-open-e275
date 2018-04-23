Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraBars

Namespace GetItemData
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub barSubItem1_GetItemData(ByVal sender As Object, ByVal e As System.EventArgs) Handles barSubItem1.GetItemData
			Select Case radioGroup1.SelectedIndex
				Case 0
					bbOpenText.Visibility = BarItemVisibility.Always
					bbOpenImage.Visibility = BarItemVisibility.OnlyInCustomizing
				Case 1
					bbOpenText.Visibility = BarItemVisibility.OnlyInCustomizing
					bbOpenImage.Visibility = BarItemVisibility.Always
			End Select
		End Sub
	End Class
End Namespace
