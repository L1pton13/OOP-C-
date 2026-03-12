using System.Data;
using System.Globalization;
using ShopApp.Exceptions;
using ShopApp.Models.Base;
using ShopApp.Models.Clothing;
using ShopApp.Models.Electronics;
using ShopApp.Models.Food;

namespace ShopApp
{
    public partial class MainForm : Form
    {
        private List<Product> _allProducts = new List<Product>();

        public MainForm()
        {
            var culture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            InitializeComponent();
            LoadCategories();
            LoadSortOptions();
            DisplayProducts(_allProducts);
        }

        private void LoadCategories()
        {
            treeViewCategories.Nodes.Clear();
            TreeNode rootNode = new TreeNode("📦 Все товары");
            treeViewCategories.Nodes.Add(rootNode);

            TreeNode category1 = new TreeNode("Электроника");
            TreeNode category2 = new TreeNode("Одежда");
            TreeNode category3 = new TreeNode("Еда");

            rootNode.Nodes.Add(category1);
            rootNode.Nodes.Add(category2);
            rootNode.Nodes.Add(category3);

            category1.Nodes.Add("📱 Смартфоны");
            category1.Nodes.Add("💻 Ноутбуки");
            category2.Nodes.Add("👕 Футболки");
            category3.Nodes.Add("🥛 Йогурты");
            rootNode.Expand();
        }

        private void LoadSortOptions()
        {
            comboBoxSort.Items.AddRange(new string[]
            {
                "По умолчанию",
                "По цене (возр.)",
                "По цене (убыв.)",
                "По названию"
            });
            comboBoxSort.SelectedIndex = 0;
        }

        private void DisplayProducts(List<Product> products)
        {
            panelProducts.Controls.Clear();

            var flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10)
            };

            foreach (var product in products)
            {
                var card = CreateProductCard(product);
                flowPanel.Controls.Add(card);
            }

            panelProducts.Controls.Add(flowPanel);
        }

        private Panel CreateProductCard(Product product)
        {
            var card = new Panel
            {
                Width = 180,
                Height = 220,
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            var labelIcon = new Label
            {
                Text = GetCategoryIcon(product),
                Font = new Font("Segoe UI Emoji", 28),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 178,
                Height = 70,
                Top = 5,
                Left = 0
            };

            var labelName = new Label
            {
                Text = product.Name,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 178,
                Height = 40,
                Top = 75,
                Left = 0,
                ForeColor = Color.FromArgb(33, 33, 33)
            };

            var labelType = new Label
            {
                Text = product.GetType().Name,
                Font = new Font("Segoe UI", 7),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 178,
                Height = 20,
                Top = 113,
                Left = 0,
                ForeColor = Color.Gray
            };

            var labelPrice = new Label
            {
                Text = $"{product.Price:C}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 178,
                Height = 30,
                Top = 133,
                Left = 0,
                ForeColor = Color.SteelBlue
            };

            var buttonInfo = new Button
            {
                Text = "Подробнее",
                Width = 120,
                Height = 30,
                Top = 172,
                Left = 29,  // (178 - 120) / 2 = 29, центрируем
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8),
                Tag = product
            };
            buttonInfo.Click += ButtonInfo_Click;


            card.Controls.AddRange(new Control[]
            {
                labelIcon, labelName, labelType, labelPrice, buttonInfo
            });

            return card;
        }

        private void ButtonInfo_Click(object? sender, EventArgs e)
        {
            var product = (Product)((Button)sender).Tag;
            statusLabelInfo.Text = product.GetInfo().Replace("\n", " | ");
        }

        private string GetCategoryIcon(Product product)
        {
            return product switch
            {
                Smartphone => "📱",
                Laptop => "💻",
                TShirt => "👕",
                Yogurt => "🥛",
                _ => "📦"
            };
        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var query = textBoxSearch.Text.ToLower();
            var filtered = _allProducts
                .Where(p => p.Name.ToLower().Contains(query) ||
                            p.Description.ToLower().Contains(query))
                .ToList();
            DisplayProducts(filtered);
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sorted = comboBoxSort.SelectedIndex switch
            {
                1 => _allProducts.OrderBy(p => p.Price).ToList(),
                2 => _allProducts.OrderByDescending(p => p.Price).ToList(),
                3 => _allProducts.OrderBy(p => p.Name).ToList(),
                _ => _allProducts
            };
            DisplayProducts(sorted);
        }

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var filtered = e.Node.Text switch
            {
                "📱 Смартфоны" => _allProducts.OfType<Smartphone>().Cast<Product>().ToList(),
                "💻 Ноутбуки" => _allProducts.OfType<Laptop>().Cast<Product>().ToList(),
                "👕 Футболки" => _allProducts.OfType<TShirt>().Cast<Product>().ToList(),
                "🥛 Йогурты" => _allProducts.OfType<Yogurt>().Cast<Product>().ToList(),
                _ => _allProducts
            };
            DisplayProducts(filtered);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddProductForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _allProducts.Add(addForm.CreatedProduct);
                DisplayProducts(_allProducts);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_allProducts.Count == 0)
            {
                MessageBox.Show("Нет товаров для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var deleteForm = new DeleteProductForm(_allProducts);
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                _allProducts.Remove(deleteForm.ProductToDelete);
                DisplayProducts(_allProducts);
                statusLabelInfo.Text = "Товар удалён";
            }
        }
    }
}
