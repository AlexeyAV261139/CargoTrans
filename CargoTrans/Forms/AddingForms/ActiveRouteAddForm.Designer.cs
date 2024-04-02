﻿namespace View.Forms
{
    partial class ActiveRouteAddForm
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
            appendButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cargoComboBox = new ComboBox();
            carComboBox = new ComboBox();
            driverComboBox = new ComboBox();
            routeComboBox = new ComboBox();
            deadLineDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // appendButton
            // 
            appendButton.Location = new Point(167, 301);
            appendButton.Name = "appendButton";
            appendButton.Size = new Size(67, 23);
            appendButton.TabIndex = 0;
            appendButton.Text = "Добавить";
            appendButton.UseVisualStyleBackColor = true;
            appendButton.Click += AppendButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 77);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Груз";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 116);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Авто";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 165);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Водитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 207);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Маршрут";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 248);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 10;
            label5.Text = "Выполнить  до";
            // 
            // cargoComboBox
            // 
            cargoComboBox.FormattingEnabled = true;
            cargoComboBox.Location = new Point(167, 74);
            cargoComboBox.Name = "cargoComboBox";
            cargoComboBox.Size = new Size(121, 23);
            cargoComboBox.TabIndex = 11;
            // 
            // carComboBox
            // 
            carComboBox.FormattingEnabled = true;
            carComboBox.Location = new Point(167, 113);
            carComboBox.Name = "carComboBox";
            carComboBox.Size = new Size(121, 23);
            carComboBox.TabIndex = 12;
            // 
            // driverComboBox
            // 
            driverComboBox.FormattingEnabled = true;
            driverComboBox.Location = new Point(167, 162);
            driverComboBox.Name = "driverComboBox";
            driverComboBox.Size = new Size(121, 23);
            driverComboBox.TabIndex = 13;
            // 
            // routeComboBox
            // 
            routeComboBox.FormattingEnabled = true;
            routeComboBox.Location = new Point(167, 207);
            routeComboBox.Name = "routeComboBox";
            routeComboBox.Size = new Size(121, 23);
            routeComboBox.TabIndex = 14;
            // 
            // deadLineDateTimePicker
            // 
            deadLineDateTimePicker.Location = new Point(167, 248);
            deadLineDateTimePicker.Name = "deadLineDateTimePicker";
            deadLineDateTimePicker.Size = new Size(121, 23);
            deadLineDateTimePicker.TabIndex = 15;
            // 
            // ActiveRouteAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 394);
            Controls.Add(deadLineDateTimePicker);
            Controls.Add(routeComboBox);
            Controls.Add(driverComboBox);
            Controls.Add(carComboBox);
            Controls.Add(cargoComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(appendButton);
            Name = "ActiveRouteAddForm";
            Text = "Добавление рейсов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button appendButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cargoComboBox;
        private ComboBox carComboBox;
        private ComboBox driverComboBox;
        private ComboBox routeComboBox;
        private DateTimePicker deadLineDateTimePicker;
    }
}