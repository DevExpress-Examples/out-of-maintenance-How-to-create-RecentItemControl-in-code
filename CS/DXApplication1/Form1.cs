using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            CreateRecentItem();
        }

        private void CreateRecentItem()
        {
            DevExpress.XtraBars.Ribbon.RecentItemControl recentItemControl = new DevExpress.XtraBars.Ribbon.RecentItemControl();
            recentItemControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder; //to hide border
            recentItemControl.Dock = System.Windows.Forms.DockStyle.Fill;
            recentItemControl.Name = "recentItemControl";
            recentItemControl.Title = "RecentControl Main Title";

            //create the mandatory right panel for tab items' content
            DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanelRight = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
            recentStackPanelRight.Name = "recentStackPanelRight";
            recentStackPanelRight.SelectedItem = null;
            recentItemControl.DefaultContentPanel = recentStackPanelRight;

            SimpleButton simpleButton = new SimpleButton();
            simpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton.Name = "simpleButton";
            simpleButton.Text = "Simple Button";

            //should be added to the RecentItemControl.Controls collection
            DevExpress.XtraBars.Ribbon.RecentControlItemControlContainer recentControlItemControlContainer = new DevExpress.XtraBars.Ribbon.RecentControlItemControlContainer();
            recentControlItemControlContainer.Controls.Add(simpleButton);
            recentControlItemControlContainer.Name = "recentControlItemControlContainer";
            recentControlItemControlContainer.Size = new System.Drawing.Size(267, 40);
            recentItemControl.Controls.Add(recentControlItemControlContainer);

            //create container item, should have a parent RecentControlItemControlContainer
            DevExpress.XtraBars.Ribbon.RecentControlContainerItem recentControlContainerItem = new DevExpress.XtraBars.Ribbon.RecentControlContainerItem();
            recentControlContainerItem.ClientHeight = 40;
            recentControlContainerItem.ControlContainer = recentControlItemControlContainer;
            recentControlContainerItem.Name = "recentControlContainerItem";

            DevExpress.XtraBars.Ribbon.RecentLabelItem recentLabelItem = new DevExpress.XtraBars.Ribbon.RecentLabelItem();
            recentLabelItem.Caption = "RecentControl Label";
            recentLabelItem.Name = "recentLabelItem";

            //create the right panel for the tab item
            DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanell = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
            recentStackPanell.Caption = "RecentControl Stack Panel";
            //add items to the right panel
            recentStackPanell.Items.AddRange(new DevExpress.XtraBars.Ribbon.RecentItemBase[] {
            recentLabelItem});
            recentStackPanell.Name = "recentStackPanell";
            recentStackPanell.SelectedItem = null;

            //the element of the main panel
            DevExpress.XtraBars.Ribbon.RecentTabItem recentTabItem1 = new DevExpress.XtraBars.Ribbon.RecentTabItem();
            recentTabItem1.Caption = "RecentControl Tab Item";
            recentTabItem1.Name = "recentTabIteml";
            recentTabItem1.TabPanel = recentStackPanell;

            //create the mandatory main panel
            DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanelMain = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
            //add elements to the main panel
            recentStackPanelMain.Items.AddRange(new DevExpress.XtraBars.Ribbon.RecentItemBase[] {
             recentTabItem1,
             recentControlContainerItem
            });
            recentStackPanelMain.Name = "mainPanel1";
            recentStackPanelMain.SelectedItem = recentTabItem1;
            recentItemControl.MainPanel = recentStackPanelMain;

            //set the RecentControl as a Backstage Tab Item's content
            backstageViewClientControl1.Controls.Add(recentItemControl);
            recentItemControl.SelectedTab = recentTabItem1;



        }

        private void recentTabItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {

        }

        private void recentTabItem2_ItemClick(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {

        }
    }
}
