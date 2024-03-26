namespace View.Forms
{
    partial class CarAddForm
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
            capacityTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            appendButton = new Button();
            numberMaskedTextBox = new MaskedTextBox();
            brandMaskedTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(162, 148);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(162, 23);
            capacityTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 70);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Марка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 112);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 151);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 5;
            label3.Text = "Вместимость в кг.";
            // 
            // appendButton
            // 
            appendButton.Location = new Point(135, 202);
            appendButton.Name = "appendButton";
            appendButton.Size = new Size(75, 23);
            appendButton.TabIndex = 6;
            appendButton.Text = "Добавить";
            appendButton.UseVisualStyleBackColor = true;
            // 
            // numberMaskedTextBox
            // 
            numberMaskedTextBox.Location = new Point(162, 109);
            numberMaskedTextBox.Mask = "(999) 000-0000";
            numberMaskedTextBox.Name = "numberMaskedTextBox";
            numberMaskedTextBox.Size = new Size(162, 23);
            numberMaskedTextBox.TabIndex = 7;
            // 
            // brandMaskedTextBox
            // 
            brandMaskedTextBox.Location = new Point(162, 67);
            brandMaskedTextBox.Mask = "L_000_LL_00";
            brandMaskedTextBox.Name = "brandMaskedTextBox";
            brandMaskedTextBox.Size = new Size(162, 23);
            brandMaskedTextBox.TabIndex = 8;
            brandMaskedTextBox.ValidatingType = typeof(int);
            // 
            // CarAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 261);
            Controls.Add(brandMaskedTextBox);
            Controls.Add(numberMaskedTextBox);
            Controls.Add(appendButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(capacityTextBox);
            Name = "CarAddForm";
            Text = "Добавление авто";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox capacityTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button appendButton;
        private MaskedTextBox numberMaskedTextBox;
        private MaskedTextBox brandMaskedTextBox;
    }
}