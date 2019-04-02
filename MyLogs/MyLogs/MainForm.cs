﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogs
{
    public partial class MainForm : Form
    {
        public Dictionary<String, int> IndexKeeper = new Dictionary<String, int>();


        public MainForm()
        {
            InitializeComponent();
        }

        public string[] WriteSafeReadAllLines(string path)
        {
            using (var csv = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(csv))
            {
                List<string> file = new List<string>();
                while (!sr.EndOfStream)
                {
                    file.Add(sr.ReadLine());
                }

                return file.ToArray();
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (TabPage tab in TabControlParent.TabPages)
                {
                    if (openFileDialog.FileName == tab.Name)
                    {
                        TabControlParent.SelectedTab = tab;
                        return;
                    }
                }
                CreateParentTabPageAtIndex(path: openFileDialog.FileName, index: null);
            }
        }

        private void CreateParentTabPageAtIndex(string path, int? index, string parentName = null, string text = null)
        {
            try
            {
                int tabPosition = index ?? CountParentTabs() + 1;
                //Creates a new tab for a new log
                Classes.LogTabPage tab = new Classes.LogTabPage() { Text = text ?? Path.GetFileName(path), Name = path, Tag = "File", TailFollowed = true, PositionIndex = tabPosition };
                tab.SetWatcher(path);
                TabControlParent.TabPages.Add(tab);
                TabControlParent.SelectedTab = tab;

                Classes.ListViewNF ListViewText = new Classes.ListViewNF { Parent = tab, Dock = DockStyle.Fill, View = View.Details };

                ListViewText.Columns.Add("Line", 50, HorizontalAlignment.Left);
                ListViewText.Columns.Add("Text", 1000, HorizontalAlignment.Left);
                ListViewText.FullRowSelect = true;
                ListViewText.ContextMenuStrip = contextMenuStrip1;
                ListViewText.MultiSelect = true;
                ListViewText.Name = "ListViewText";//used to find listview later
                //ListViewText.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(LV_RetrieveVirtualItem);
                //ListViewText.CacheVirtualItems += new CacheVirtualItemsEventHandler(LV_CacheVirtualItem);
                
                SelectedTabPage = tab;
                TabViewChange(tab);
                //FileSystemEventArgs args = new FileSystemEventArgs(Directory = Path.GetDirectoryName(tab.Name),Path = tab.Name, Name = tab.Name);
                tab.InitialLoad(tab.Name);
               // string[] lines = WriteSafeReadAllLines(path);
                //ListViewText.VirtualListSize = lines.Length;
                //ListViewText.VirtualMode = true;
                //Write all lines to list view for tab
               

               /* var ItemsCount = ListViewText.Items.Count;
                if (ItemsCount == 0 || lines.Length < ItemsCount)
                {
                   
                    ListViewText.Items.Clear();
                    for (var linenum = 0; linenum < lines.Length; linenum++)
                    {
                        ListViewText.Items.Add((linenum + 1).ToString()).SubItems.Add(lines[linenum]);
                    }
                }
                try
                {
                    ListViewText.Items[ListViewText.Items.Count - 1].EnsureVisible();
                }
                catch (ArgumentOutOfRangeException IndErr)
                {
                    Console.WriteLine(IndErr.Message);
                }*/

                FileLengthTB.Text = ListViewText.Items.Count.ToString() + " lines"; //Grabs the Number of lines in a file
                long FileSizeValue = new FileInfo(path).Length; //Create the long for the file size value
                FileSizeTB.Text = (FileSizeValue / 1024) + " KB"; //Convert File size from bytes to KB

                if (!String.IsNullOrWhiteSpace(parentName))
                {
                    TabPage folder = GetFolderByName(parentName);
                    TabControl subTabPageControl = folder.Controls.Find("SubTabControl", true).FirstOrDefault() as TabControl;
                    subTabPageControl.TabPages.Add(tab);
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }

        }

        private void LV_CacheVirtualItem(object sender, CacheVirtualItemsEventArgs e)
        {
            Classes.ListViewNF listView = sender as Classes.ListViewNF;
            if (listView.cache != null && e.StartIndex >= listView.firstItem && e.EndIndex <= listView.firstItem + listView.cache.Length)
            {
                //Dont rebuild cache
                return;
            }
            if( e.EndIndex > listView.lastItem)
            {
                listView.firstItem = e.StartIndex;
                for(var i = listView.cache.Length; i < e.EndIndex; i++)
                {

                }
            }
        }

        private void LV_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            Classes.ListViewNF listView = sender as Classes.ListViewNF;
            // var acc = listView.Items[0];
            // hand out new item
            e.Item = new ListViewItem((e.ItemIndex + 1).ToString());
            Classes.LogTabPage tab = (sender as Classes.ListViewNF).Parent as Classes.LogTabPage;
            string path = tab.Name;
            string line = WriteSafeGetLine(path, e.ItemIndex);
            e.Item.SubItems.Add(line);

        }

        public string WriteSafeGetLine(string path, int index)
        {
            using (var csv = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(csv))
            {
                List<string> file = new List<string>();
                while (!sr.EndOfStream)
                {
                    file.Add(sr.ReadLine());
                }

                return file.ToArray()[index];
            }
        }

        //Copy lines from Logs
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Copy")
            {
                copySelectedItemsToClipboard();
            }

        }

        //Copy lines from Logs
        public void copySelectedItemsToClipboard()
        {
            ListView CurrentListView = GetListViewByTab(TabControlParent.SelectedTab);
            ListView.SelectedListViewItemCollection selectedItems = CurrentListView.SelectedItems;
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in selectedItems)
            {
                ListViewItem l = item as ListViewItem;
                if (l != null)
                    foreach (ListViewItem.ListViewSubItem sub in l.SubItems)
                        sb.Append(sub.Text + "\t");
                sb.AppendLine();
            }
            Clipboard.SetDataObject(sb.ToString());
        }

        /**********************************
         * Handles the search functions
         * ********************************/
        private void SearchBox_EnterDown(object sender, KeyEventArgs e)
        {
            ListView CurrentListView = GetListViewByTab(TabControlParent.SelectedTab);

            if (e.KeyCode == Keys.Enter)
            {

                if (SearchBox.Text == string.Empty)
                {
                    CurrentListView.BackColor = Color.White;
                    foreach (ListViewItem items in CurrentListView.Items)
                    {
                        items.BackColor = SystemColors.Window;
                        items.ForeColor = SystemColors.WindowText;
                    }
                }

                if (CurrentListView.Items.Count > 0)
                {
                    // Focus the list view
                    //CurrentListView.Focus();
                    // Clear currently selected items
                    CurrentListView.SelectedItems.Clear();
                    int i = 0;
                    ListViewItem found;
                    do
                    {
                        // Recursively find all instances of the given text, starting from zero
                        found = CurrentListView.FindItemWithText(SearchBox.Text.ToString().ToLower(), true, i, true);
                        if (found != null)
                        {
                            // Select found item
                            found.Selected = true;
                            found.BackColor = Color.SteelBlue;
                            // Next search starts from the next element in the list view
                            i = found.Index + 1;
                        }
                        else
                        {
                            // Otherwise, stop
                            i = CurrentListView.Items.Count;
                        }
                    } while (i < CurrentListView.Items.Count);
                }
                // If nothing found, show message
                if (CurrentListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Value could not be found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                /*if (SearchBox.Text != string.Empty)
                {
                   if (CurrentListView != null)
                   {
                      foreach (ListViewItem item in CurrentListView.Items)
                      {
                         if (SearchBox.Text.Length > 0)
                         {
                            if (item.ToString().Contains(SearchBox.Text.ToString().ToLower()))
                            {
                               item.BackColor = Color.LightSteelBlue;
                            }
                            else if (item.SubItems[1].ToString().Contains(SearchBox.Text.ToString().ToLower()))
                            {
                               item.BackColor = Color.DodgerBlue;
                            }
                            else
                            {
                               CurrentListView.BackColor = Color.White;
                               item.BackColor = Color.White;
                            }
                         }
                      }
                   }
                }*/
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        /************************
         * Handle Search box Ghost Text
         **************************/
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Search")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = Color.Black;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "Search";
                SearchBox.ForeColor = Color.Gray;
                ListView CurrentListView = GetListViewByTab(TabControlParent.SelectedTab);
                CurrentListView.BackColor = Color.White;
                foreach (ListViewItem items in CurrentListView.Items)
                {
                    items.BackColor = SystemColors.Window;
                    items.ForeColor = SystemColors.WindowText;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentSession();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadLastSessionMenuItem_Click(object sender, EventArgs e)
        {
            LoadLastSession();
        }

        private void followTailCheckBox_Click(object sender, EventArgs e)
        {
            if (followTailCheckBox.Checked)
            {
                if ((TabControlParent.SelectedTab as Classes.LogTabPage).IsFolder)
                {
                    TabControl subTabControl = (TabControlParent.SelectedTab as Classes.LogTabPage).Controls.Find("SubTabControl", true)[0] as TabControl;
                    (subTabControl.SelectedTab as Classes.LogTabPage).TailFollowed = true;
                }
                else
                {
                    (TabControlParent.SelectedTab as Classes.LogTabPage).TailFollowed = true;
                }
            }
            else
            {
                if ((TabControlParent.SelectedTab as Classes.LogTabPage).IsFolder)
                {
                    TabControl subTabControl = (TabControlParent.SelectedTab as Classes.LogTabPage).Controls.Find("SubTabControl", true)[0] as TabControl;
                    (subTabControl.SelectedTab as Classes.LogTabPage).TailFollowed = false;
                    (subTabControl.SelectedTab as Classes.LogTabPage).SetLastVisibleItem();
                }
                else
                {
                    (TabControlParent.SelectedTab as Classes.LogTabPage).TailFollowed = false;
                    (TabControlParent.SelectedTab as Classes.LogTabPage).SetLastVisibleItem();
                }
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedTab = (sender as TabControl).SelectedTab as Classes.LogTabPage;
                if (selectedTab.IsFolder && (selectedTab.Controls.Find("SubTabControl", true)[0] as TabControl).TabCount > 0)
                {
                    selectedTab = (selectedTab.Controls.Find("SubTabControl", true)[0] as TabControl).SelectedTab as Classes.LogTabPage;
                }
                TabViewChange(selectedTab);
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine(err.Message);
            }
        }


    }
}
