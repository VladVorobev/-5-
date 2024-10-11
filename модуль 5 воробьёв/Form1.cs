using System;
using System.Windows.Forms;

namespace модуль_5_воробьёв
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawingAppMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму для рисования
            DrawingAppForm drawingForm = new DrawingAppForm();
            drawingForm.Show();
        }

        private void textEditorMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму для текстового редактора
            TextEditorForm textEditorForm = new TextEditorForm();
            textEditorForm.Show();
        }

        private void taskManagerMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму для управления задачами
            TaskManagerForm taskManagerForm = new TaskManagerForm();
            taskManagerForm.Show();
        }

        private void imageViewerMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму для просмотра изображений
            ImageViewerForm imageViewerForm = new ImageViewerForm();
            imageViewerForm.Show();
        }

        private void calculatorMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму для калькулятора
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }
    }
}
