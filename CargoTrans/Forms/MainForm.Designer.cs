namespace CargoTrans
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridViewMain = new DataGridView();
            buttonSave = new Button();
            menuStrip1 = new MenuStrip();
            рейсыToolStripMenuItem = new ToolStripMenuItem();
            грузыToolStripMenuItem = new ToolStripMenuItem();
            автоToolStripMenuItem = new ToolStripMenuItem();
            водителиToolStripMenuItem = new ToolStripMenuItem();
            маршрутыToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(34, 68);
            dataGridViewMain.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowHeadersWidth = 51;
            dataGridViewMain.Size = new Size(939, 361);
            dataGridViewMain.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(67, 462);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(117, 31);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { рейсыToolStripMenuItem, грузыToolStripMenuItem, автоToolStripMenuItem, водителиToolStripMenuItem, маршрутыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1415, 35);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // рейсыToolStripMenuItem
            // 
            рейсыToolStripMenuItem.Name = "рейсыToolStripMenuItem";
            рейсыToolStripMenuItem.Size = new Size(78, 29);
            рейсыToolStripMenuItem.Text = "Рейсы";
            рейсыToolStripMenuItem.Click += ActiveRoutesToolStripMenuItem_Click;
            // 
            // грузыToolStripMenuItem
            // 
            грузыToolStripMenuItem.Name = "грузыToolStripMenuItem";
            грузыToolStripMenuItem.Size = new Size(74, 29);
            грузыToolStripMenuItem.Text = "Грузы";
            грузыToolStripMenuItem.Click += CargoToolStripMenuItem_Click;
            // 
            // автоToolStripMenuItem
            // 
            автоToolStripMenuItem.Name = "автоToolStripMenuItem";
            автоToolStripMenuItem.Size = new Size(65, 29);
            автоToolStripMenuItem.Text = "Авто";
            автоToolStripMenuItem.Click += CarsToolStripMenuItem_Click;
            // 
            // водителиToolStripMenuItem
            // 
            водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            водителиToolStripMenuItem.Size = new Size(106, 29);
            водителиToolStripMenuItem.Text = "Водители";
            водителиToolStripMenuItem.Click += DriversToolStripMenuItem_Click;
            // 
            // маршрутыToolStripMenuItem
            // 
            маршрутыToolStripMenuItem.Name = "маршрутыToolStripMenuItem";
            маршрутыToolStripMenuItem.Size = new Size(118, 29);
            маршрутыToolStripMenuItem.Text = "Маршруты";
            маршрутыToolStripMenuItem.Click += RoutesToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(979, 107);
            button1.Name = "button1";
            button1.Size = new Size(103, 30);
            button1.TabIndex = 4;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 544);
            Controls.Add(button1);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "ИС \"Грузоперевозки\"";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewMain;
        private Button buttonSave;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem рейсыToolStripMenuItem;
        private ToolStripMenuItem грузыToolStripMenuItem;
        private ToolStripMenuItem автоToolStripMenuItem;
        private ToolStripMenuItem водителиToolStripMenuItem;
        private ToolStripMenuItem маршрутыToolStripMenuItem;
        private Button button1;
    }
}
