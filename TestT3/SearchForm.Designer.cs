namespace TestT3
{
    partial class SearchForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.bCatalog = new System.Windows.Forms.Button();
            this.catalogTextBox = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listFilesFound = new System.Windows.Forms.ListBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.totalFilesTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bTextSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 41);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(611, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // bCatalog
            // 
            this.bCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCatalog.Location = new System.Drawing.Point(710, 12);
            this.bCatalog.Name = "bCatalog";
            this.bCatalog.Size = new System.Drawing.Size(75, 20);
            this.bCatalog.TabIndex = 1;
            this.bCatalog.Text = "Catalog";
            this.bCatalog.UseVisualStyleBackColor = true;
            this.bCatalog.Click += new System.EventHandler(this.bCatalog_Click);
            // 
            // catalogTextBox
            // 
            this.catalogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catalogTextBox.Location = new System.Drawing.Point(12, 12);
            this.catalogTextBox.Name = "catalogTextBox";
            this.catalogTextBox.Size = new System.Drawing.Size(692, 20);
            this.catalogTextBox.TabIndex = 2;
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Location = new System.Drawing.Point(711, 41);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 19);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(405, 67);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(380, 316);
            this.textBox.TabIndex = 4;
            // 
            // listFilesFound
            // 
            this.listFilesFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listFilesFound.FormattingEnabled = true;
            this.listFilesFound.HorizontalScrollbar = true;
            this.listFilesFound.Items.AddRange(new object[] {
            " "});
            this.listFilesFound.Location = new System.Drawing.Point(12, 67);
            this.listFilesFound.Name = "listFilesFound";
            this.listFilesFound.Size = new System.Drawing.Size(378, 316);
            this.listFilesFound.Sorted = true;
            this.listFilesFound.TabIndex = 5;
            this.listFilesFound.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listFilesFound_MouseClick);
            // 
            // stateTextBox
            // 
            this.stateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.stateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateTextBox.Location = new System.Drawing.Point(12, 389);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(651, 13);
            this.stateTextBox.TabIndex = 6;
            // 
            // totalFilesTextBox
            // 
            this.totalFilesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalFilesTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.totalFilesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalFilesTextBox.Location = new System.Drawing.Point(669, 389);
            this.totalFilesTextBox.Name = "totalFilesTextBox";
            this.totalFilesTextBox.Size = new System.Drawing.Size(117, 13);
            this.totalFilesTextBox.TabIndex = 7;
            this.totalFilesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bTextSearch
            // 
            this.bTextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTextSearch.Location = new System.Drawing.Point(629, 41);
            this.bTextSearch.Name = "bTextSearch";
            this.bTextSearch.Size = new System.Drawing.Size(75, 20);
            this.bTextSearch.TabIndex = 9;
            this.bTextSearch.Text = "TextSearch";
            this.bTextSearch.UseVisualStyleBackColor = true;
            this.bTextSearch.Click += new System.EventHandler(this.bTextSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 410);
            this.Controls.Add(this.bTextSearch);
            this.Controls.Add(this.totalFilesTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.listFilesFound);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.catalogTextBox);
            this.Controls.Add(this.bCatalog);
            this.Controls.Add(this.searchTextBox);
            this.Name = "SearchForm";
            this.Text = "Title";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_Closing);

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button bCatalog;
        private System.Windows.Forms.TextBox catalogTextBox;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox listFilesFound;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox totalFilesTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bTextSearch;
    }
}

