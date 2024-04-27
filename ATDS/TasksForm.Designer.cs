
namespace ATDS
{
    partial class TasksForm
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
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.AnswerText = new System.Windows.Forms.Label();
            this.CloseDate = new System.Windows.Forms.TextBox();
            this.CloseDateText = new System.Windows.Forms.Label();
            this.Assigned = new System.Windows.Forms.TextBox();
            this.AssignedText = new System.Windows.Forms.Label();
            this.Descripton = new System.Windows.Forms.RichTextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.Initiator = new System.Windows.Forms.TextBox();
            this.TaskType = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.StartDateText = new System.Windows.Forms.Label();
            this.PriorityText = new System.Windows.Forms.Label();
            this.InitiatorText = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.DescriptonText = new System.Windows.Forms.Label();
            this.TaskTypeText = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.Label();
            this.CloseTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssignedeSelf
            // 
            this.AssignedeSelf.Location = new System.Drawing.Point(875, 14);
            this.AssignedeSelf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignedeSelf.Name = "AssignedeSelf";
            this.AssignedeSelf.Size = new System.Drawing.Size(189, 53);
            this.AssignedeSelf.TabIndex = 15;
            this.AssignedeSelf.Text = "Назначить Себя";
            this.AssignedeSelf.UseVisualStyleBackColor = true;
            this.AssignedeSelf.Visible = false;
            this.AssignedeSelf.Click += new System.EventHandler(this.AssignedeSelf_Click);
            // 
            // Answer
            // 
            this.Answer.Enabled = false;
            this.Answer.Location = new System.Drawing.Point(600, 206);
            this.Answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(400, 229);
            this.Answer.TabIndex = 56;
            this.Answer.Text = "";
            // 
            // AnswerText
            // 
            this.AnswerText.AutoSize = true;
            this.AnswerText.Location = new System.Drawing.Point(536, 206);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(48, 17);
            this.AnswerText.TabIndex = 55;
            this.AnswerText.Text = "Ответ";
            // 
            // CloseDate
            // 
            this.CloseDate.Enabled = false;
            this.CloseDate.Location = new System.Drawing.Point(684, 46);
            this.CloseDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseDate.Name = "CloseDate";
            this.CloseDate.ReadOnly = true;
            this.CloseDate.Size = new System.Drawing.Size(145, 22);
            this.CloseDate.TabIndex = 54;
            // 
            // CloseDateText
            // 
            this.CloseDateText.AutoSize = true;
            this.CloseDateText.Location = new System.Drawing.Point(475, 50);
            this.CloseDateText.Name = "CloseDateText";
            this.CloseDateText.Size = new System.Drawing.Size(162, 17);
            this.CloseDateText.TabIndex = 53;
            this.CloseDateText.Text = "Дата Закрытия Заявки";
            // 
            // Assigned
            // 
            this.Assigned.Enabled = false;
            this.Assigned.Location = new System.Drawing.Point(248, 112);
            this.Assigned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Assigned.Name = "Assigned";
            this.Assigned.ReadOnly = true;
            this.Assigned.Size = new System.Drawing.Size(160, 22);
            this.Assigned.TabIndex = 52;
            // 
            // AssignedText
            // 
            this.AssignedText.AutoSize = true;
            this.AssignedText.Location = new System.Drawing.Point(20, 112);
            this.AssignedText.Name = "AssignedText";
            this.AssignedText.Size = new System.Drawing.Size(188, 17);
            this.AssignedText.TabIndex = 51;
            this.AssignedText.Text = "Назначеный Пользователь";
            this.AssignedText.Click += new System.EventHandler(this.AssignedText_Click);
            // 
            // Descripton
            // 
            this.Descripton.Enabled = false;
            this.Descripton.Location = new System.Drawing.Point(97, 209);
            this.Descripton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Descripton.Name = "Descripton";
            this.Descripton.ReadOnly = true;
            this.Descripton.Size = new System.Drawing.Size(400, 226);
            this.Descripton.TabIndex = 50;
            this.Descripton.Text = "";
            // 
            // Status
            // 
            this.Status.Enabled = false;
            this.Status.Location = new System.Drawing.Point(684, 106);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Size = new System.Drawing.Size(145, 22);
            this.Status.TabIndex = 49;
            // 
            // Priority
            // 
            this.Priority.Enabled = false;
            this.Priority.Location = new System.Drawing.Point(684, 76);
            this.Priority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Size = new System.Drawing.Size(145, 22);
            this.Priority.TabIndex = 48;
            // 
            // StartDate
            // 
            this.StartDate.Enabled = false;
            this.StartDate.Location = new System.Drawing.Point(684, 16);
            this.StartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Size = new System.Drawing.Size(145, 22);
            this.StartDate.TabIndex = 47;
            // 
            // Initiator
            // 
            this.Initiator.Enabled = false;
            this.Initiator.Location = new System.Drawing.Point(248, 76);
            this.Initiator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Initiator.Name = "Initiator";
            this.Initiator.ReadOnly = true;
            this.Initiator.Size = new System.Drawing.Size(160, 22);
            this.Initiator.TabIndex = 46;
            // 
            // TaskType
            // 
            this.TaskType.Enabled = false;
            this.TaskType.Location = new System.Drawing.Point(248, 43);
            this.TaskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskType.Name = "TaskType";
            this.TaskType.ReadOnly = true;
            this.TaskType.Size = new System.Drawing.Size(160, 22);
            this.TaskType.TabIndex = 45;
            // 
            // Title
            // 
            this.Title.Enabled = false;
            this.Title.Location = new System.Drawing.Point(248, 15);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(160, 22);
            this.Title.TabIndex = 44;
            // 
            // StartDateText
            // 
            this.StartDateText.AutoSize = true;
            this.StartDateText.Location = new System.Drawing.Point(475, 21);
            this.StartDateText.Name = "StartDateText";
            this.StartDateText.Size = new System.Drawing.Size(163, 17);
            this.StartDateText.TabIndex = 43;
            this.StartDateText.Text = "Дата Открытия Заявки";
            // 
            // PriorityText
            // 
            this.PriorityText.AutoSize = true;
            this.PriorityText.Location = new System.Drawing.Point(475, 82);
            this.PriorityText.Name = "PriorityText";
            this.PriorityText.Size = new System.Drawing.Size(80, 17);
            this.PriorityText.TabIndex = 42;
            this.PriorityText.Text = "Приоритет";
            // 
            // InitiatorText
            // 
            this.InitiatorText.AutoSize = true;
            this.InitiatorText.Location = new System.Drawing.Point(64, 82);
            this.InitiatorText.Name = "InitiatorText";
            this.InitiatorText.Size = new System.Drawing.Size(81, 17);
            this.InitiatorText.TabIndex = 41;
            this.InitiatorText.Text = "Инициатор";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(475, 110);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(53, 17);
            this.StatusText.TabIndex = 40;
            this.StatusText.Text = "Статус";
            // 
            // DescriptonText
            // 
            this.DescriptonText.AutoSize = true;
            this.DescriptonText.Location = new System.Drawing.Point(7, 209);
            this.DescriptonText.Name = "DescriptonText";
            this.DescriptonText.Size = new System.Drawing.Size(74, 17);
            this.DescriptonText.TabIndex = 39;
            this.DescriptonText.Text = "Описание";
            // 
            // TaskTypeText
            // 
            this.TaskTypeText.AutoSize = true;
            this.TaskTypeText.Location = new System.Drawing.Point(64, 49);
            this.TaskTypeText.Name = "TaskTypeText";
            this.TaskTypeText.Size = new System.Drawing.Size(94, 17);
            this.TaskTypeText.TabIndex = 38;
            this.TaskTypeText.Text = "Тип Задания";
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Location = new System.Drawing.Point(64, 18);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(72, 17);
            this.TitleText.TabIndex = 37;
            this.TitleText.Text = "Название";
            // 
            // CloseTask
            // 
            this.CloseTask.Location = new System.Drawing.Point(875, 71);
            this.CloseTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseTask.Name = "CloseTask";
            this.CloseTask.Size = new System.Drawing.Size(189, 53);
            this.CloseTask.TabIndex = 57;
            this.CloseTask.Text = "Закрыть Заявку";
            this.CloseTask.UseVisualStyleBackColor = true;
            this.CloseTask.Visible = false;
            this.CloseTask.Click += new System.EventHandler(this.CloseTask_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 463);
            this.Controls.Add(this.CloseTask);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.CloseDate);
            this.Controls.Add(this.CloseDateText);
            this.Controls.Add(this.Assigned);
            this.Controls.Add(this.AssignedText);
            this.Controls.Add(this.Descripton);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Initiator);
            this.Controls.Add(this.TaskType);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.StartDateText);
            this.Controls.Add(this.PriorityText);
            this.Controls.Add(this.InitiatorText);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.DescriptonText);
            this.Controls.Add(this.TaskTypeText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.AssignedeSelf);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button AssignedeSelf;
        public System.Windows.Forms.RichTextBox Answer;
        private System.Windows.Forms.Label AnswerText;
        public System.Windows.Forms.TextBox CloseDate;
        private System.Windows.Forms.Label CloseDateText;
        public System.Windows.Forms.TextBox Assigned;
        public System.Windows.Forms.Label AssignedText;
        public System.Windows.Forms.RichTextBox Descripton;
        public System.Windows.Forms.TextBox Status;
        public System.Windows.Forms.TextBox Priority;
        public System.Windows.Forms.TextBox StartDate;
        public System.Windows.Forms.TextBox Initiator;
        public System.Windows.Forms.TextBox TaskType;
        public System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label StartDateText;
        private System.Windows.Forms.Label PriorityText;
        private System.Windows.Forms.Label InitiatorText;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label DescriptonText;
        private System.Windows.Forms.Label TaskTypeText;
        private System.Windows.Forms.Label TitleText;
        public System.Windows.Forms.Button CloseTask;
    }
}