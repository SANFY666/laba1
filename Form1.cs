using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // на старті вимикаємо кнопку
            btnStart1.Enabled = false;
            btnClear1.Enabled = false;
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            // якщо поле не пусте то кнопка активна 
            btnStart1.Enabled = !string.IsNullOrWhiteSpace(txtX.Text);
            btnClear1.Enabled = !string.IsNullOrWhiteSpace(txtX.Text);
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            // замінюємо кому на крапку
            string text = txtX.Text.Replace(',', '.');

            if (double.TryParse(text, out double x))
            {
                double numerator = Math.Log(Math.Abs(Math.Cos(x)));
                double denominator = Math.Log(1 + x * x);

                if (denominator == 0)
                {
                    lblResult.Text = "Ділення на 0!";
                    return;
                }

                double result = numerator / denominator;
                lblResult.Text += $"\n x = {x} | Result: {result:F4}";  //з нового рядка результат і до 4 числа скорочення
            }
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter && btnStart1.Enabled) btnStart1.Focus();
                return;
            }

            if (e.KeyChar == '.') e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if (txtX.Text.IndexOf(',') != -1 || txtX.Text == "") e.Handled = true;
                return;
            }

            if (e.KeyChar == '-')
            {
                if (txtX.Text.IndexOf('-') != -1 || txtX.SelectionStart != 0) e.Handled = true;
                return;
            }

            e.Handled = true;
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result =";
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            string textA = txtboxA.Text.Replace(',', '.');
            string textB = txtboxB.Text.Replace(',', '.');
            string textY = txtboxY.Text.Replace(',', '.');

            if (double.TryParse(textA, out double a) &&
                double.TryParse(textB, out double b) &&
                double.TryParse(textY, out double y))
            {
                // переводимо кут y радіани 
                double yRadians = y * Math.PI / 180.0;

                // рахуємо площу за формулою: S = 1/2 * a * b * sin(y)
                double result = 0.5 * a * b * Math.Sin(yRadians);

                listBox1.Items.Add($"a={a} | b={b} | Y={y}градусів | S={result:F2}");
            }
            else
            {
                // якщо немає числа буде помика
                MessageBox.Show("Немає числа");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            string textA = txtBox3A.Text.Replace(',', '.');
            string textB = txtBox3B.Text.Replace(',', '.');
            string textC = txtBox3C.Text.Replace(',', '.');
            string textD = txtBox3D.Text.Replace(',', '.');

            // Намагаємось перетворити текст у числа
            if (double.TryParse(textA, out double a) &&
                double.TryParse(textB, out double b) &&
                double.TryParse(textC, out double c) &&
                double.TryParse(textD, out double d))
            {
                // Перевірка умови подібності:
                bool areSimilar = (a * d == b * c) || (a * c == b * d);

                listBox2.Items.Add($"a={a}, b={b} | c={c}, d={d} | Подібні: {areSimilar}");
            }
            else
            {
                MessageBox.Show("Напиши нормальні числа.");
            }
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            string textA = txtBox4A.Text.Replace(',', '.');
            string textB = txtBox4B.Text.Replace(',', '.');
            string textC = txtBox4C.Text.Replace(',', '.');

            if (double.TryParse(textA, out double a) &&
                double.TryParse(textB, out double b) &&
                double.TryParse(textC, out double c))
            {
                double sumAB = a + b;
                double sumAC = a + c;
                double sumBC = b + c;

                // чи хоча б одна сума строго більше нуля
                bool hasPositiveSum = (sumAB > 0) || (sumAC > 0) || (sumBC > 0);

                listBox3.Items.Add($"Числа: {a}; {b}; {c}");
                listBox3.Items.Add($"Пари: {a}+{b}={sumAB} | {a}+{c}={sumAC} | {b}+{c}={sumBC}");
                listBox3.Items.Add($"Результат: {hasPositiveSum}");
                listBox3.Items.Add("-----------------------------------------------");
            }
            else
            {
                MessageBox.Show("Напиши числа");
            }
        }

        private void btnStart5_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            for (int age = 100; age <= 150; age++)
            {
                // розбиваємо число на цифри
                int x = age / 100;          // перша цифра (завжди 1 для 100-199)
                int y = (age / 10) % 10;    // друга цифра десятки
                int z = age % 10;           // третя цифра одиниці

                // обчислюємо суму квадратів цифр
                int sumSquares = (x * x) + (y * y) + (z * z);

                // обчислюємо день народження 
                int day = age - sumSquares;

                listBox4.Items.Add($"Перевірка {age}: день {day}...");

                if (day >= 1 && day <= 31)
                {
                    listBox4.Items.Add("--------------------------------------------");
                    listBox4.Items.Add($"ЗНАЙДЕНО! Вік: {age}, День народження: {day}");
                    listBox4.Items.Add("--------------------------------------------");

                    // зупиняємо цикл повністю
                    break;
                }
            }
        }

        private void btnStart6_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            // отримуємо текст і видаляємо зайві пробіли на початку та в кінці
            string textA = txtBox6A.Text.Trim();
            string textB = txtBox6B.Text.Trim();

            // перевірка на пусті поля
            if (string.IsNullOrEmpty(textA) || string.IsNullOrEmpty(textB))
            {
                MessageBox.Show("заповни обидва поля");
                return;
            }

            // ігноруємо подвійні пробіли
            string[] itemsA = textA.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] itemsB = textB.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (itemsA.Length != itemsB.Length)
            {
                MessageBox.Show($"різна кількість чисел. Масив А: {itemsA.Length}, Масив B: {itemsB.Length}.");
                return;
            }

            for (int i = 0; i < itemsA.Length; i++)
            {
                if (int.TryParse(itemsA[i], out int ai) && int.TryParse(itemsB[i], out int bi))
                {
                    int resultB;

                    if (ai <= 0)
                    {
                        resultB = bi * 10;
                    }
                    else
                    {
                        resultB = 0;
                    }

                    listBox5.Items.Add($"a={ai} | b було: {bi} -> стало: {resultB}");
                }
                else
                {
                    MessageBox.Show($"помилка в даних на місці {i + 1}. Там можуть бути букви");
                    return;
                }
            }
        }

        private void btnStart7_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();

            string text = txtBox7A.Text;
            int count = 0;

            if (text.Length < 3)
            {
                listBox6.Items.Add("Рядок занадто короткий");
                return;
            }

            // проходимо циклом по рядку
            // зупиняємося за 2 символи до кінця бо abc має довжину 3
            for (int i = 0; i <= text.Length - 3; i++)
            {
                if (text[i] == 'a' && text[i + 1] == 'b' && text[i + 2] == 'c')
                {
                    count++;
                }
            }

            listBox6.Items.Add($"Текст: {text}");
            listBox6.Items.Add($"Знайдено 'abc': {count} раз(ів)");
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtboxA.Clear();
            txtboxB.Clear();
            txtboxY.Clear();
        }

        private void btnClear3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            txtBox3A.Clear();
            txtBox3B.Clear();
            txtBox3C.Clear();
            txtBox3D.Clear();
        }

        private void btnClear4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            txtBox4A.Clear();
            txtBox4B.Clear();
            txtBox4C.Clear();
        }

        private void btnClear6_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            txtBox6A.Clear();
            txtBox6B.Clear();
        }

        private void btnClear7_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            txtBox7A.Clear();
        }
    }
}