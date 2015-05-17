namespace Calendar
{
    partial class Form1
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WeeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dailyView1 = new Controls.DailyView();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EventToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(607, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // EventToolStripMenuItem
            // 
            this.EventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.FilterByDateToolStripMenuItem});
            this.EventToolStripMenuItem.Name = "EventToolStripMenuItem";
            this.EventToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.EventToolStripMenuItem.Text = "Event";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.NewToolStripMenuItem.Text = "New";
            // 
            // FilterByDateToolStripMenuItem
            // 
            this.FilterByDateToolStripMenuItem.Name = "FilterByDateToolStripMenuItem";
            this.FilterByDateToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.FilterByDateToolStripMenuItem.Text = "Filter";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DailyToolStripMenuItem,
            this.WeeklyToolStripMenuItem,
            this.MonthlyToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMenuItem.Text = "View";
            // 
            // DailyToolStripMenuItem
            // 
            this.DailyToolStripMenuItem.Name = "DailyToolStripMenuItem";
            this.DailyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.DailyToolStripMenuItem.Text = "Daily";
            // 
            // WeeklyToolStripMenuItem
            // 
            this.WeeklyToolStripMenuItem.Name = "WeeklyToolStripMenuItem";
            this.WeeklyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.WeeklyToolStripMenuItem.Text = "Weekly";
            // 
            // MonthlyToolStripMenuItem
            // 
            this.MonthlyToolStripMenuItem.Name = "MonthlyToolStripMenuItem";
            this.MonthlyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.MonthlyToolStripMenuItem.Text = "Monthly";
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dailyView1
            // 
            this.dailyView1.Location = new System.Drawing.Point(12, 27);
            this.dailyView1.Name = "dailyView1";
            this.dailyView1.Size = new System.Drawing.Size(583, 388);
            this.dailyView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 418);
            this.Controls.Add(this.dailyView1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem EventToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FilterByDateToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DailyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem WeeklyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MonthlyToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private Controls.DailyView dailyView1;

        public enum VIEW
        {
            Daily,
            Weekly,
            Monthly
        }
    }
}

