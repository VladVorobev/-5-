using System.Windows.Forms;

namespace модуль_5_воробьёв
{
    partial class TaskManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnMarkAsDone = new System.Windows.Forms.Button();
            this.listTasks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.ForeColor = System.Drawing.Color.Gray;
            this.txtTask.Location = new System.Drawing.Point(12, 12);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(560, 20);
            this.txtTask.TabIndex = 0;
            this.txtTask.Text = "Введите задачу...";
            this.txtTask.Enter += new System.EventHandler(this.txtTask_Enter);
            this.txtTask.Leave += new System.EventHandler(this.txtTask_Leave);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(578, 12);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 25);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTask.Location = new System.Drawing.Point(578, 43);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(100, 25);
            this.btnRemoveTask.TabIndex = 2;
            this.btnRemoveTask.Text = "Удалить";
            this.btnRemoveTask.UseVisualStyleBackColor = false;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
            this.btnMarkAsDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkAsDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAsDone.ForeColor = System.Drawing.Color.White;
            this.btnMarkAsDone.Location = new System.Drawing.Point(578, 74);
            this.btnMarkAsDone.Name = "btnMarkAsDone";
            this.btnMarkAsDone.Size = new System.Drawing.Size(100, 25);
            this.btnMarkAsDone.TabIndex = 3;
            this.btnMarkAsDone.Text = "Выполнено";
            this.btnMarkAsDone.UseVisualStyleBackColor = false;
            this.btnMarkAsDone.Click += new System.EventHandler(this.btnMarkAsDone_Click);
            // 
            // listTasks
            // 
            this.listTasks.FormattingEnabled = true;
            this.listTasks.Location = new System.Drawing.Point(12, 43);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(560, 394);
            this.listTasks.TabIndex = 4;
            // 
            // TaskManagerForm
            // 
            this.BackgroundImage = global::модуль_5_воробьёв.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.listTasks);
            this.Controls.Add(this.btnMarkAsDone);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtTask);
            this.Name = "TaskManagerForm";
            this.Text = "Управление задачами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskManagerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnMarkAsDone;
        private System.Windows.Forms.ListBox listTasks;
    }
}