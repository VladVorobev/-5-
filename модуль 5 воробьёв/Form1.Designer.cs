namespace модуль_5_воробьёв
{
    partial class Form1
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drawingAppMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textEditorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageViewerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorMenuItem;
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drawingAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawingAppMenuItem,
            this.textEditorMenuItem,
            this.taskManagerMenuItem,
            this.imageViewerMenuItem,
            this.calculatorMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drawingAppMenuItem
            // 
            this.drawingAppMenuItem.Name = "drawingAppMenuItem";
            this.drawingAppMenuItem.Size = new System.Drawing.Size(175, 20);
            this.drawingAppMenuItem.Text = "Приложение для рисования";
            this.drawingAppMenuItem.Click += new System.EventHandler(this.drawingAppMenuItem_Click);
            // 
            // textEditorMenuItem
            // 
            this.textEditorMenuItem.Name = "textEditorMenuItem";
            this.textEditorMenuItem.Size = new System.Drawing.Size(130, 20);
            this.textEditorMenuItem.Text = "Текстовый редактор";
            this.textEditorMenuItem.Click += new System.EventHandler(this.textEditorMenuItem_Click);
            // 
            // taskManagerMenuItem
            // 
            this.taskManagerMenuItem.Name = "taskManagerMenuItem";
            this.taskManagerMenuItem.Size = new System.Drawing.Size(140, 20);
            this.taskManagerMenuItem.Text = "Управление задачами";
            this.taskManagerMenuItem.Click += new System.EventHandler(this.taskManagerMenuItem_Click);
            // 
            // imageViewerMenuItem
            // 
            this.imageViewerMenuItem.Name = "imageViewerMenuItem";
            this.imageViewerMenuItem.Size = new System.Drawing.Size(154, 20);
            this.imageViewerMenuItem.Text = "Просмотр изображений";
            this.imageViewerMenuItem.Click += new System.EventHandler(this.imageViewerMenuItem_Click);
            // 
            // calculatorMenuItem
            // 
            this.calculatorMenuItem.Name = "calculatorMenuItem";
            this.calculatorMenuItem.Size = new System.Drawing.Size(89, 20);
            this.calculatorMenuItem.Text = "Калькулятор";
            this.calculatorMenuItem.Click += new System.EventHandler(this.calculatorMenuItem_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = global::модуль_5_воробьёв.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
