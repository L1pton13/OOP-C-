namespace ShopApp
{
    partial class AddProductForm
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
            panelButtons = new Panel();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            labelType = new Label();
            comboBoxType = new ComboBox();
            labelName = new Label();
            textBoxName = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelDesc = new Label();
            textBoxDesc = new TextBox();
            panelSpecific = new Panel();
            tableLayoutMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(panelButtons, 0, 5);
            tableLayoutMain.Controls.Add(labelType, 0, 0);
            tableLayoutMain.Controls.Add(comboBoxType, 1, 0);
            tableLayoutMain.Controls.Add(labelName, 0, 1);
            tableLayoutMain.Controls.Add(textBoxName, 1, 1);
            tableLayoutMain.Controls.Add(labelPrice, 0, 2);
            tableLayoutMain.Controls.Add(textBoxPrice, 1, 2);
            tableLayoutMain.Controls.Add(labelDesc, 0, 3);
            tableLayoutMain.Controls.Add(textBoxDesc, 1, 3);
            tableLayoutMain.Controls.Add(panelSpecific, 0, 4);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 6;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.Size = new Size(378, 444);
            tableLayoutMain.TabIndex = 0;
            // 
            // panelButtons
            // 
            tableLayoutMain.SetColumnSpan(panelButtons, 2);
            panelButtons.Controls.Add(buttonCancel);
            panelButtons.Controls.Add(buttonConfirm);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 397);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(372, 44);
            panelButtons.TabIndex = 0;
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
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Dock = DockStyle.Left;
            buttonConfirm.Location = new Point(0, 0);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(112, 44);
            buttonConfirm.TabIndex = 0;
            buttonConfirm.Text = "Добавить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Fill;
            labelType.Location = new Point(3, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(144, 50);
            labelType.TabIndex = 0;
            labelType.Text = "Тип товара:";
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Fill;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(153, 3);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(222, 33);
            comboBoxType.TabIndex = 1;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(3, 50);
            labelName.Name = "labelName";
            labelName.Size = new Size(144, 50);
            labelName.TabIndex = 2;
            labelName.Text = "Название:";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Location = new Point(153, 53);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(222, 31);
            textBoxName.TabIndex = 3;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Dock = DockStyle.Fill;
            labelPrice.Location = new Point(3, 100);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(144, 50);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Цена:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Dock = DockStyle.Fill;
            textBoxPrice.Location = new Point(153, 103);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(222, 31);
            textBoxPrice.TabIndex = 5;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Dock = DockStyle.Fill;
            labelDesc.Location = new Point(3, 150);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(144, 50);
            labelDesc.TabIndex = 6;
            labelDesc.Text = "Описание:";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Dock = DockStyle.Fill;
            textBoxDesc.Location = new Point(153, 153);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(222, 31);
            textBoxDesc.TabIndex = 7;
            // 
            // panelSpecific
            // 
            tableLayoutMain.SetColumnSpan(panelSpecific, 2);
            panelSpecific.Dock = DockStyle.Fill;
            panelSpecific.Location = new Point(3, 203);
            panelSpecific.Name = "panelSpecific";
            panelSpecific.Size = new Size(372, 188);
            panelSpecific.TabIndex = 8;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 444);
            Controls.Add(tableLayoutMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить товар";
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private Label labelType;
        private ComboBox comboBoxType;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label labelDesc;
        private TextBox textBoxDesc;
        private Panel panelSpecific;
        private Panel panelButtons;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}