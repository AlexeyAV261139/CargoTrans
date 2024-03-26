namespace View.Forms
{
    partial class RouteAddForm
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
            destinationTextBox = new TextBox();
            distanceTextBox = new TextBox();
            priceTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addButton = new Button();
            SuspendLayout();
            // 
            // destinationTextBox
            // 
            destinationTextBox.Location = new Point(142, 31);
            destinationTextBox.Name = "destinationTextBox";
            destinationTextBox.Size = new Size(180, 23);
            destinationTextBox.TabIndex = 0;
            // 
            // distanceTextBox
            // 
            distanceTextBox.Location = new Point(142, 69);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(180, 23);
            distanceTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(142, 109);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(180, 23);
            priceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 3;
            label1.Text = "Место назначения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 72);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Расстояние в км.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 112);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Стоимость";
            // 
            // addButton
            // 
            addButton.Location = new Point(142, 148);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // RouteAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 201);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(priceTextBox);
            Controls.Add(distanceTextBox);
            Controls.Add(destinationTextBox);
            Name = "RouteAddForm";
            Text = "Добавление маршрута";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox destinationTextBox;
        private TextBox distanceTextBox;
        private TextBox priceTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addButton;
    }
}