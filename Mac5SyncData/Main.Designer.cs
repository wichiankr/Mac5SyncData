namespace Mac5SyncData
{
    partial class Main
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
            this.pnl_containner = new MetroFramework.Controls.MetroPanel();
            this.tabc_main = new MetroFramework.Controls.MetroTabControl();
            this.tab_syncdata = new MetroFramework.Controls.MetroTabPage();
            this.btn_loaddata = new MetroFramework.Controls.MetroButton();
            this.btn_syncdata = new MetroFramework.Controls.MetroButton();
            this.txt_progress = new MetroFramework.Controls.MetroTextBox();
            this.dpk_to = new MetroFramework.Controls.MetroDateTime();
            this.dpk_from = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tab_setting = new MetroFramework.Controls.MetroTabPage();
            this.btn_savedbpath = new MetroFramework.Controls.MetroButton();
            this.btn_browse = new MetroFramework.Controls.MetroButton();
            this.txt_dbpath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bgk_loaddata = new System.ComponentModel.BackgroundWorker();
            this.bgk_syncdata = new System.ComponentModel.BackgroundWorker();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pnl_containner.SuspendLayout();
            this.tabc_main.SuspendLayout();
            this.tab_syncdata.SuspendLayout();
            this.tab_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_containner
            // 
            this.pnl_containner.Controls.Add(this.tabc_main);
            this.pnl_containner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_containner.HorizontalScrollbarBarColor = true;
            this.pnl_containner.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_containner.HorizontalScrollbarSize = 10;
            this.pnl_containner.Location = new System.Drawing.Point(20, 60);
            this.pnl_containner.Name = "pnl_containner";
            this.pnl_containner.Size = new System.Drawing.Size(760, 370);
            this.pnl_containner.TabIndex = 0;
            this.pnl_containner.VerticalScrollbarBarColor = true;
            this.pnl_containner.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_containner.VerticalScrollbarSize = 10;
            // 
            // tabc_main
            // 
            this.tabc_main.Controls.Add(this.tab_syncdata);
            this.tabc_main.Controls.Add(this.tab_setting);
            this.tabc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabc_main.Location = new System.Drawing.Point(0, 0);
            this.tabc_main.Name = "tabc_main";
            this.tabc_main.SelectedIndex = 0;
            this.tabc_main.Size = new System.Drawing.Size(760, 370);
            this.tabc_main.TabIndex = 2;
            this.tabc_main.UseSelectable = true;
            // 
            // tab_syncdata
            // 
            this.tab_syncdata.Controls.Add(this.metroButton1);
            this.tab_syncdata.Controls.Add(this.btn_loaddata);
            this.tab_syncdata.Controls.Add(this.btn_syncdata);
            this.tab_syncdata.Controls.Add(this.txt_progress);
            this.tab_syncdata.Controls.Add(this.dpk_to);
            this.tab_syncdata.Controls.Add(this.dpk_from);
            this.tab_syncdata.Controls.Add(this.metroLabel3);
            this.tab_syncdata.Controls.Add(this.metroLabel2);
            this.tab_syncdata.HorizontalScrollbarBarColor = true;
            this.tab_syncdata.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_syncdata.HorizontalScrollbarSize = 10;
            this.tab_syncdata.Location = new System.Drawing.Point(4, 38);
            this.tab_syncdata.Name = "tab_syncdata";
            this.tab_syncdata.Size = new System.Drawing.Size(752, 328);
            this.tab_syncdata.TabIndex = 0;
            this.tab_syncdata.Text = "Sync Data";
            this.tab_syncdata.VerticalScrollbarBarColor = true;
            this.tab_syncdata.VerticalScrollbarHighlightOnWheel = false;
            this.tab_syncdata.VerticalScrollbarSize = 10;
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(563, 98);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(75, 23);
            this.btn_loaddata.TabIndex = 5;
            this.btn_loaddata.Text = "Load Data";
            this.btn_loaddata.UseSelectable = true;
            this.btn_loaddata.Click += new System.EventHandler(this.btn_loaddata_Click);
            // 
            // btn_syncdata
            // 
            this.btn_syncdata.Location = new System.Drawing.Point(644, 98);
            this.btn_syncdata.Name = "btn_syncdata";
            this.btn_syncdata.Size = new System.Drawing.Size(75, 23);
            this.btn_syncdata.TabIndex = 5;
            this.btn_syncdata.Text = "Start Sync";
            this.btn_syncdata.UseSelectable = true;
            this.btn_syncdata.Click += new System.EventHandler(this.btn_syncdata_Click);
            // 
            // txt_progress
            // 
            // 
            // 
            // 
            this.txt_progress.CustomButton.Image = null;
            this.txt_progress.CustomButton.Location = new System.Drawing.Point(518, 1);
            this.txt_progress.CustomButton.Name = "";
            this.txt_progress.CustomButton.Size = new System.Drawing.Size(163, 163);
            this.txt_progress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_progress.CustomButton.TabIndex = 1;
            this.txt_progress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_progress.CustomButton.UseSelectable = true;
            this.txt_progress.CustomButton.Visible = false;
            this.txt_progress.Lines = new string[0];
            this.txt_progress.Location = new System.Drawing.Point(37, 127);
            this.txt_progress.MaxLength = 32767;
            this.txt_progress.Multiline = true;
            this.txt_progress.Name = "txt_progress";
            this.txt_progress.PasswordChar = '\0';
            this.txt_progress.ReadOnly = true;
            this.txt_progress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_progress.SelectedText = "";
            this.txt_progress.SelectionLength = 0;
            this.txt_progress.SelectionStart = 0;
            this.txt_progress.ShortcutsEnabled = true;
            this.txt_progress.Size = new System.Drawing.Size(682, 165);
            this.txt_progress.TabIndex = 4;
            this.txt_progress.UseSelectable = true;
            this.txt_progress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_progress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dpk_to
            // 
            this.dpk_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_to.Location = new System.Drawing.Point(224, 39);
            this.dpk_to.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpk_to.Name = "dpk_to";
            this.dpk_to.Size = new System.Drawing.Size(111, 29);
            this.dpk_to.TabIndex = 3;
            // 
            // dpk_from
            // 
            this.dpk_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_from.Location = new System.Drawing.Point(37, 39);
            this.dpk_from.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpk_from.Name = "dpk_from";
            this.dpk_from.Size = new System.Drawing.Size(111, 29);
            this.dpk_from.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(224, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "To";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "From";
            // 
            // tab_setting
            // 
            this.tab_setting.Controls.Add(this.btn_savedbpath);
            this.tab_setting.Controls.Add(this.btn_browse);
            this.tab_setting.Controls.Add(this.txt_dbpath);
            this.tab_setting.Controls.Add(this.metroLabel1);
            this.tab_setting.HorizontalScrollbarBarColor = true;
            this.tab_setting.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_setting.HorizontalScrollbarSize = 10;
            this.tab_setting.Location = new System.Drawing.Point(4, 38);
            this.tab_setting.Name = "tab_setting";
            this.tab_setting.Size = new System.Drawing.Size(752, 328);
            this.tab_setting.TabIndex = 1;
            this.tab_setting.Text = "Setting";
            this.tab_setting.VerticalScrollbarBarColor = true;
            this.tab_setting.VerticalScrollbarHighlightOnWheel = false;
            this.tab_setting.VerticalScrollbarSize = 10;
            // 
            // btn_savedbpath
            // 
            this.btn_savedbpath.Location = new System.Drawing.Point(674, 302);
            this.btn_savedbpath.Name = "btn_savedbpath";
            this.btn_savedbpath.Size = new System.Drawing.Size(75, 23);
            this.btn_savedbpath.TabIndex = 5;
            this.btn_savedbpath.Text = "Save";
            this.btn_savedbpath.UseSelectable = true;
            this.btn_savedbpath.Click += new System.EventHandler(this.btn_savedbpath_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(674, 49);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 4;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseSelectable = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_dbpath
            // 
            // 
            // 
            // 
            this.txt_dbpath.CustomButton.Image = null;
            this.txt_dbpath.CustomButton.Location = new System.Drawing.Point(615, 1);
            this.txt_dbpath.CustomButton.Name = "";
            this.txt_dbpath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_dbpath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dbpath.CustomButton.TabIndex = 1;
            this.txt_dbpath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dbpath.CustomButton.UseSelectable = true;
            this.txt_dbpath.CustomButton.Visible = false;
            this.txt_dbpath.Lines = new string[0];
            this.txt_dbpath.Location = new System.Drawing.Point(31, 49);
            this.txt_dbpath.MaxLength = 32767;
            this.txt_dbpath.Name = "txt_dbpath";
            this.txt_dbpath.PasswordChar = '\0';
            this.txt_dbpath.ReadOnly = true;
            this.txt_dbpath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dbpath.SelectedText = "";
            this.txt_dbpath.SelectionLength = 0;
            this.txt_dbpath.SelectionStart = 0;
            this.txt_dbpath.ShortcutsEnabled = true;
            this.txt_dbpath.Size = new System.Drawing.Size(637, 23);
            this.txt_dbpath.TabIndex = 3;
            this.txt_dbpath.UseSelectable = true;
            this.txt_dbpath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dbpath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Database Access Path";
            // 
            // bgk_loaddata
            // 
            this.bgk_loaddata.WorkerReportsProgress = true;
            this.bgk_loaddata.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgk_loaddata_DoWork);
            this.bgk_loaddata.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgk_loaddata_ProgressChanged);
            this.bgk_loaddata.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgk_loaddata_RunWorkerCompleted);
            // 
            // bgk_syncdata
            // 
            this.bgk_syncdata.WorkerReportsProgress = true;
            this.bgk_syncdata.WorkerSupportsCancellation = true;
            this.bgk_syncdata.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgk_syncdata_DoWork);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(37, 98);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_containner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Sync Data From MAC5";
            this.pnl_containner.ResumeLayout(false);
            this.tabc_main.ResumeLayout(false);
            this.tab_syncdata.ResumeLayout(false);
            this.tab_syncdata.PerformLayout();
            this.tab_setting.ResumeLayout(false);
            this.tab_setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnl_containner;
        private MetroFramework.Controls.MetroTabControl tabc_main;
        private MetroFramework.Controls.MetroTabPage tab_syncdata;
        private MetroFramework.Controls.MetroTabPage tab_setting;
        private MetroFramework.Controls.MetroButton btn_savedbpath;
        private MetroFramework.Controls.MetroButton btn_browse;
        private MetroFramework.Controls.MetroTextBox txt_dbpath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_loaddata;
        private MetroFramework.Controls.MetroButton btn_syncdata;
        private MetroFramework.Controls.MetroTextBox txt_progress;
        private MetroFramework.Controls.MetroDateTime dpk_to;
        private MetroFramework.Controls.MetroDateTime dpk_from;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.ComponentModel.BackgroundWorker bgk_loaddata;
        private System.ComponentModel.BackgroundWorker bgk_syncdata;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

