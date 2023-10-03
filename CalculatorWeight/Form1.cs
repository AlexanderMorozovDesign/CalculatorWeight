using System;
using System.Windows.Forms;

namespace CalculatorWeight
{
    public partial class Form1 : Form
    {
        private const decimal PI = 3.1415926535897931m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Устанавливаем значение по умолчанию для ComboBox при загрузке формы.
            comboBoxType.Text = comboBoxType.Items[0].ToString();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработчик события изменения выбранного элемента в ComboBox.

            ComboBox comboBox = (ComboBox)sender;
            int index = comboBoxType.SelectedIndex;

            // Определяем видимость и доступность элементов интерфейса
            // в зависимости от выбранного типа в ComboBox.

            switch (index)
            {
                case 0:
                    numericUpDownDiameter.Visible = true;
                    labelDiameter.Visible = true;
                    numericUpDownWallThickness.Visible = true;
                    labelWallThickness.Visible = true;
                    numericUpDownHeightOutside.Visible = false;
                    labelHeightOutside.Visible = false;
                    numericUpDownShelfThickness.Visible = false;
                    labelShelfThickness.Visible = false;
                    numericUpDownWidthOutside.Visible = false;
                    labelWidthOutside.Visible = false;
                    break;
                case 1:
                    numericUpDownDiameter.Visible = true;
                    labelDiameter.Visible = true;
                    numericUpDownWallThickness.Visible = false;
                    labelWallThickness.Visible = false;
                    numericUpDownHeightOutside.Visible = false;
                    labelHeightOutside.Visible = false;
                    numericUpDownShelfThickness.Visible = false;
                    labelShelfThickness.Visible = false;
                    numericUpDownWidthOutside.Visible = false;
                    labelWidthOutside.Visible = false;
                    break;
                case 2:
                    numericUpDownHeightOutside.Visible = true;
                    labelHeightOutside.Visible = true;
                    numericUpDownWidthOutside.Visible = true;
                    labelWidthOutside.Visible = true;
                    numericUpDownWallThickness.Visible = true;
                    labelWallThickness.Visible = true;
                    numericUpDownShelfThickness.Visible = true;
                    labelShelfThickness.Visible = true;
                    numericUpDownDiameter.Visible = false;
                    labelDiameter.Visible = false;
                    break;
                case 3:
                    numericUpDownHeightOutside.Visible = true;
                    labelHeightOutside.Visible = true;
                    numericUpDownWidthOutside.Visible = true;
                    labelWidthOutside.Visible = true;
                    numericUpDownDiameter.Visible = false;
                    labelDiameter.Visible = false;
                    numericUpDownWallThickness.Visible = false;
                    labelWallThickness.Visible = false;
                    numericUpDownShelfThickness.Visible = false;
                    labelShelfThickness.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            // Обработчик события нажатия на кнопку "Рассчитать".

            string resultNumber = "";
            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    if (numericUpDownWallThickness.Value != 0 && numericUpDownDiameter.Value != 0)
                    {
                        // Вычисляем результат для типа 0 (расчет объема полого цилиндра).

                        decimal ROuter = numericUpDownDiameter.Value / 2;
                        decimal RInner = ROuter - numericUpDownWallThickness.Value;
                        decimal dev = ROuter * ROuter - RInner * RInner;
                        decimal value = PI * numericUpDownLength.Value * 1000 * dev;
                        resultNumber = (value * numericUpDownDensity.Value * 0.000000001m).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Есть пустые поля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 1:
                    if (numericUpDownDiameter.Value != 0 && numericUpDownLength.Value != 0 && numericUpDownDensity.Value != 0)
                    {
                        // Вычисляем результат для типа 1 (расчет объема цилиндра).

                        decimal radius = numericUpDownDiameter.Value / 2;
                        resultNumber = (PI * numericUpDownLength.Value * radius * radius * numericUpDownDensity.Value * 0.000001m).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Есть пустые поля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 2:
                    if (numericUpDownHeightOutside.Value != 0 && numericUpDownWidthOutside.Value != 0 &&
                        numericUpDownShelfThickness.Value != 0 && numericUpDownWallThickness.Value != 0 &&
                         numericUpDownLength.Value != 0 && numericUpDownDensity.Value != 0)
                    {
                        // Вычисляем результат для типа 2 (расчет объема прямоугольного профиля).

                        decimal S_Outer = numericUpDownHeightOutside.Value * numericUpDownWidthOutside.Value;
                        decimal H_int = numericUpDownHeightOutside.Value - 2 * numericUpDownShelfThickness.Value;
                        decimal W_int = numericUpDownWidthOutside.Value - 2 * numericUpDownWallThickness.Value;
                        decimal S_int = H_int * W_int;
                        decimal V = (S_Outer - S_int) * numericUpDownLength.Value;
                        resultNumber = (V * numericUpDownDensity.Value * 0.000001m).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Есть пустые поля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 3:
                    if (numericUpDownHeightOutside.Value != 0 && numericUpDownWidthOutside.Value != 0 &&
                        numericUpDownLength.Value != 0 && numericUpDownDensity.Value != 0)
                    {
                        // Вычисляем результат для типа 3 (расчет объема параллелепипеда).

                        resultNumber = (numericUpDownHeightOutside.Value * numericUpDownWidthOutside.Value * numericUpDownLength.Value * numericUpDownDensity.Value * 0.000001m).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Есть пустые поля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }

            int numberOfDecimals = 2; // Желаемое количество знаков после запятой

            // Разбиваем строку на части до и после запятой
            string[] parts = resultNumber.Split(',');

            // Если есть дробная часть и она достаточно длинная, обрезаем её
            if (parts.Length == 2 && parts[1].Length > numberOfDecimals)
            {
                parts[1] = parts[1].Substring(0, numberOfDecimals);
            }

            // Склеиваем части снова в строку
            string result = string.Join(",", parts);

            // Отображаем результат в текстовом поле
            textBoxResult.Text = result;
        }
    }
}
