
namespace ATDS
{
    partial class UserForm
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
        private async void InitializeComponent()
        {
            this.NameBoxText = new System.Windows.Forms.TextBox();
            this.PositionText = new System.Windows.Forms.TextBox();
            this.WarehouseText = new System.Windows.Forms.TextBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.CheckBox();
            this.DepartamentText = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.TextBox();
            this.Warehouse = new System.Windows.Forms.TextBox();
            this.Departament = new System.Windows.Forms.TextBox();
            this.CreatTask = new System.Windows.Forms.Button();
            this.CreatedTasks = new System.Windows.Forms.TabPage();
            this.CreatedTasksGrid = new System.Windows.Forms.DataGridView();
            this.ClosedTasks = new System.Windows.Forms.TabPage();
            this.ComplitedTasksGrid = new System.Windows.Forms.DataGridView();
            this.FreeTasks = new System.Windows.Forms.TabPage();
            this.FreeTasksGrid = new System.Windows.Forms.DataGridView();
            this.AssignedTasks = new System.Windows.Forms.TabPage();
            this.AssignedTasksGrid = new System.Windows.Forms.DataGridView();
            this.TaskPanel = new System.Windows.Forms.TabControl();
            this.ExportExcelReport = new System.Windows.Forms.Button();
            this.CreatedTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedTasksGrid)).BeginInit();
            this.ClosedTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComplitedTasksGrid)).BeginInit();
            this.FreeTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeTasksGrid)).BeginInit();
            this.AssignedTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedTasksGrid)).BeginInit();
            this.TaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBoxText
            // 
            this.NameBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBoxText.Location = new System.Drawing.Point(12, 12);
            this.NameBoxText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBoxText.Name = "NameBoxText";
            this.NameBoxText.ReadOnly = true;
            this.NameBoxText.Size = new System.Drawing.Size(131, 15);
            this.NameBoxText.TabIndex = 0;
            this.NameBoxText.Text = "Имя пользователя:";
            // 
            // PositionText
            // 
            this.PositionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionText.Location = new System.Drawing.Point(12, 39);
            this.PositionText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PositionText.Name = "PositionText";
            this.PositionText.ReadOnly = true;
            this.PositionText.Size = new System.Drawing.Size(81, 15);
            this.PositionText.TabIndex = 1;
            this.PositionText.Text = "Должность:";
            // 
            // WarehouseText
            // 
            this.WarehouseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarehouseText.Location = new System.Drawing.Point(12, 68);
            this.WarehouseText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WarehouseText.Name = "WarehouseText";
            this.WarehouseText.ReadOnly = true;
            this.WarehouseText.Size = new System.Drawing.Size(51, 15);
            this.WarehouseText.TabIndex = 2;
            this.WarehouseText.Text = "Склад:";
            // 
            // StatusText
            // 
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusText.Location = new System.Drawing.Point(372, 12);
            this.StatusText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.Size = new System.Drawing.Size(71, 15);
            this.StatusText.TabIndex = 3;
            this.StatusText.Text = "В работе:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Enabled = false;
            this.Status.Location = new System.Drawing.Point(449, 12);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(18, 17);
            this.Status.TabIndex = 10;
            this.Status.UseVisualStyleBackColor = true;
            // 
            // DepartamentText
            // 
            this.DepartamentText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepartamentText.Location = new System.Drawing.Point(372, 39);
            this.DepartamentText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartamentText.Name = "DepartamentText";
            this.DepartamentText.ReadOnly = true;
            this.DepartamentText.Size = new System.Drawing.Size(52, 15);
            this.DepartamentText.TabIndex = 11;
            this.DepartamentText.Text = "Отдел:";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(148, 9);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Size = new System.Drawing.Size(119, 22);
            this.UserName.TabIndex = 12;
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(148, 37);
            this.Position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Size = new System.Drawing.Size(119, 22);
            this.Position.TabIndex = 13;
            // 
            // Warehouse
            // 
            this.Warehouse.Location = new System.Drawing.Point(148, 65);
            this.Warehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.ReadOnly = true;
            this.Warehouse.Size = new System.Drawing.Size(119, 22);
            this.Warehouse.TabIndex = 14;
            // 
            // Departament
            // 
            this.Departament.Location = new System.Drawing.Point(429, 37);
            this.Departament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Departament.Name = "Departament";
            this.Departament.ReadOnly = true;
            this.Departament.Size = new System.Drawing.Size(119, 22);
            this.Departament.TabIndex = 15;
            // 
            // CreatTask
            // 
            this.CreatTask.Location = new System.Drawing.Point(372, 68);
            this.CreatTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatTask.Name = "CreatTask";
            this.CreatTask.Size = new System.Drawing.Size(177, 27);
            this.CreatTask.TabIndex = 17;
            this.CreatTask.Text = "Создать Заявку";
            this.CreatTask.UseVisualStyleBackColor = true;
            this.CreatTask.Click += new System.EventHandler(this.CreatTask_Click);
            // 
            // CreatedTasks
            // 
            this.CreatedTasks.Controls.Add(this.CreatedTasksGrid);
            this.CreatedTasks.Location = new System.Drawing.Point(4, 25);
            this.CreatedTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatedTasks.Name = "CreatedTasks";
            this.CreatedTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatedTasks.Size = new System.Drawing.Size(1320, 361);
            this.CreatedTasks.TabIndex = 3;
            this.CreatedTasks.Text = "Созданные Заявки";
            this.CreatedTasks.UseVisualStyleBackColor = true;
            this.CreatedTasks.Enter += new System.EventHandler(this.AwaitCreatedTasks);
            // 
            // CreatedTasksGrid
            // 
            this.CreatedTasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CreatedTasksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatedTasksGrid.Location = new System.Drawing.Point(3, 2);
            this.CreatedTasksGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatedTasksGrid.Name = "CreatedTasksGrid";
            this.CreatedTasksGrid.ReadOnly = true;
            this.CreatedTasksGrid.RowHeadersWidth = 51;
            this.CreatedTasksGrid.RowTemplate.Height = 24;
            this.CreatedTasksGrid.Size = new System.Drawing.Size(1314, 357);
            this.CreatedTasksGrid.TabIndex = 0;
            this.CreatedTasksGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            this.CreatedTasksGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // ClosedTasks
            // 
            this.ClosedTasks.Controls.Add(this.ComplitedTasksGrid);
            this.ClosedTasks.Location = new System.Drawing.Point(4, 25);
            this.ClosedTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClosedTasks.Name = "ClosedTasks";
            this.ClosedTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClosedTasks.Size = new System.Drawing.Size(1320, 361);
            this.ClosedTasks.TabIndex = 2;
            this.ClosedTasks.Text = "Закрыт Заявки";
            this.ClosedTasks.UseVisualStyleBackColor = true;
            this.ClosedTasks.Enter += new System.EventHandler(this.AwaitCompletedTasks);
            // 
            // ComplitedTasksGrid
            // 
            this.ComplitedTasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComplitedTasksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComplitedTasksGrid.Location = new System.Drawing.Point(3, 2);
            this.ComplitedTasksGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComplitedTasksGrid.Name = "ComplitedTasksGrid";
            this.ComplitedTasksGrid.ReadOnly = true;
            this.ComplitedTasksGrid.RowHeadersWidth = 51;
            this.ComplitedTasksGrid.RowTemplate.Height = 24;
            this.ComplitedTasksGrid.Size = new System.Drawing.Size(1314, 357);
            this.ComplitedTasksGrid.TabIndex = 0;
            this.ComplitedTasksGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            this.ComplitedTasksGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // FreeTasks
            // 
            this.FreeTasks.Controls.Add(this.FreeTasksGrid);
            this.FreeTasks.Location = new System.Drawing.Point(4, 25);
            this.FreeTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FreeTasks.Name = "FreeTasks";
            this.FreeTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FreeTasks.Size = new System.Drawing.Size(1320, 361);
            this.FreeTasks.TabIndex = 1;
            this.FreeTasks.Text = "Свободные Заявки";
            this.FreeTasks.UseVisualStyleBackColor = true;
            this.FreeTasks.Enter += new System.EventHandler(this.AwaitFreeTasks);
            // 
            // FreeTasksGrid
            // 
            this.FreeTasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreeTasksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreeTasksGrid.Location = new System.Drawing.Point(3, 2);
            this.FreeTasksGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FreeTasksGrid.Name = "FreeTasksGrid";
            this.FreeTasksGrid.ReadOnly = true;
            this.FreeTasksGrid.RowHeadersWidth = 51;
            this.FreeTasksGrid.RowTemplate.Height = 24;
            this.FreeTasksGrid.Size = new System.Drawing.Size(1314, 357);
            this.FreeTasksGrid.TabIndex = 0;
            this.FreeTasksGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            this.FreeTasksGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // AssignedTasks
            // 
            this.AssignedTasks.Controls.Add(this.AssignedTasksGrid);
            this.AssignedTasks.Location = new System.Drawing.Point(4, 25);
            this.AssignedTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignedTasks.Name = "AssignedTasks";
            this.AssignedTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignedTasks.Size = new System.Drawing.Size(1320, 361);
            this.AssignedTasks.TabIndex = 0;
            this.AssignedTasks.Text = "Назначенные заявки";
            this.AssignedTasks.UseVisualStyleBackColor = true;
            this.AssignedTasks.Enter += new System.EventHandler(this.AwaitAssignedTasks);
            // 
            // AssignedTasksGrid
            // 
            this.AssignedTasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignedTasksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignedTasksGrid.Location = new System.Drawing.Point(3, 2);
            this.AssignedTasksGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignedTasksGrid.Name = "AssignedTasksGrid";
            this.AssignedTasksGrid.ReadOnly = true;
            this.AssignedTasksGrid.RowHeadersWidth = 51;
            this.AssignedTasksGrid.RowTemplate.Height = 24;
            this.AssignedTasksGrid.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AssignedTasksGrid.Size = new System.Drawing.Size(1314, 357);
            this.AssignedTasksGrid.TabIndex = 0;
            this.AssignedTasksGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            this.AssignedTasksGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // TaskPanel
            // 
            this.TaskPanel.Controls.Add(this.AssignedTasks);
            this.TaskPanel.Controls.Add(this.FreeTasks);
            this.TaskPanel.Controls.Add(this.ClosedTasks);
            this.TaskPanel.Controls.Add(this.CreatedTasks);
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TaskPanel.Location = new System.Drawing.Point(0, 411);
            this.TaskPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.SelectedIndex = 0;
            this.TaskPanel.Size = new System.Drawing.Size(1328, 390);
            this.TaskPanel.TabIndex = 16;
            // 
            // ExportExcelReport
            // 
            this.ExportExcelReport.Location = new System.Drawing.Point(372, 101);
            this.ExportExcelReport.Name = "ExportExcelReport";
            this.ExportExcelReport.Size = new System.Drawing.Size(177, 23);
            this.ExportExcelReport.TabIndex = 18;
            this.ExportExcelReport.Text = "Создать Отчет";
            this.ExportExcelReport.UseVisualStyleBackColor = true;
            this.ExportExcelReport.Click += new System.EventHandler(this.ExportExcelReport_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 801);
            this.Controls.Add(this.ExportExcelReport);
            this.Controls.Add(this.CreatTask);
            this.Controls.Add(this.TaskPanel);
            this.Controls.Add(this.Departament);
            this.Controls.Add(this.Warehouse);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.DepartamentText);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.WarehouseText);
            this.Controls.Add(this.PositionText);
            this.Controls.Add(this.NameBoxText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.Text = "Форма Пользователя";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.CreatedTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreatedTasksGrid)).EndInit();
            this.ClosedTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComplitedTasksGrid)).EndInit();
            this.FreeTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FreeTasksGrid)).EndInit();
            this.AssignedTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AssignedTasksGrid)).EndInit();
            this.TaskPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBoxText;
        private System.Windows.Forms.TextBox PositionText;
        private System.Windows.Forms.TextBox WarehouseText;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.TextBox DepartamentText;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.TextBox Warehouse;
        private System.Windows.Forms.TextBox Departament;
        private System.Windows.Forms.Button CreatTask;
        private System.Windows.Forms.TabPage CreatedTasks;
        private System.Windows.Forms.DataGridView CreatedTasksGrid;
        private System.Windows.Forms.TabPage ClosedTasks;
        private System.Windows.Forms.DataGridView ComplitedTasksGrid;
        private System.Windows.Forms.TabPage FreeTasks;
        public System.Windows.Forms.DataGridView FreeTasksGrid;
        private System.Windows.Forms.TabPage AssignedTasks;
        private System.Windows.Forms.DataGridView AssignedTasksGrid;
        private System.Windows.Forms.TabControl TaskPanel;
        private System.Windows.Forms.Button ExportExcelReport;
    }
}

