using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutMain = new TableLayoutPanel();
            panelTop = new Panel();
            comboBoxSort = new ComboBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            labelTitle = new Label();
            panelProducts = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            treeViewCategories = new TreeView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            statusStrip = new StatusStrip();
            statusLabelInfo = new ToolStripStatusLabel();
            tableLayoutMain.SuspendLayout();
            panelTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Controls.Add(panelTop, 0, 0);
            tableLayoutMain.Controls.Add(panelProducts, 1, 1);
            tableLayoutMain.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 2;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(1178, 612);
            tableLayoutMain.TabIndex = 0;
            // 
            // panelTop
            // 
            tableLayoutMain.SetColumnSpan(panelTop, 2);
            panelTop.Controls.Add(comboBoxSort);
            panelTop.Controls.Add(buttonSearch);
            panelTop.Controls.Add(textBoxSearch);
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1172, 34);
            panelTop.TabIndex = 0;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(810, 1);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(150, 33);
            comboBoxSort.TabIndex = 3;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(613, 0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(112, 34);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Найти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(262, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(300, 31);
            textBoxSearch.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(22, 3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(137, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "\U0001f6d2 Shop App";
            // 
            // panelProducts
            // 
            panelProducts.AutoScroll = true;
            panelProducts.Dock = DockStyle.Fill;
            panelProducts.Location = new Point(303, 43);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(872, 566);
            panelProducts.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(treeViewCategories, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonDelete, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.Size = new Size(294, 566);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // treeViewCategories
            // 
            treeViewCategories.Dock = DockStyle.Fill;
            treeViewCategories.Location = new Point(3, 3);
            treeViewCategories.Name = "treeViewCategories";
            treeViewCategories.Size = new Size(288, 465);
            treeViewCategories.TabIndex = 0;
            treeViewCategories.AfterSelect += treeViewCategories_AfterSelect;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(3, 474);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(288, 41);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить товар";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Location = new Point(3, 521);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(288, 42);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить товар";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabelInfo });
            statusStrip.Location = new Point(0, 612);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1178, 32);
            statusStrip.TabIndex = 1;
            // 
            // statusLabelInfo
            // 
            statusLabelInfo.Name = "statusLabelInfo";
            statusLabelInfo.Size = new Size(194, 25);
            statusLabelInfo.Text = "Загружено товаров: 0";
            // 
            // MainForm
            // 
            ClientSize = new Size(1178, 644);
            Controls.Add(tableLayoutMain);
            Controls.Add(statusStrip);
            MinimumSize = new Size(1200, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop App";
            tableLayoutMain.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private TableLayoutPanel tableLayoutMain;
        private Panel panelTop;
        private Label labelTitle;
        private ComboBox comboBoxSort;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Panel panelProducts;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabelInfo;
        private TableLayoutPanel tableLayoutPanel1;
        private TreeView treeViewCategories;
        private Button buttonAdd;
        private Button buttonDelete;
    }
}
