Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace GetItemData
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.bbOpenText = New DevExpress.XtraBars.BarButtonItem()
			Me.bbOpenImage = New DevExpress.XtraBars.BarButtonItem()
			Me.bbExit = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.bbAcquire = New DevExpress.XtraBars.BarButtonItem()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barSubItem1, Me.bbOpenText, Me.bbOpenImage, Me.bbAcquire, Me.bbExit})
			Me.barManager1.MainMenu = Me.bar1
			Me.barManager1.MaxItemId = 5
			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 1"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1)})
			Me.bar1.OptionsBar.MultiLine = True
			Me.bar1.OptionsBar.UseWholeRow = True
			Me.bar1.Text = "Custom 1"
			' 
			' barSubItem1
			' 
			Me.barSubItem1.Caption = "&File"
			Me.barSubItem1.Id = 0
			Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbOpenText), New DevExpress.XtraBars.LinkPersistInfo(Me.bbOpenImage), New DevExpress.XtraBars.LinkPersistInfo(Me.bbExit, True)})
			Me.barSubItem1.Name = "barSubItem1"
'			Me.barSubItem1.GetItemData += New System.EventHandler(Me.barSubItem1_GetItemData);
			' 
			' bbOpenText
			' 
			Me.bbOpenText.Caption = "Open text"
			Me.bbOpenText.Id = 1
			Me.bbOpenText.Name = "bbOpenText"
			' 
			' bbOpenImage
			' 
			Me.bbOpenImage.Caption = "Open image"
			Me.bbOpenImage.Id = 2
			Me.bbOpenImage.Name = "bbOpenImage"
			' 
			' bbExit
			' 
			Me.bbExit.Caption = "Exit"
			Me.bbExit.Id = 4
			Me.bbExit.Name = "bbExit"
			' 
			' bbAcquire
			' 
			Me.bbAcquire.Caption = "Acquire image"
			Me.bbAcquire.Id = 3
			Me.bbAcquire.Name = "bbAcquire"
			' 
			' radioGroup1
			' 
			Me.radioGroup1.EditValue = 1
			Me.radioGroup1.Location = New System.Drawing.Point(140, 132)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Word processor"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Image editor")})
			Me.radioGroup1.Size = New System.Drawing.Size(113, 69)
			Me.radioGroup1.TabIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(299, 227)
			Me.Controls.Add(Me.radioGroup1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private WithEvents barSubItem1 As DevExpress.XtraBars.BarSubItem
		Private radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private bbOpenText As DevExpress.XtraBars.BarButtonItem
		Private bbOpenImage As DevExpress.XtraBars.BarButtonItem
		Private bbAcquire As DevExpress.XtraBars.BarButtonItem
		Private bbExit As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace
