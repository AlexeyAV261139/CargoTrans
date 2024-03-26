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
            phopeTextBox = new TextBox();
            phoneLabel = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(134, 142);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // firstNameLable
            // 
            firstNameLable.AutoSize = true;
            firstNameLable.Location = new Point(34, 58);
            firstNameLable.Name = "firstNameLable";
            firstNameLable.Size = new Size(31, 15);
            firstNameLable.TabIndex = 1;
            firstNameLable.Text = "Имя";
            // 
            // surnameLable
            // 
            surnameLable.AutoSize = true;
            surnameLable.Location = new Point(30, 87);
            surnameLable.Name = "surnameLable";
            surnameLable.Size = new Size(58, 15);
            surnameLable.TabIndex = 2;
            surnameLable.Text = "Фамилия";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(95, 55);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(202, 23);
            nameTextBox.TabIndex = 3;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(95, 84);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(202, 23);
            surnameTextBox.TabIndex = 4;
            // 
            // phopeTextBox
            // 
            phopeTextBox.Location = new Point(95, 113);
            phopeTextBox.Name = "phopeTextBox";
            phopeTextBox.Size = new Size(202, 23);
            phopeTextBox.TabIndex = 5;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(34, 116);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(55, 15);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Телефон";
            // 
            // DriverAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 213);
            Controls.Add(phoneLabel);
            Controls.Add(phopeTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(surnameLable);
            Controls.Add(firstNameLable);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private TextBox phopeTextBox;
        private Label phoneLabel;
    }
}