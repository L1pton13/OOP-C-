using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShopApp.Models.Base;
using ShopApp.Models.Electronics;
using ShopApp.Models.Clothing;
using ShopApp.Models.Food;

namespace ShopApp
{
    public partial class AddProductForm : Form
    {
        public Product CreatedProduct { get; private set; }
        public AddProductForm()
        {
            InitializeComponent();
            LoadProductTypes();
        }

        private void LoadProductTypes()
        {
            comboBoxType.Items.AddRange(new string[]
            {
                "Смартфон",
                "Ноутбук",
                "Футболка",
                "Йогурт"
            });
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSpecific.Controls.Clear();

            string[] fields = comboBoxType.SelectedItem.ToString() switch
            {
                "Смартфон" => new[] { "Бренд", "Гарантия (мес.)", "RAM (GB)", "Память (GB)", "ОС" },
                "Ноутбук" => new[] { "Бренд", "Гарантия (мес.)", "Процессор", "Видеокарта", "Экран (дюйм)" },
                "Футболка" => new[] { "Размер", "Материал", "Пол", "Принт", "Рукав" },
                "Йогурт" => new[] { "Вкус", "Жирность (%)", "Калории", "Органик (да/нет)", "Дней до истечения" },
                _ => Array.Empty<string>()
            };

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = fields.Length
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            foreach (var field in fields)
            {
                var lbl = new Label
                {
                    Text = field + ":",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = false
                };
                var box = new TextBox
                {
                    Dock = DockStyle.Fill,
                    Name = field
                };
                table.Controls.Add(lbl);
                table.Controls.Add(box);
            }

            panelSpecific.Controls.Add(table);

        }

        private string GetFieldValue(string fieldName)
        {
            var table = panelSpecific.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
            if (table == null) return "";
            var box = table.Controls.OfType<TextBox>()
                .FirstOrDefault(t => t.Name == fieldName);
            return box?.Text.Trim() ?? "";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim();
                string desc = textBoxDesc.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentException("Введите название товара!");

                if (comboBoxType.SelectedIndex < 0)
                    throw new ArgumentException("Выберите тип товара!");

                decimal price = decimal.Parse(textBoxPrice.Text.Trim());
                int id = new Random().Next(100, 9999);

                CreatedProduct = comboBoxType.SelectedItem.ToString() switch
                {
                    "Смартфон" => new Smartphone(id, name, price, desc,
                        GetFieldValue("Бренд"),
                        int.Parse(GetFieldValue("Гарантия (мес.)")),
                        int.Parse(GetFieldValue("RAM (GB)")),
                        int.Parse(GetFieldValue("Память (GB)")),
                        GetFieldValue("ОС")),

                    "Ноутбук" => new Laptop(id, name, price, desc,
                        GetFieldValue("Бренд"),
                        int.Parse(GetFieldValue("Гарантия (мес.)")),
                        GetFieldValue("Процессор"),
                        GetFieldValue("Видеокарта"),
                        double.Parse(GetFieldValue("Экран (дюйм)"))),

                    "Футболка" => new TShirt(id, name, price, desc,
                        GetFieldValue("Размер"),
                        GetFieldValue("Материал"),
                        GetFieldValue("Пол"),
                        GetFieldValue("Принт"),
                        GetFieldValue("Рукав")),

                    "Йогурт" => new Yogurt(id, name, price, desc,
                        DateTime.Now.AddDays(int.Parse(GetFieldValue("Дней до истечения"))),
                        int.Parse(GetFieldValue("Калории")),
                        GetFieldValue("Органик (да/нет)").ToLower() == "да",
                        GetFieldValue("Вкус"),
                        double.Parse(GetFieldValue("Жирность (%)"))),

                    _ => throw new ArgumentException("Неизвестный тип!")
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность числовых полей!",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
