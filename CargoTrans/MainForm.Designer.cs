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
            dataGridViewCargoType = new DataGridView();
            buttonSave = new Button();
            menuStrip1 = new MenuStrip();
            рейсыToolStripMenuItem = new ToolStripMenuItem();
            грузыToolStripMenuItem = new ToolStripMenuItem();
            автоToolStripMenuItem = new ToolStripMenuItem();
            водителиToolStripMenuItem = new ToolStripMenuItem();
            маршрутыToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargoType).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCargoType
            // 
            dataGridViewCargoType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCargoType.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCargoType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCargoType.Location = new Point(33, 127);
            dataGridViewCargoType.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCargoType.Name = "dataGridViewCargoType";
            dataGridViewCargoType.Size = new Size(595, 361);
            dataGridViewCargoType.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(55, 234);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(117, 31);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { рейсыToolStripMenuItem, грузыToolStripMenuItem, автоToolStripMenuItem, водителиToolStripMenuItem, маршрутыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(917, 35);
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
            // 
            // автоToolStripMenuItem
            // 
            автоToolStripMenuItem.Name = "автоToolStripMenuItem";
            автоToolStripMenuItem.Size = new Size(65, 29);
            автоToolStripMenuItem.Text = "Авто";
            // 
            // водителиToolStripMenuItem
            // 
            водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            водителиToolStripMenuItem.Size = new Size(106, 29);
            водителиToolStripMenuItem.Text = "Водители";
            // 
            // маршрутыToolStripMenuItem
            // 
            маршрутыToolStripMenuItem.Name = "маршрутыToolStripMenuItem";
            маршрутыToolStripMenuItem.Size = new Size(118, 29);
            маршрутыToolStripMenuItem.Text = "Маршруты";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(662, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 296);
            panel1.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(610, 525);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 31);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "button1";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 624);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewCargoType);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "ИС \"Грузоперевозки\"";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargoType).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewCargoType;
        private Button buttonSave;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem рейсыToolStripMenuItem;
        private ToolStripMenuItem грузыToolStripMenuItem;
        private ToolStripMenuItem автоToolStripMenuItem;
        private ToolStripMenuItem водителиToolStripMenuItem;
        private ToolStripMenuItem маршрутыToolStripMenuItem;
        private Panel panel1;
        private Button buttonAdd;
    }
}
