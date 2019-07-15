namespace MusikiPlayer
{
    partial class MusikiPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.libraryTab = new System.Windows.Forms.TabPage();
            this.explorerTab = new System.Windows.Forms.TabPage();
            this.addToLibraryButton = new System.Windows.Forms.Button();
            this.searchResultDetailTextBox = new System.Windows.Forms.RichTextBox();
            this.searchResultsGrid = new System.Windows.Forms.DataGridView();
            this.selectResultButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.explorerSearchButton = new System.Windows.Forms.Button();
            this.explorerSearchTextBox = new System.Windows.Forms.TextBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.logsBox = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.thumbnailDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.explorerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.libraryTab);
            this.tabControl1.Controls.Add(this.explorerTab);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 629);
            this.tabControl1.TabIndex = 1;
            // 
            // libraryTab
            // 
            this.libraryTab.Location = new System.Drawing.Point(4, 22);
            this.libraryTab.Name = "libraryTab";
            this.libraryTab.Padding = new System.Windows.Forms.Padding(3);
            this.libraryTab.Size = new System.Drawing.Size(975, 603);
            this.libraryTab.TabIndex = 0;
            this.libraryTab.Text = "Library";
            this.libraryTab.UseVisualStyleBackColor = true;
            // 
            // explorerTab
            // 
            this.explorerTab.Controls.Add(this.addToLibraryButton);
            this.explorerTab.Controls.Add(this.searchResultDetailTextBox);
            this.explorerTab.Controls.Add(this.searchResultsGrid);
            this.explorerTab.Controls.Add(this.explorerSearchButton);
            this.explorerTab.Controls.Add(this.explorerSearchTextBox);
            this.explorerTab.Location = new System.Drawing.Point(4, 22);
            this.explorerTab.Name = "explorerTab";
            this.explorerTab.Padding = new System.Windows.Forms.Padding(3);
            this.explorerTab.Size = new System.Drawing.Size(975, 603);
            this.explorerTab.TabIndex = 1;
            this.explorerTab.Text = "Explorer";
            this.explorerTab.UseVisualStyleBackColor = true;
            // 
            // addToLibraryButton
            // 
            this.addToLibraryButton.Location = new System.Drawing.Point(711, 204);
            this.addToLibraryButton.Name = "addToLibraryButton";
            this.addToLibraryButton.Size = new System.Drawing.Size(258, 23);
            this.addToLibraryButton.TabIndex = 4;
            this.addToLibraryButton.Text = "Add To Library";
            this.addToLibraryButton.UseVisualStyleBackColor = true;
            this.addToLibraryButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // searchResultDetailTextBox
            // 
            this.searchResultDetailTextBox.Location = new System.Drawing.Point(710, 34);
            this.searchResultDetailTextBox.Name = "searchResultDetailTextBox";
            this.searchResultDetailTextBox.Size = new System.Drawing.Size(259, 163);
            this.searchResultDetailTextBox.TabIndex = 3;
            this.searchResultDetailTextBox.Text = "";
            // 
            // searchResultsGrid
            // 
            this.searchResultsGrid.AllowUserToAddRows = false;
            this.searchResultsGrid.AllowUserToDeleteRows = false;
            this.searchResultsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultsGrid.AutoGenerateColumns = false;
            this.searchResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.searchResultsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thumbnailDataGridViewImageColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.selectResultButton});
            this.searchResultsGrid.DataSource = this.videoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchResultsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.searchResultsGrid.Location = new System.Drawing.Point(7, 34);
            this.searchResultsGrid.MultiSelect = false;
            this.searchResultsGrid.Name = "searchResultsGrid";
            this.searchResultsGrid.Size = new System.Drawing.Size(697, 563);
            this.searchResultsGrid.TabIndex = 2;
            this.searchResultsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResults_CellClick);
            // 
            // selectResultButton
            // 
            this.selectResultButton.HeaderText = "Download";
            this.selectResultButton.Name = "selectResultButton";
            this.selectResultButton.Text = "Select";
            // 
            // explorerSearchButton
            // 
            this.explorerSearchButton.Location = new System.Drawing.Point(418, 7);
            this.explorerSearchButton.Name = "explorerSearchButton";
            this.explorerSearchButton.Size = new System.Drawing.Size(127, 20);
            this.explorerSearchButton.TabIndex = 1;
            this.explorerSearchButton.Text = "Search";
            this.explorerSearchButton.UseVisualStyleBackColor = true;
            this.explorerSearchButton.Click += new System.EventHandler(this.ExplorerSearchButton_Click);
            // 
            // explorerSearchTextBox
            // 
            this.explorerSearchTextBox.Location = new System.Drawing.Point(7, 7);
            this.explorerSearchTextBox.Name = "explorerSearchTextBox";
            this.explorerSearchTextBox.Size = new System.Drawing.Size(405, 20);
            this.explorerSearchTextBox.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(975, 603);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // logsBox
            // 
            this.logsBox.FormattingEnabled = true;
            this.logsBox.Location = new System.Drawing.Point(13, 648);
            this.logsBox.Name = "logsBox";
            this.logsBox.Size = new System.Drawing.Size(905, 69);
            this.logsBox.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // thumbnailDataGridViewImageColumn
            // 
            this.thumbnailDataGridViewImageColumn.DataPropertyName = "Thumbnail";
            this.thumbnailDataGridViewImageColumn.HeaderText = "Thumbnail";
            this.thumbnailDataGridViewImageColumn.Name = "thumbnailDataGridViewImageColumn";
            this.thumbnailDataGridViewImageColumn.ReadOnly = true;
            this.thumbnailDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.thumbnailDataGridViewImageColumn.Width = 62;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // videoBindingSource
            // 
            this.videoBindingSource.DataSource = typeof(Video);
            // 
            // MusikiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.logsBox);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MusikiPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Musiki Player";
            this.tabControl1.ResumeLayout(false);
            this.explorerTab.ResumeLayout(false);
            this.explorerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage libraryTab;
        private System.Windows.Forms.TabPage explorerTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button explorerSearchButton;
        private System.Windows.Forms.DataGridView searchResultsGrid;
        public System.Windows.Forms.TextBox explorerSearchTextBox;
        private System.Windows.Forms.BindingSource videoBindingSource;
        public System.Windows.Forms.ListBox logsBox;
        public System.Windows.Forms.RichTextBox searchResultDetailTextBox;
        private System.Windows.Forms.Button addToLibraryButton;
        private System.Windows.Forms.DataGridViewImageColumn thumbnailDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn selectResultButton;
        private System.Windows.Forms.Timer timer;
    }
}

