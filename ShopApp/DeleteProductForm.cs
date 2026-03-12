using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShopApp.Models.Base;

namespace ShopApp
{
    public partial class DeleteProductForm : Form
    {
        public Product ProductToDelete { get; private set; }
        private List<Product> _products;

        public DeleteProductForm(List<Product> products)
        {
            InitializeComponent();
            _products = products;
            LoadProducts();
            buttonDelete.Click += ButtonDelete_Click;
            buttonCancel.Click += ButtonCancel_Click;
        }

        private void LoadProducts()
        {
            listBoxProducts.Items.Clear();
            foreach (var product in _products)
            {
                listBoxProducts.Items.Add($"{product.GetType().Name} — {product.Name} — {product.Price:C}");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите товар для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = _products[listBoxProducts.SelectedIndex];

            var confirm = MessageBox.Show(
                $"Вы уверены что хотите удалить '{selected.Name}'?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                ProductToDelete = selected;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
