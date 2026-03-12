namespace ShopApp
{
    partial class DeleteProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutMain = new TableLayoutPanel();
            labelTitle = new Label();
            listBoxProducts = new ListBox();
            panelButtons = new Panel();
            buttonDelete = new Button();
            buttonCancel = new Button();
            tableLayoutMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(labelTitle, 0, 0);
            tableLayoutMain.Controls.Add(listBoxProducts, 0, 1);
            tableLayoutMain.Controls.Add(panelButtons, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.Size = new Size(378, 294);
            tableLayoutMain.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(372, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Выберите товар для удаления";
            // 
            // listBoxProducts
            // 
            listBoxProducts.Dock = DockStyle.Fill;
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(3, 43);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(372, 198);
            listBoxProducts.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancel);
            panelButtons.Controls.Add(buttonDelete);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 247);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(372, 44);
            panelButtons.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Left;
            buttonDelete.Location = new Point(0, 0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 44);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Right;
            buttonCancel.Location = new Point(260, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 44);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // DeleteProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 294);
            Controls.Add(tableLayoutMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Удалить товар";
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private Label labelTitle;
        private ListBox listBoxProducts;
        private Panel panelButtons;
        private Button buttonCancel;
        private Button buttonDelete;
    }
}