﻿
namespace FilmsToWatch
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainMenuTabControl = new System.Windows.Forms.TabControl();
            this.filmsListTabPage = new System.Windows.Forms.TabPage();
            this.genreGraphTabPage = new System.Windows.Forms.TabPage();
            this.filmGenresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.releaseYearGraphTabPage = new System.Windows.Forms.TabPage();
            this.filmBudgetGraphTabPage = new System.Windows.Forms.TabPage();
            this.searchLabel = new System.Windows.Forms.Label();
            this.columnsComboBox = new System.Windows.Forms.ComboBox();
            this.columnLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.releaseYearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.budgetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trayMenuStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).BeginInit();
            this.mainMenuTabControl.SuspendLayout();
            this.filmsListTabPage.SuspendLayout();
            this.genreGraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmGenresChart)).BeginInit();
            this.releaseYearGraphTabPage.SuspendLayout();
            this.filmBudgetGraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.releaseYearChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetChart)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "FilmsToWatch is running in the background. To close - RMB click on the tray icon," +
    " exit.";
            this.trayIcon.BalloonTipTitle = "System Tray";
            this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "FilmsToWatch";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.settingsMenuItem,
            this.closeMenuItem});
            this.trayMenuStrip.Name = "TrayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(132, 76);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(131, 24);
            this.openMenuItem.Text = "Open";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(131, 24);
            this.settingsMenuItem.Text = "Settings";
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(131, 24);
            this.closeMenuItem.Text = "Exit";
            this.closeMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.accountToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1348, 28);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFilmToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.saveDataToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // addNewFilmToolStripMenuItem
            // 
            this.addNewFilmToolStripMenuItem.Name = "addNewFilmToolStripMenuItem";
            this.addNewFilmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewFilmToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.addNewFilmToolStripMenuItem.Text = "New Film";
            this.addNewFilmToolStripMenuItem.Click += new System.EventHandler(this.AddNewFilmToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.saveDataToolStripMenuItem.Text = "Save All Films";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.signInToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.signInToolStripMenuItem.Text = "Login";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // filmsDataGridView
            // 
            this.filmsDataGridView.AllowUserToAddRows = false;
            this.filmsDataGridView.AllowUserToResizeColumns = false;
            this.filmsDataGridView.AllowUserToResizeRows = false;
            this.filmsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filmsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.filmsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filmsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.filmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filmsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.filmsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.filmsDataGridView.Name = "filmsDataGridView";
            this.filmsDataGridView.RowHeadersWidth = 51;
            this.filmsDataGridView.RowTemplate.Height = 24;
            this.filmsDataGridView.Size = new System.Drawing.Size(1304, 584);
            this.filmsDataGridView.TabIndex = 2;
            this.filmsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.FilmsDataGridView_CellBeginEdit);
            this.filmsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmsDataGridView_CellEndEdit);
            this.filmsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.FilmsDataGridView_CellValidating);
            this.filmsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.FilmsDataGridView_UserDeletingRow);
            // 
            // mainMenuTabControl
            // 
            this.mainMenuTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuTabControl.Controls.Add(this.filmsListTabPage);
            this.mainMenuTabControl.Controls.Add(this.genreGraphTabPage);
            this.mainMenuTabControl.Controls.Add(this.releaseYearGraphTabPage);
            this.mainMenuTabControl.Controls.Add(this.filmBudgetGraphTabPage);
            this.mainMenuTabControl.Location = new System.Drawing.Point(12, 84);
            this.mainMenuTabControl.Name = "mainMenuTabControl";
            this.mainMenuTabControl.SelectedIndex = 0;
            this.mainMenuTabControl.Size = new System.Drawing.Size(1324, 625);
            this.mainMenuTabControl.TabIndex = 3;
            // 
            // filmsListTabPage
            // 
            this.filmsListTabPage.Controls.Add(this.filmsDataGridView);
            this.filmsListTabPage.Location = new System.Drawing.Point(4, 25);
            this.filmsListTabPage.Name = "filmsListTabPage";
            this.filmsListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filmsListTabPage.Size = new System.Drawing.Size(1316, 596);
            this.filmsListTabPage.TabIndex = 0;
            this.filmsListTabPage.Text = "List of films";
            this.filmsListTabPage.UseVisualStyleBackColor = true;
            // 
            // genreGraphTabPage
            // 
            this.genreGraphTabPage.Controls.Add(this.filmGenresChart);
            this.genreGraphTabPage.Location = new System.Drawing.Point(4, 25);
            this.genreGraphTabPage.Name = "genreGraphTabPage";
            this.genreGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.genreGraphTabPage.Size = new System.Drawing.Size(1316, 596);
            this.genreGraphTabPage.TabIndex = 1;
            this.genreGraphTabPage.Text = "Genre Graph";
            this.genreGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // filmGenresChart
            // 
            this.filmGenresChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.filmGenresChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.filmGenresChart.Legends.Add(legend1);
            this.filmGenresChart.Location = new System.Drawing.Point(6, 6);
            this.filmGenresChart.Name = "filmGenresChart";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.filmGenresChart.Series.Add(series1);
            this.filmGenresChart.Size = new System.Drawing.Size(1304, 584);
            this.filmGenresChart.TabIndex = 0;
            this.filmGenresChart.Text = "chart1";
            // 
            // releaseYearGraphTabPage
            // 
            this.releaseYearGraphTabPage.Controls.Add(this.releaseYearChart);
            this.releaseYearGraphTabPage.Location = new System.Drawing.Point(4, 25);
            this.releaseYearGraphTabPage.Name = "releaseYearGraphTabPage";
            this.releaseYearGraphTabPage.Size = new System.Drawing.Size(1316, 596);
            this.releaseYearGraphTabPage.TabIndex = 2;
            this.releaseYearGraphTabPage.Text = "Release Year Graph";
            this.releaseYearGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // filmBudgetGraphTabPage
            // 
            this.filmBudgetGraphTabPage.Controls.Add(this.budgetChart);
            this.filmBudgetGraphTabPage.Location = new System.Drawing.Point(4, 25);
            this.filmBudgetGraphTabPage.Name = "filmBudgetGraphTabPage";
            this.filmBudgetGraphTabPage.Size = new System.Drawing.Size(1316, 596);
            this.filmBudgetGraphTabPage.TabIndex = 3;
            this.filmBudgetGraphTabPage.Text = "Film Budget Graph";
            this.filmBudgetGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(281, 48);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(57, 17);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search:";
            // 
            // columnsComboBox
            // 
            this.columnsComboBox.FormattingEnabled = true;
            this.columnsComboBox.Location = new System.Drawing.Point(82, 45);
            this.columnsComboBox.Name = "columnsComboBox";
            this.columnsComboBox.Size = new System.Drawing.Size(181, 24);
            this.columnsComboBox.TabIndex = 5;
            // 
            // columnLabel
            // 
            this.columnLabel.AutoSize = true;
            this.columnLabel.Location = new System.Drawing.Point(17, 48);
            this.columnLabel.Name = "columnLabel";
            this.columnLabel.Size = new System.Drawing.Size(59, 17);
            this.columnLabel.TabIndex = 6;
            this.columnLabel.Text = "Column:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(344, 45);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(263, 22);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // releaseYearChart
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.releaseYearChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.releaseYearChart.Legends.Add(legend2);
            this.releaseYearChart.Location = new System.Drawing.Point(4, 3);
            this.releaseYearChart.Name = "releaseYearChart";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.releaseYearChart.Series.Add(series2);
            this.releaseYearChart.Size = new System.Drawing.Size(1309, 590);
            this.releaseYearChart.TabIndex = 0;
            this.releaseYearChart.Text = "chart1";
            // 
            // budgetChart
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.Name = "ChartArea1";
            this.budgetChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.budgetChart.Legends.Add(legend3);
            this.budgetChart.Location = new System.Drawing.Point(4, 3);
            this.budgetChart.Name = "budgetChart";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.budgetChart.Series.Add(series3);
            this.budgetChart.Size = new System.Drawing.Size(1309, 590);
            this.budgetChart.TabIndex = 0;
            this.budgetChart.Text = "chart1";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.columnLabel);
            this.Controls.Add(this.columnsComboBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.mainMenuTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmsToWatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.trayMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).EndInit();
            this.mainMenuTabControl.ResumeLayout(false);
            this.filmsListTabPage.ResumeLayout(false);
            this.genreGraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmGenresChart)).EndInit();
            this.releaseYearGraphTabPage.ResumeLayout(false);
            this.filmBudgetGraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.releaseYearChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.DataGridView filmsDataGridView;
        private System.Windows.Forms.TabControl mainMenuTabControl;
        private System.Windows.Forms.TabPage filmsListTabPage;
        private System.Windows.Forms.TabPage genreGraphTabPage;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox columnsComboBox;
        private System.Windows.Forms.Label columnLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart filmGenresChart;
        private System.Windows.Forms.TabPage releaseYearGraphTabPage;
        private System.Windows.Forms.TabPage filmBudgetGraphTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart releaseYearChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart budgetChart;
    }
}

