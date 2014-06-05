using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TestT3
{
    public partial class SearchForm : Form
    {
        int totalFiles = 0;
        int foundedFiles = 0;
        bool searchThreadWork = false;
        bool textSearchThreadWork = false;
        DateTime overallTime = new DateTime();
        delegate void SetTextReplacement(string text, string where);
        delegate void SetAfterMathReplacement();
        public SearchForm()
        {
            InitializeComponent();
            catalogTextBox.Enabled = false;
            catalogTextBox.Text = Properties.Settings.Default.catalogTextBox;
            searchTextBox.Text = Properties.Settings.Default.searchTextBox;
        }

        private void listFilesFound_MouseClick(object sender, EventArgs e)
        {
            if (listFilesFound.SelectedItem != null)
            {
                textBox.Text = File.ReadAllText(listFilesFound.SelectedItem.ToString());
            }
        }

        private void SearchForm_Closing(Object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.catalogTextBox = catalogTextBox.Text;
            Properties.Settings.Default.searchTextBox = searchTextBox.Text;
            Properties.Settings.Default.Save();
        }


        private void bCatalog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.SelectedPath = catalogTextBox.Text;

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                catalogTextBox.Text = DirDialog.SelectedPath;
            }
        }

        private void FilesSearch(string sDir, string searchType)
        {
            try
            {
                GetFiles(sDir, searchTextBox.Text, searchType);
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    GetFiles(d, searchTextBox.Text, searchType);
                    if (searchThreadWork || textSearchThreadWork) 
                    {
                        FilesSearch(d, searchType); 
                    }
                    else
                    {
                        InputText("Search", "search");
                        InputText("TextSearch", "textsearch"); 
                        return;
                    }
                }
            }
            catch (UnauthorizedAccessException) { }
            catch (Exception)
            {
                searchThreadWork = false;
            }

        }

        private void GetFiles(string dir, string request, string type)
        {

            if (type == "searchfile")
            {
                try
                {
                    foreach (string f in Directory.EnumerateFiles(dir))
                    {
                        InputText(f, "state");
                        totalFiles += 1;
                        if (Path.GetFileName(f).IndexOf(request, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            InputText(f, "list");
                            foundedFiles += 1;
                        }
                        InputText(foundedFiles + " of " + totalFiles + " in " + (DateTime.Now - overallTime), "total");
                    }
                }
                catch (UnauthorizedAccessException)
                { }
            }
            else
            {
                try
                {
                    foreach (string f in Directory.EnumerateFiles(dir))
                    {
                        InputText(f, "state");
                        totalFiles += 1;
                        try
                        {
                            if (File.ReadAllText(f).IndexOf(request, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                InputText(f, "list");
                                foundedFiles += 1;
                            }
                        }
                        catch (IOException)
                        {
                        }
                        InputText(foundedFiles + " of " + totalFiles + " in " + (DateTime.Now - overallTime), "total");
                    }
                }
                catch (UnauthorizedAccessException ex)
                { }
            }

        }
        
        private void AfterMath(Task[] tasks)
        {
            InputText("TextSearch", "textsearch");
            InputText("Search", "search");
            InputAfterMath();
        }
        private void InputAfterMath()
        {
            if (this.InvokeRequired)
            {
                SetAfterMathReplacement d = new SetAfterMathReplacement(InputAfterMath);
                this.Invoke(d, new object[] { });
            }
            else
            {
                textSearchThreadWork = false;
                searchThreadWork = false;
                bSearch.Enabled = true;
                bTextSearch.Enabled = true;
                searchTextBox.Enabled = true;
                bCatalog.Enabled = true;
            }
        }
        private void InputText(string text, string where)
        {
            if (this.InvokeRequired)
            {
                SetTextReplacement d = new SetTextReplacement(InputText);
                this.Invoke(d, new object[] { text, where });
            }
            else
            {
                switch (where)
                {
                    case "state":
                        this.stateTextBox.Text = text;
                        break;
                    case "list":
                        this.listFilesFound.Items.Add(text);
                        break;
                    case "total":
                        this.totalFilesTextBox.Text = text;
                        break;
                    case "search":
                        this.bSearch.Text = text;
                        break;
                    case "textsearch":
                        this.bTextSearch.Text = text;
                        break;
                }
            }
        }
        private void bTextSearch_Click(object sender, EventArgs e)
        {
            if (textSearchThreadWork)
            {
                textSearchThreadWork = false;
            }
            else
            {
                overallTime = DateTime.Now;
                totalFiles = 0;
                foundedFiles = 0;
                totalFilesTextBox.Text = "";
                if (searchTextBox.Text == "")
                {
                    MessageBox.Show("Nothing to search");
                    return;
                }
                if (catalogTextBox.Text == "")
                {
                    catalogTextBox.Text = "C:\\";
                }
                textSearchThreadWork = true;
                listFilesFound.Items.Clear();
                searchTextBox.Enabled = false;
                bCatalog.Enabled = false;
                bSearch.Enabled = false;
                bTextSearch.Text = "Stop";
                Application.DoEvents();
                Task task = new Task(() => FilesSearch(catalogTextBox.Text, "searchtext"));
                task.Start();
                var allTasks = new[] { task };
                Task.Factory.ContinueWhenAll(allTasks, AfterMath);
            }
          
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            if (searchThreadWork)
            {
                searchThreadWork = false;
            }
            else
            {
                overallTime = DateTime.Now;
                totalFiles = 0;
                foundedFiles = 0;
                totalFilesTextBox.Text = "";
                if (searchTextBox.Text == "")
                {
                    MessageBox.Show("Nothing to search");
                    return;
                }
                if (catalogTextBox.Text == "")
                {
                    catalogTextBox.Text = "C:\\";
                }

                listFilesFound.Items.Clear();
                searchTextBox.Enabled = false;
                bTextSearch.Enabled = false;
                bCatalog.Enabled = false;
                bSearch.Text = "Stop";
                Application.DoEvents();
                Task task = new Task(() => FilesSearch(catalogTextBox.Text, "searchfile"));
                searchThreadWork = true;
                task.Start();
                var allTasks = new[] { task};
                Task.Factory.ContinueWhenAll(allTasks, AfterMath);
            }
        }
    }
}
