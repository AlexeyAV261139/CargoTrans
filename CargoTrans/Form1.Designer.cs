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
            components = new System.ComponentModel.Container();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dataGridViewCargoType = new DataGridView();
            dataGridViewCargo = new DataGridView();
            buttonSave = new Button();
            bindingSourceCargoTypes = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargoType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCargoTypes).BeginInit();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridViewCargoType
            // 
            dataGridViewCargoType.AutoGenerateColumns = false;
            dataGridViewCargoType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCargoType.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, cargosDataGridViewTextBoxColumn });
            dataGridViewCargoType.DataSource = bindingSourceCargoTypes;
            dataGridViewCargoType.Location = new Point(12, 111);
            dataGridViewCargoType.Name = "dataGridViewCargoType";
            dataGridViewCargoType.Size = new Size(363, 150);
            dataGridViewCargoType.TabIndex = 0;
            // 
            // dataGridViewCargo
            // 
            dataGridViewCargo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCargo.Location = new Point(482, 121);
            dataGridViewCargo.Name = "dataGridViewCargo";
            dataGridViewCargo.Size = new Size(262, 150);
            dataGridViewCargo.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(482, 320);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "button1";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // bindingSourceCargoTypes
            // 
            bindingSourceCargoTypes.DataSource = typeof(DB.Entities.CargoType);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // cargosDataGridViewTextBoxColumn
            // 
            cargosDataGridViewTextBoxColumn.DataPropertyName = "Cargos";
            cargosDataGridViewTextBoxColumn.HeaderText = "Cargos";
            cargosDataGridViewTextBoxColumn.Name = "cargosDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCargo);
            Controls.Add(dataGridViewCargoType);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargoType).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCargoTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dataGridViewCargoType;
        private DataGridView dataGridViewCargo;
        private Button buttonSave;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargosDataGridViewTextBoxColumn;
        private BindingSource bindingSourceCargoTypes;
    }
}
