using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsApp
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик событий при изменении выбраного текста
        /// </summary>
        private void SelectedIndexChangedHandler(object sender, EventArgs e)
        {
            
            /// Конструкция нужна, чтобы при отмене выбора не было проблемы
            if (TextsBox.SelectedIndex == -1) // - при -1 не выбран никакой с вариантов
                return; // - выход из метода

            // Выставление максимальних индексов относительно выбора:
            FirstNumberBox.Maximum = TextsBox.SelectedItem.ToString().Length - 1;
            SecondNumberBox.Maximum = FirstNumberBox.Maximum;
        }

        /// <summary>
        /// Замена
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (FirstNumberBox.Value != SecondNumberBox.Value && TextsBox.SelectedIndex != -1)
            {
                // Преобразованные в целый тип индексы:
                int first = Convert.ToInt32(FirstNumberBox.Value);
                int second = Convert.ToInt32(SecondNumberBox.Value);

                /// StringBuilder - динамическая строка, которую можно изменять [string нельзя]
                /// var - неявный тип, определяется зависимо от присвоеного значения
                StringBuilder text = new StringBuilder(TextsBox.SelectedItem.ToString()); // - переменная для временного хранения выбраного текста

                var buffer = text[first]; // - переменная для временного хранения значения одного из символов
                text[first] = text[second];
                text[second] = buffer;

                ResultLabel.Text = text.ToString();
            }
        }

        /// <summary>
        /// Добавление текста
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddBox.Text != "")
            {
                TextsBox.Items.Add(AddBox.Text);
                AddBox.Clear(); // - очистка поля ввода
            }
        }
    }
}
