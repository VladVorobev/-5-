using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace модуль_5_воробьёв
{
    public partial class TaskManagerForm : Form
    {
        private const string TasksFilePath = "tasks.txt"; // Путь к файлу для хранения задач

        public TaskManagerForm()
        {
            InitializeComponent();
            LoadTasks(); // Загружаем задачи при инициализации формы
        }

        private void LoadTasks()
        {
            if (File.Exists(TasksFilePath))
            {
                var tasks = File.ReadAllLines(TasksFilePath);
                foreach (var task in tasks)
                {
                    listTasks.Items.Add(task);
                }
            }
        }

        private void SaveTasks()
        {
            var tasks = listTasks.Items.Cast<string>().ToArray();
            File.WriteAllLines(TasksFilePath, tasks);
        }

        private void TaskManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasks(); // Сохраняем задачи при закрытии формы
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text) && txtTask.Text != "Введите задачу...")
            {
                listTasks.Items.Add(txtTask.Text);
                txtTask.Clear(); // Очищаем текстовое поле
                txtTask.ForeColor = System.Drawing.Color.Gray; // Восстанавливаем цвет заполнителя
                txtTask.Text = "Введите задачу..."; // Возвращаем текст заполнителя
            }
            else
            {
                MessageBox.Show("Введите задачу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem != null)
            {
                listTasks.Items.Remove(listTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите задачу для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem != null)
            {
                string selectedTask = listTasks.SelectedItem.ToString();

                if (selectedTask.Contains("(выполнено)"))
                {
                    MessageBox.Show("Эта задача уже помечена как выполненная!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    listTasks.Items[listTasks.SelectedIndex] = $"{selectedTask} (выполнено)";
                }
            }
            else
            {
                MessageBox.Show("Выберите задачу для пометки как выполненную!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTask_Enter(object sender, EventArgs e)
        {
            if (txtTask.Text == "Введите задачу...")
            {
                txtTask.Clear();
                txtTask.ForeColor = System.Drawing.Color.Black; // Меняем цвет текста на черный
            }
        }

        private void txtTask_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                txtTask.ForeColor = System.Drawing.Color.Gray; // Устанавливаем цвет заполнителя
                txtTask.Text = "Введите задачу..."; // Устанавливаем текст заполнителя
            }
        }
    }
}