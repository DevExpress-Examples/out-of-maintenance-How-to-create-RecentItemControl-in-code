Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication1
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            CreateRecentItem()
        End Sub

        Private Sub CreateRecentItem()
            Dim recentItemControl As New DevExpress.XtraBars.Ribbon.RecentItemControl()
            recentItemControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder 'to hide border
            recentItemControl.Dock = System.Windows.Forms.DockStyle.Fill
            recentItemControl.Name = "recentItemControl"
            recentItemControl.Title = "RecentControl Main Title"

            'create the mandatory right panel for tab items' content
            Dim recentStackPanelRight As New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            recentStackPanelRight.Name = "recentStackPanelRight"
            recentStackPanelRight.SelectedItem = Nothing
            recentItemControl.DefaultContentPanel = recentStackPanelRight

            Dim simpleButton As New SimpleButton()
            simpleButton.Dock = System.Windows.Forms.DockStyle.Fill
            simpleButton.Name = "simpleButton"
            simpleButton.Text = "Simple Button"

            'should be added to the RecentItemControl.Controls collection
            Dim recentControlItemControlContainer As New DevExpress.XtraBars.Ribbon.RecentControlItemControlContainer()
            recentControlItemControlContainer.Controls.Add(simpleButton)
            recentControlItemControlContainer.Name = "recentControlItemControlContainer"
            recentControlItemControlContainer.Size = New System.Drawing.Size(267, 40)
            recentItemControl.Controls.Add(recentControlItemControlContainer)

            'create container item, should have a parent RecentControlItemControlContainer
            Dim recentControlContainerItem As New DevExpress.XtraBars.Ribbon.RecentControlContainerItem()
            recentControlContainerItem.ClientHeight = 40
            recentControlContainerItem.ControlContainer = recentControlItemControlContainer
            recentControlContainerItem.Name = "recentControlContainerItem"

            Dim recentLabelItem As New DevExpress.XtraBars.Ribbon.RecentLabelItem()
            recentLabelItem.Caption = "RecentControl Label"
            recentLabelItem.Name = "recentLabelItem"

            'create the right panel for the tab item
            Dim recentStackPanell As New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            recentStackPanell.Caption = "RecentControl Stack Panel"
            'add items to the right panel
            recentStackPanell.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() { recentLabelItem})
            recentStackPanell.Name = "recentStackPanell"
            recentStackPanell.SelectedItem = Nothing

            'the element of the main panel
            Dim recentTabItem1 As New DevExpress.XtraBars.Ribbon.RecentTabItem()
            recentTabItem1.Caption = "RecentControl Tab Item"
            recentTabItem1.Name = "recentTabIteml"
            recentTabItem1.TabPanel = recentStackPanell

            'create the mandatory main panel
            Dim recentStackPanelMain As New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            'add elements to the main panel
            recentStackPanelMain.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() { recentTabItem1, recentControlContainerItem })
            recentStackPanelMain.Name = "mainPanel1"
            recentStackPanelMain.SelectedItem = recentTabItem1
            recentItemControl.MainPanel = recentStackPanelMain

            'set the RecentControl as a Backstage Tab Item's content
            backstageViewClientControl1.Controls.Add(recentItemControl)
            recentItemControl.SelectedTab = recentTabItem1



        End Sub

        Private Sub recentTabItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RecentItemEventArgs)

        End Sub

        Private Sub recentTabItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RecentItemEventArgs)

        End Sub
    End Class
End Namespace
