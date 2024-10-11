using System;
using System.Drawing;
using System.Windows.Forms;

namespace модуль_5_воробьёв
{
    public partial class ImageViewerForm : Form
    {
        private Image originalImage;

        public ImageViewerForm()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = Image.FromFile(openFileDialog.FileName);
                    pictureBox.Image = originalImage;
                    txtWidth.Text = originalImage.Width.ToString(); // Установка начальной ширины
                    txtHeight.Text = originalImage.Height.ToString(); // Установка начальной высоты
                }
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            // Проверка, было ли загружено изображение
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Пожалуйста, сначала откройте изображение.");
                return;
            }

            // Попытка преобразования введенных значений в числа
            if (int.TryParse(txtWidth.Text, out int newWidth) && int.TryParse(txtHeight.Text, out int newHeight))
            {
                // Установка нового размера изображения
                pictureBox.Image = new Bitmap(pictureBox.Image, new Size(newWidth, newHeight));
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные размеры.");
            }
        }
    }
}