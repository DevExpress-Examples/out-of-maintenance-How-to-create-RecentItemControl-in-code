Namespace DXApplication1
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
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.backstageViewControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
            Me.backstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.backstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.backstageViewControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewControl2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl2
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 1
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1015, 146)
            ' 
            ' backstageViewControl2
            ' 
            Me.backstageViewControl2.Controls.Add(Me.backstageViewClientControl1)
            Me.backstageViewControl2.Items.Add(Me.backstageViewTabItem2)
            Me.backstageViewControl2.Location = New System.Drawing.Point(71, 214)
            Me.backstageViewControl2.Name = "backstageViewControl2"
            Me.backstageViewControl2.OwnerControl = Me.ribbonControl1
            Me.backstageViewControl2.SelectedTab = Me.backstageViewTabItem2
            Me.backstageViewControl2.SelectedTabIndex = 0
            Me.backstageViewControl2.Size = New System.Drawing.Size(480, 150)
            Me.backstageViewControl2.TabIndex = 2
            ' 
            ' backstageViewClientControl1
            ' 
            Me.backstageViewClientControl1.Location = New System.Drawing.Point(173, 63)
            Me.backstageViewClientControl1.Name = "backstageViewClientControl1"
            Me.backstageViewClientControl1.Size = New System.Drawing.Size(306, 86)
            Me.backstageViewClientControl1.TabIndex = 1
            ' 
            ' backstageViewTabItem2
            ' 
            Me.backstageViewTabItem2.Caption = "Backstage Tab Item"
            Me.backstageViewTabItem2.ContentControl = Me.backstageViewClientControl1
            Me.backstageViewTabItem2.Name = "backstageViewTabItem2"
            Me.backstageViewTabItem2.Selected = True
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1015, 710)
            Me.Controls.Add(Me.backstageViewControl2)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.backstageViewControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewControl2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private backstageViewControl2 As DevExpress.XtraBars.Ribbon.BackstageViewControl
        Private backstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
        Private backstageViewTabItem2 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    End Class
End Namespace

