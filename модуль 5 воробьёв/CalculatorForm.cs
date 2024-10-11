using System;
using System.Windows.Forms;

namespace модуль_5_воробьёв
{
    public partial class CalculatorForm : Form
    {
        private double _firstNumber;
        private double _secondNumber;
        private string _operation;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text; // Добавляет нажатую цифру к тексту на дисплее
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Пытаемся распарсить введенное число с учетом запятой
            if (double.TryParse(txtDisplay.Text.Replace(',', '.'), out _firstNumber))
            {
                _operation = button.Text; // Сохраняет операцию
                txtDisplay.Clear(); // Очищает дисплей для второго числа
            }
            else
            {
                MessageBox.Show("Ошибка: Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Пытаемся распарсить второе число
            if (double.TryParse(txtDisplay.Text.Replace(',', '.'), out _secondNumber))
            {
                // Выполняет выбранную операцию
                switch (_operation)
                {
                    case "+":
                        txtDisplay.Text = (_firstNumber + _secondNumber).ToString().Replace('.', ',');
                        break;
                    case "-":
                        txtDisplay.Text = (_firstNumber - _secondNumber).ToString().Replace('.', ',');
                        break;
                    case "*":
                        txtDisplay.Text = (_firstNumber * _secondNumber).ToString().Replace('.', ',');
                        break;
                    case "/":
                        if (_secondNumber != 0)
                            txtDisplay.Text = (_firstNumber / _secondNumber).ToString().Replace('.', ',');
                        else
                            MessageBox.Show("Ошибка: Деление на ноль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "^": // Обработка операции возведения в степень
                        txtDisplay.Text = Math.Pow(_firstNumber, _secondNumber).ToString().Replace('.', ',');
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear(); // Очищает дисплей
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = string.Empty; // Сбрасывает операции
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            // Сохраняем текущее число как первое, чтобы выполнить операцию
            if (double.TryParse(txtDisplay.Text.Replace(',', '.'), out _firstNumber))
            {
                _operation = "^"; // Устанавливаем операцию как возведение в степень
                txtDisplay.Clear(); // Очищаем дисплей для второго числа
            }
            else
            {
                MessageBox.Show("Ошибка: Введите корректное число для возведения в степень!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text.Replace(',', '.'), out double value))
            {
                if (value < 0)
                {
                    MessageBox.Show("Ошибка: Невозможно вычислить квадратный корень из отрицательного числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double result = Math.Sqrt(value); // Вычисление квадратного корня
                txtDisplay.Text = result.ToString().Replace('.', ',');
            }
            else
            {
                MessageBox.Show("Ошибка: Введите корректное число для вычисления квадратного корня!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}