
namespace ATDS
{
    partial class CreateTaskForm
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
            this.AssignedeSelf = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.PriorityText = new System.Windows.Forms.Label();
            this.AssignedeUserText = new System.Windows.Forms.Label();
            this.DescriptonText = new System.Windows.Forms.Label();
            this.TaskTypeText = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.Label();
            this.TaskTypeBox = new System.Windows.Forms.ComboBox();
            this.PriorityBox = new System.Windows.Forms.ComboBox();
            this.Descripton = new System.Windows.Forms.RichTextBox();
            this.AssignedeUserBox = new System.Windows.Forms.ComboBox();
            this.InformationGrid = new System.Windows.Forms.DataGridView();
            this.Information = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignedeSelf
            // 
            this.AssignedeSelf.Location = new System.Drawing.Point(868, 11);
            this.AssignedeSelf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignedeSelf.Name = "AssignedeSelf";
            this.AssignedeSelf.Size = new System.Drawing.Size(189, 53);
            this.AssignedeSelf.TabIndex = 29;
            this.AssignedeSelf.Text = "Создать Заявку";
            this.AssignedeSelf.UseVisualStyleBackColor = true;
            this.AssignedeSelf.Click += new System.EventHandler(this.AssignedeSelf_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(119, 11);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(159, 26);
            this.Title.TabIndex = 23;
            // 
            // PriorityText
            // 
            this.PriorityText.AutoSize = true;
            this.PriorityText.Location = new System.Drawing.Point(479, 15);
            this.PriorityText.Name = "PriorityText";
            this.PriorityText.Size = new System.Drawing.Size(79, 16);
            this.PriorityText.TabIndex = 21;
            this.PriorityText.Text = "Приоритет";
            // 
            // AssignedeUserText
            // 
            this.AssignedeUserText.AutoSize = true;
            this.AssignedeUserText.Location = new System.Drawing.Point(8, 80);
            this.AssignedeUserText.Name = "AssignedeUserText";
            this.AssignedeUserText.Size = new System.Drawing.Size(188, 16);
            this.AssignedeUserText.TabIndex = 20;
            this.AssignedeUserText.Text = "Назначеный Пользователь";
            // 
            // DescriptonText
            // 
            this.DescriptonText.AutoSize = true;
            this.DescriptonText.Location = new System.Drawing.Point(8, 149);
            this.DescriptonText.Name = "DescriptonText";
            this.DescriptonText.Size = new System.Drawing.Size(72, 16);
            this.DescriptonText.TabIndex = 18;
            this.DescriptonText.Text = "Описание";
            // 
            // TaskTypeText
            // 
            this.TaskTypeText.AutoSize = true;
            this.TaskTypeText.Location = new System.Drawing.Point(5, 46);
            this.TaskTypeText.Name = "TaskTypeText";
            this.TaskTypeText.Size = new System.Drawing.Size(91, 16);
            this.TaskTypeText.TabIndex = 17;
            this.TaskTypeText.Text = "Тип Задания";
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Location = new System.Drawing.Point(8, 15);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(73, 16);
            this.TitleText.TabIndex = 16;
            this.TitleText.Text = "Название";
            // 
            // TaskTypeBox
            // 
            this.TaskTypeBox.AllowDrop = true;
            this.TaskTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskTypeBox.FormattingEnabled = true;
            this.TaskTypeBox.Items.AddRange(new object[] {
            "Настройка топологии",
            "bio",
            "Агрегация",
            "Ошибка в задании",
            "Регестрация",
            "IS",
            "Добавление/Настройка Компаний",
            "Отчеты",
            "Выгрузка",
            "Заявки",
            "Угроза Безопасности",
            "Настройка Доступа",
            "Приемка",
            "Удаление/Настройка Погрузки/Отгрузки",
            "Ошибка системы",
            "Настройка Аппаратуры",
            "Другое"});
            this.TaskTypeBox.Location = new System.Drawing.Point(119, 42);
            this.TaskTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskTypeBox.Name = "TaskTypeBox";
            this.TaskTypeBox.Size = new System.Drawing.Size(299, 24);
            this.TaskTypeBox.TabIndex = 30;
            this.TaskTypeBox.SelectedIndexChanged += new System.EventHandler(this.AssignedeUserBox_SelectedIndexChanged);
            // 
            // PriorityBox
            // 
            this.PriorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityBox.Items.AddRange(new object[] {
            "Высокий",
            "Средний"});
            this.PriorityBox.Location = new System.Drawing.Point(585, 10);
            this.PriorityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(141, 24);
            this.PriorityBox.TabIndex = 32;
            // 
            // Descripton
            // 
            this.Descripton.Location = new System.Drawing.Point(100, 149);
            this.Descripton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Descripton.Name = "Descripton";
            this.Descripton.Size = new System.Drawing.Size(329, 251);
            this.Descripton.TabIndex = 34;
            this.Descripton.Text = "";
            // 
            // AssignedeUserBox
            // 
            this.AssignedeUserBox.AllowDrop = true;
            this.AssignedeUserBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssignedeUserBox.FormattingEnabled = true;
            this.AssignedeUserBox.Location = new System.Drawing.Point(236, 76);
            this.AssignedeUserBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignedeUserBox.Name = "AssignedeUserBox";
            this.AssignedeUserBox.Size = new System.Drawing.Size(181, 24);
            this.AssignedeUserBox.TabIndex = 35;
            this.AssignedeUserBox.SelectedIndexChanged += new System.EventHandler(this.AssignedeUserBox_SelectedIndexChanged);
            // 
            // InformationGrid
            // 
            this.InformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InformationGrid.Location = new System.Drawing.Point(581, 149);
            this.InformationGrid.Margin = new System.Windows.Forms.Padding(4);
            this.InformationGrid.Name = "InformationGrid";
            this.InformationGrid.ReadOnly = true;
            this.InformationGrid.RowHeadersWidth = 51;
            this.InformationGrid.Size = new System.Drawing.Size(476, 252);
            this.InformationGrid.TabIndex = 36;
            this.InformationGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InformationGrid_CellContentClick);
           
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Location = new System.Drawing.Point(444, 149);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(106, 32);
            this.Information.TabIndex = 37;
            this.Information.Text = "Информация о \r\nпользователе";
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.InformationGrid);
            this.Controls.Add(this.AssignedeUserBox);
            this.Controls.Add(this.Descripton);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.TaskTypeBox);
            this.Controls.Add(this.AssignedeSelf);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PriorityText);
            this.Controls.Add(this.AssignedeUserText);
            this.Controls.Add(this.DescriptonText);
            this.Controls.Add(this.TaskTypeText);
            this.Controls.Add(this.TitleText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateTaskForm";
            this.Text = "Создание заявки";
            this.Load += new System.EventHandler(this.CreateTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AssignedeSelf;
        public System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label PriorityText;
        private System.Windows.Forms.Label AssignedeUserText;
        private System.Windows.Forms.Label DescriptonText;
        private System.Windows.Forms.Label TaskTypeText;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.ComboBox TaskTypeBox;
        private System.Windows.Forms.ComboBox PriorityBox;
        private System.Windows.Forms.RichTextBox Descripton;
        private System.Windows.Forms.ComboBox AssignedeUserBox;
        private System.Windows.Forms.DataGridView InformationGrid;
        private System.Windows.Forms.Label Information;
    }
}