using ATDS.Context;
using ATDS.DTOs;
using ATDS.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDS
{
    public partial class CreateTaskForm : Form
    {
        private ATDSContext context_;
        string LogPath = @"\C#\Diplom\Automatic task delivery system(ATDS)\ATDS\Logs.Txt";
        public Func<object, EventArgs, Task> action_;

        public int SelectedRow;

        private DataTable DataTable;
        public int CurrentUserId;
        int AssignedeUser = 1;

        public CreateTaskForm(ATDSContext context, Func<object, EventArgs, Task> action)
        {
            this.context_ = context;
            this.action_ = action;
            InitializeComponent();
        }
        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            SetUsers();

        }
        private async void SetUsers()
        {
            var Users = await context_.User
                .Include(x=>x.Status)
                .Select(x => new { x.Name,  x.StatusId,x.Status }).ToListAsync();

            foreach (var User in Users)
            {
                AssignedeUserBox.Items.Add(User.Name +"|"+ User.Status.Name);
            }

            PriorityBox.Text = "Средний";
        }
        private async void AssignedeSelf_Click(object sender, EventArgs e)
        {
            if (Title.Text != "" && TaskTypeBox.Text != "" && PriorityBox.Text != "")
            {

                var task = new Tasks();
                task.Title = Title.Text;
                task.TypeId = 1;
                task.TaskInitiatorId = CurrentUserId;

                if (AssignedeUserBox.Text != "")
                    task.AssignedUserId = AssignedeUser += AssignedeUserBox.SelectedIndex;

                task.Description = Descripton.Text;
                task.StatusId = (int)TaskStatusEnum.InWork;
                task.Priority = 1;
                context_.Task.Add(task);
                await  context_.SaveChangesAsync();
                await action_.Invoke(sender, e);
                this.Close();


                //         if (AssignedeUserBox.Text != "")
                //         {
                //             AssignedeUser += AssignedeUserBox.SelectedIndex;
                //             SqlCommand cmd = new SqlCommand("Insert into Tasks " +
                //     "(Title," +
                //     "TaskType," +
                //     "ID_Initiator," +
                //     "ID_AssignedeUser," +
                //     "Descripton,Status,Priority,StartDate) " +
                //     "Values(" +
                //     "N'" + Title.Text + "', " +
                //     "N'" + TaskTypeBox.Text + "'," + CurrentUser + "," + AssignedeUser + ", N'" + Descripton.Text + "', " +
                //     "N'В работе'," +
                //     " N'" + PriorityBox.Text + "'," +
                //     " GETDATE())", SqlConnection);

                //             cmd.ExecuteNonQuery();
                //             AssignedeUser = 1;
                //         }
                //         else
                //         {
                //             SqlCommand cmd = new SqlCommand("" +
                //"Insert into Tasks (Title,TaskType,ID_Initiator,Descripton,Status,Priority,StartDate) " +
                //  "Values(N'" + Title.Text + "', " +
                //  "N'" + TaskTypeBox.Text + "'," +
                //  "" + CurrentUser + ", N'" + 
                //  Descripton.Text + "', " +
                //  "N'Свободно', " +
                //  "N'" + PriorityBox.Text + "'" +
                //  ", GETDATE())", SqlConnection);
                //             cmd.ExecuteNonQuery();
                //         }

            }
            else
            {
                MessageBox.Show("Обязательный поля не введены");
            }
        }

        private List<TasksDTO> ConvertToTasksDTO(List<Tasks> tasks)
        {


            var result = new List<TasksDTO>();

            foreach (var item in tasks)
            {
                result.Add(new TasksDTO(item));
            }

            return result;
        }


        private async void AssignedeUserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignedeUser += AssignedeUserBox.SelectedIndex;

            var Tasks= await context_.Task
                .Include(x=>x.TaskInitiator)
                .Include(x=>x.AssignedUser)
                .Where(x=>x.AssignedUserId== AssignedeUser).ToListAsync();

            var result = ConvertToTasksDTO(Tasks);

            InformationGrid.DataSource = result;
            InformationGrid.Columns[0].Visible = false;
            InformationGrid.Columns[1].HeaderText = "Название Заявки";
            InformationGrid.Columns[2].HeaderText = "Тип Задания";
            InformationGrid.Columns[3].HeaderText = "Инициатор";
            InformationGrid.Columns[4].Visible = false;
            InformationGrid.Columns[5].HeaderText = "Описане";
            InformationGrid.Columns[6].HeaderText = "Статус";
            InformationGrid.Columns[7].HeaderText = "Приоритет";
            InformationGrid.Columns[9].HeaderText = "Дата Открытия Заявки";
            InformationGrid.Columns[10].HeaderText = "Дата Закрытия Заявки";
            InformationGrid.Columns[8].HeaderText = "Ответ";
            AssignedeUser = 1;
        }

        //private void InformationGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        SelectedRow = e.RowIndex;

        //        var taskDTO = new TasksDTO(InformationGrid, SelectedRow);
        //        TasksForm form2 = new TasksForm(taskDTO,context_);

        //        form2.ShowDialog();
        //        MessageBox.Show(gridView.Name.ToString());
        //    }
        //    catch { }
        //}

        private void InformationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
