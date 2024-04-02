namespace View.Forms
{
    partial class CargoAddForm
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
            button1 = new Button();
            TypeTextBox = new TextBox();
            reequipmentsTextBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(158, 204);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddButton_Click;
            // 
            // TypeTextBox
            // 
            TypeTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TypeTextBox.Location = new Point(119, 74);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(141, 23);
            TypeTextBox.TabIndex = 1;
            // 
            // reequipmentsTextBox1
            // 
            reequipmentsTextBox1.Location = new Point(119, 113);
            reequipmentsTextBox1.Multiline = true;
            reequipmentsTextBox1.Name = "reequipmentsTextBox1";
            reequipmentsTextBox1.ScrollBars = ScrollBars.Vertical;
            reequipmentsTextBox1.Size = new Size(141, 60);
            reequipmentsTextBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 77);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 3;
            label1.Text = "Тип";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 134);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Описание";
            // 
            // CargoAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 274);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reequipmentsTextBox1);
            Controls.Add(TypeTextBox);
            Controls.Add(button1);
            Name = "CargoAddForm";
            Text = "Добавление груза";
            Load += CargoAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TypeTextBox;
        private TextBox reequipmentsTextBox1;
        private Label label1;
        private Label label2;
    }
}