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
        public Dictionary<String, FileSystemWatcher> FileWatchers = new Dictionary<string, FileSystemWatcher>();
        public Dictionary<String, int> IndexKeeper = new Dictionary<String, int>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public string[] WriteSafeReadAllLines(String path)
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
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                if (FileWatchers.ContainsKey(openFileDialog3.FileName))//If file selected is already open, switch to tab and do no more
                {
                    foreach (TabPage tab in TabControlParent.TabPages)
                    {
                        if (openFileDialog3.FileName == tab.Name)
                        {
                            TabControlParent.SelectedTab = tab;
                            return;
                        }
                    }
                }
                try
                {
                    //Add a filesystem watcher to public dictionary
                    var watch = new FileSystemWatcher();
                    watch.Path = Path.GetDirectoryName(openFileDialog3.FileName);
                    watch.Filter = Path.GetFileName(openFileDialog3.FileName);
                    watch.Changed += new FileSystemEventHandler(OnChanged);
                    watch.EnableRaisingEvents = true;
                    FileWatchers.Add(openFileDialog3.FileName, watch);
                    followTailCheckBox.Checked = true;

                    //Creates a new tab for a new log
                    TabPage tab = new TabPage() { Text = Path.GetFileName(openFileDialog3.FileName), Name = openFileDialog3.FileName , Tag="File"};
                    TabControlParent.TabPages.Add(tab);
                    TabControlParent.SelectedTab = tab;
                  tab.ToolTipText = "TabIndex = " + (TabControlParent.TabPages.IndexOf(tab).ToString());

                    Classes.ListViewNF ListViewText = new Classes.ListViewNF { Parent = tab, Dock = DockStyle.Fill, View = View.Details };
                    ListViewText.Columns.Add("Line", 50, HorizontalAlignment.Left);
                    ListViewText.Columns.Add("Text", 1000, HorizontalAlignment.Left);
                    ListViewText.FullRowSelect = true;
                    ListViewText.ContextMenuStrip = contextMenuStrip1;
                    ListViewText.MultiSelect = true;
                    ListViewText.Name = openFileDialog3.FileName + "-ListView";//used to find listview later   

                    //Write all lines to list view for tab
                    string[] lines = WriteSafeReadAllLines(openFileDialog3.FileName);
                    var ItemsCount = ListViewText.Items.Count;
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
                    }

                    FileLengthTB.Text = ListViewText.Items.Count.ToString() + " lines"; //Grabs the Number of lines in a file
                    long FileSizeValue = new FileInfo(openFileDialog3.FileName).Length; //Create the long for the file size value
                    FileSizeTB.Text = (FileSizeValue / 1024) + " KB"; //Convert File size from bytes to KB
                }
                catch (IOException ioe)
                {
                    MessageBox.Show(ioe.Message);
                }
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {            
            TabPage EventPage = null;
            foreach (TabPage tab in TabControlParent.TabPages)
            {
                if(tab.Tag.ToString() == "Folder")
                {
                    TabControl subTabControl = (SelectedFolder.Controls.Find("SubTabControl", true).FirstOrDefault()) as TabControl;
                    if (subTabControl != null)
                    {
                        foreach (TabPage subTab in subTabControl.TabPages)
                        {
                            if (e.FullPath == subTab.Name)
                            {
                                EventPage = tab;
                            }
                        }
                    }
                }
                if (e.FullPath == tab.Name)
                {
                    EventPage = tab;
                }
            }
            if (EventPage == null)
            {
                FileWatchers.Remove(e.FullPath);
                return;
            }

            if (EventPage.InvokeRequired)
            {
                EventPage.Invoke((MethodInvoker)delegate { OnChanged(source, e); });
            }
            else
            {
                try
                {
                    string[] lines = WriteSafeReadAllLines(e.FullPath);
                    var tmp = Controls.Find(e.FullPath + "-ListView", true);
                    ListView ListViewText = tmp[0] as ListView;
                    int itemIndex = ListViewText.TopItem.Index;
                    int prevIndex = itemIndex;
                    if (IndexKeeper.ContainsKey(e.FullPath))
                    {
                        prevIndex = IndexKeeper[e.FullPath];
                    }

                    if(itemIndex < prevIndex)
                    {

                    }
                    var ItemsCount = ListViewText.Items.Count;
                    if (ItemsCount == 0 || lines.Length < ItemsCount)
                    {
                        ListViewText.Items.Clear();
                        for (var linenum = 0; linenum < lines.Length; linenum++)
                        {
                            ListViewText.Items.Add((linenum + 1).ToString()).SubItems.Add(lines[linenum]);
                        }
                    }
                    else
                    {
                        for (var start = ItemsCount; start < lines.Length; start++)
                        {
                            ListViewText.Items.Add((start + 1).ToString()).SubItems.Add(lines[start]);
                        }
                    }

               //Grabs the Number of lines in a file
               FileLengthTB.Text = ListViewText.Items.Count.ToString() + " lines";
               //Create the long for the file size value
               long FileSizeValue = new FileInfo(e.FullPath).Length;
               //Convert File size from bytes to KB
               FileSizeTB.Text = (FileSizeValue / 1024) + " KB"; 

                    if (followTailCheckBox.Checked)
                    {
                        try
                        {
                            ListViewText.Items[ListViewText.Items.Count - 1].EnsureVisible();
                        }
                        catch (ArgumentOutOfRangeException IndErr)
                        {
                            Console.WriteLine(IndErr.Message);
                        }
                    }
                }
                catch (IOException IOex)
                {
                    Console.WriteLine(IOex.Message);
                }
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
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
         ListView CurrentListView = GetListViewByTab(TabControlParent.SelectedTab);

         if (SearchBox.Text == string.Empty)
         {
            CurrentListView.BackColor = Color.White;
            return;
         }

         if (SearchBox.Text != string.Empty)
         {
            if (CurrentListView != null)
            {
               foreach (ListViewItem item in CurrentListView.Items)
               {
                  if (SearchBox.Text.Length > 0)
                  {
                     if (item.SubItems[1].ToString().Contains(SearchBox.Text.ToLower()))
                     {
                        CurrentListView.TopItem = item;
                        item.BackColor = Color.LightSteelBlue;

                     }
                     else if (item.SubItems[0].ToString().Contains(SearchBox.Text.ToLower()))
                     {
                        CurrentListView.TopItem = item;
                        item.BackColor = Color.AliceBlue;

                     }
                     else
                     {
                        CurrentListView.BackColor = Color.White;
                        item.BackColor = Color.White;
                     }
                  }
               }
            }
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
         }
      }
   }
}
