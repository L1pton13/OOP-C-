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
using ShopApp.Factories;

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
            comboBoxType.Items.Clear();
            comboBoxType.Items.AddRange(ProductRegistry.GetAvailableTypes().ToArray());
            
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSpecific.Controls.Clear();
            if (comboBoxType.SelectedItem == null) return;

            var factory = ProductRegistry.GetFactory(comboBoxType.SelectedItem.ToString());
            string[] fields = factory.GetUIFields();

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = fields.Length,
                AutoScroll = true
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

                var factory = ProductRegistry.GetFactory(comboBoxType.SelectedItem.ToString());

                var values = new Dictionary<string, string>();
                var table = panelSpecific.Controls.OfType<TableLayoutPanel>().FirstOrDefault();

                if (table != null)
                {
                    foreach (var tb in table.Controls.OfType<TextBox>())
                    {
                        values.Add(tb.Name, tb.Text.Trim());
                    }
                }

                CreatedProduct = factory.Create(id, name, price, desc, values);

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
