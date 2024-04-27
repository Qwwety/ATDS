using ATDS.Context;
using ATDS.DTOs;
using ATDS.Enums;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDS
{
    public partial class TasksForm : Form
    {
        private ATDSContext context_;
        string LogPath = @"\C#\Diplom\Automatic task delivery system(ATDS)\ATDS\Logs.Txt";

        public Func<object, EventArgs,Task> action_;

        public int TaskID;
        public int CurrentUser;

        public TasksForm(TasksDTO task, ATDSContext context, Func<object, EventArgs,Task> action)
        {
            this.context_ = context;
            this.action_ = action;
            InitializeComponent();
            SetFromData(task);
        }

        private void SetFromData (TasksDTO task)
        {
            TaskID = task.id;
            Title.Text = task.Title;
            TaskType.Text = task.TaskTypeName;
            Initiator.Text = task.TaskInitiatorName;
            Assigned.Text = task.AssignedUserName;
            Descripton.Text = task.Description;
            Status.Text = task.TaskStatusName;
            Priority.Text = task.Priority.ToString();
            StartDate.Text = task.StartDate.ToString();
            CloseDate.Text = task.EndDate.ToString();
            Answer.Text = task.Answer;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private async void AssignedeSelf_Click(object sender, EventArgs e)
        {

            try
            {
                var Task = await context_.Task.Where(x => x.id == TaskID).FirstAsync();
                Task.StatusId = (int)TaskStatusEnum.InWork;
                Task.AssignedUserId = CurrentUser;
                context_.Task.AddOrUpdate(Task);
                await context_.SaveChangesAsync();
                await action_.Invoke(sender, e);
                this.Close();

            }
            catch (Exception ex)
            {
                File.AppendAllText(LogPath, ex.Message + "\n");
            }
        }
        private async void CloseTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Answer.Text))
                {
                    var Task = await context_.Task.Where(x => x.id == TaskID).FirstAsync();
                    Task.StatusId = (int)TaskStatusEnum.Complete;
                    Task.Answer = Answer.Text;
                    Task.EndDate = DateTime.Now;
                    context_.Task.AddOrUpdate(Task);
                    await context_.SaveChangesAsync();

                    await action_.Invoke(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Поле 'Ответ' не заполнено");
                }
            } 
            catch (Exception ex)
            {
                File.AppendAllText(LogPath, ex.Message + "\n");
            }
        }

        private void AssignedText_Click(object sender, EventArgs e)
        {

        }
    }
}
