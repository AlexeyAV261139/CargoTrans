namespace View.Forms
{
    partial class DriverAddForm
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
            addButton = new Button();
            firstNameLable = new Label();
            surnameLable = new Label();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            phoneLabel = new Label();
            phoneMaskedTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(153, 189);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 31);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // firstNameLable
            // 
            firstNameLable.AutoSize = true;
            firstNameLable.Location = new Point(39, 77);
            firstNameLable.Name = "firstNameLable";
            firstNameLable.Size = new Size(39, 20);
            firstNameLable.TabIndex = 1;
            firstNameLable.Text = "Имя";
            // 
            // surnameLable
            // 
            surnameLable.AutoSize = true;
            surnameLable.Location = new Point(34, 116);
            surnameLable.Name = "surnameLable";
            surnameLable.Size = new Size(73, 20);
            surnameLable.TabIndex = 2;
            surnameLable.Text = "Фамилия";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(109, 73);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(230, 27);
            nameTextBox.TabIndex = 3;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(109, 112);
            surnameTextBox.Margin = new Padding(3, 4, 3, 4);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(230, 27);
            surnameTextBox.TabIndex = 4;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(39, 155);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(69, 20);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Телефон";
            // 
            // phoneMaskedTextBox
            // 
            phoneMaskedTextBox.Location = new Point(109, 155);
            phoneMaskedTextBox.Mask = "(999) 000-0000";
            phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            phoneMaskedTextBox.Size = new Size(230, 27);
            phoneMaskedTextBox.TabIndex = 7;
            // 
            // DriverAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 284);
            Controls.Add(phoneMaskedTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(surnameLable);
            Controls.Add(firstNameLable);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DriverAddForm";
            Text = "Добавление водителя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Label firstNameLable;
        private Label surnameLable;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private Label phoneLabel;
        private MaskedTextBox phoneMaskedTextBox;
    }
}