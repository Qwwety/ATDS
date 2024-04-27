using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATDS.Context;
using System.Data.Entity;
using ATDS.DTOs;
using ATDS.Enums;

using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.Formula.Functions;

namespace ATDS
{
    public partial class UserForm : Form
    {
        private ATDSContext context_;
        string LogPath = @"\C#\Diplom\Automatic task delivery system(ATDS)\ATDS\Logs.Txt";
        string ReportsPath = @"\C#\Diplom\Automatic task delivery system(ATDS)\ATDS\Reports\";

        public int SelectedRow;

        public Dictionary<int, List<TasksDTO>> keyValues = new Dictionary<int, List<TasksDTO>>();

        public Func<object, EventArgs, Task> action;


        public async Task FullUpdateUserFrom(object sender, EventArgs e)
        {
            await SetAssignedTasks(sender, e);
            await SetFreeTasks(sender, e);
            await SetCompletedTasks(sender, e);
            await SetCreatedTasks(sender, e);
        }


        public int CurrentUserId;

        DataGridView gridView = new DataGridView();

        public UserForm(ATDSContext context)
        {
            this.context_ = context;

            InitializeComponent();
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            action = async (object a, EventArgs b) => await FullUpdateUserFrom(a, b);
            await SetUserData();
            await FullUpdateUserFrom(sender, e);
        }


        private async Task SetUserData()
        {

            var User = await context_.User
                .Include(x => x.Position)
                .Include(x => x.Warehouse)
                .Include(x => x.Status)
                .Where(x => x.Id == CurrentUserId).FirstOrDefaultAsync();

            UserName.Text = User?.Name + " " + User?.SecondName;
            Position.Text = User?.Position?.Name;
            Warehouse.Text = User?.Warehouse?.Name;

            if (User?.Status?.Id == 2)
                Status.Checked = true;
            else
                Status.Checked = false;

            Departament.Text = User?.Departament?.Name;
        }



        private async void AwaitAssignedTasks(object sender, EventArgs e)
        {
            await SetAssignedTasks(sender, e);
        }
        private async void AwaitFreeTasks(object sender, EventArgs e)
        {
            await SetFreeTasks(sender, e);
        }
        private async void AwaitCompletedTasks(object sender, EventArgs e)
        {
            await SetCompletedTasks(sender, e);
        }
        private async void AwaitCreatedTasks(object sender, EventArgs e)
        {
            await SetCreatedTasks(sender, e);
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

        private async Task SetAssignedTasks(object sender, EventArgs e)
        {
            var localResult = await context_.Task
                .Include(x => x.TaskInitiator)
                .Include(x => x.AssignedUser)
                .Include(x => x.Status)
                .Include(x => x.Type)
                .Where(x => x.AssignedUser.Id == CurrentUserId && x.Status.Id == (int)TaskStatusEnum.InWork)
                .ToListAsync();

            var result = ConvertToTasksDTO(localResult);

          

            AssignedTasksGrid.DataSource = result;
            AssignedTasksGrid.Columns[0].Visible = false;
            AssignedTasksGrid.Columns[1].HeaderText = "Название Заявки";
            AssignedTasksGrid.Columns[2].HeaderText = "Тип Задания";
            AssignedTasksGrid.Columns[3].HeaderText = "Инициатор";
            AssignedTasksGrid.Columns[4].HeaderText = "Назначеный Пользователь";
            AssignedTasksGrid.Columns[5].HeaderText = "Описане";
            AssignedTasksGrid.Columns[6].HeaderText = "Статус";
            AssignedTasksGrid.Columns[7].HeaderText = "Приоритет";
            AssignedTasksGrid.Columns[9].HeaderText = "Дата Открытия Заявки";
            AssignedTasksGrid.Columns[10].HeaderText = "Дата Закрытия Заявки";
            AssignedTasksGrid.Columns[8].HeaderText = "Ответ";
            gridView = AssignedTasksGrid;

            if(!keyValues.ContainsKey(0))
                keyValues.Add(0, result);
            else
            {
                keyValues.Remove(0);
                keyValues.Add(0, result);
            }

            //SetUserStatus();

        }
        private async Task SetFreeTasks(object sender, EventArgs e)
        {
            var localResult = await context_.Task
                .Include(x => x.TaskInitiator)
                .Include(x => x.Status)
                .Include(x => x.Type)
                .Where(x => x.Status.Id == (int)TaskStatusEnum.Open)
                .ToListAsync();

            var result = ConvertToTasksDTO(localResult);

            FreeTasksGrid.DataSource = result;
            FreeTasksGrid.Columns[0].Visible = false;
            FreeTasksGrid.Columns[1].HeaderText = "Название Заявки";
            FreeTasksGrid.Columns[2].HeaderText = "Тип Задания";
            FreeTasksGrid.Columns[3].HeaderText = "Инициатор";
            FreeTasksGrid.Columns[4].Visible = false;
            FreeTasksGrid.Columns[5].HeaderText = "Описане";
            FreeTasksGrid.Columns[6].HeaderText = "Статус";
            FreeTasksGrid.Columns[7].HeaderText = "Приоритет";
            FreeTasksGrid.Columns[9].HeaderText = "Дата Открытия Заявки";
            FreeTasksGrid.Columns[10].HeaderText = "Дата Закрытия Заявки";
            FreeTasksGrid.Columns[8].HeaderText = "Ответ";
            gridView = FreeTasksGrid;

            if (!keyValues.ContainsKey(1))
                keyValues.Add(1, result);
            else
            {
                keyValues.Remove(1);
                keyValues.Add(1, result);
            }
        }
        private async Task SetCompletedTasks(object sender, EventArgs e)
        {
            var localResult = await context_.Task
               .Include(x => x.TaskInitiator)
               .Include(x => x.AssignedUser)
               .Include(x => x.Status)
               .Include(x => x.Type)
               .Where(x => x.AssignedUser.Id == CurrentUserId && x.Status.Id == (int)TaskStatusEnum.Complete)
               .ToListAsync();

            var result = ConvertToTasksDTO(localResult);

            ComplitedTasksGrid.DataSource = result;
            ComplitedTasksGrid.Columns[0].Visible = false;
            ComplitedTasksGrid.Columns[1].HeaderText = "Название Заявки";
            ComplitedTasksGrid.Columns[2].HeaderText = "Тип Задания";
            ComplitedTasksGrid.Columns[3].HeaderText = "Инициатор";
            ComplitedTasksGrid.Columns[4].HeaderText = "Назначеный Пользователь";
            ComplitedTasksGrid.Columns[5].HeaderText = "Описане";
            ComplitedTasksGrid.Columns[6].HeaderText = "Статус";
            ComplitedTasksGrid.Columns[7].HeaderText = "Приоритет";
            ComplitedTasksGrid.Columns[9].HeaderText = "Дата Открытия Заявки";
            ComplitedTasksGrid.Columns[10].HeaderText = "Дата Закрытия Заявки";
            ComplitedTasksGrid.Columns[8].HeaderText = "Ответ";
            gridView = ComplitedTasksGrid;

            if (!keyValues.ContainsKey(2))
                keyValues.Add(2, result);
            else
            {
                keyValues.Remove(2);
                keyValues.Add(2, result);
            }
        }
        private async Task SetCreatedTasks(object sender, EventArgs e)
        {
            var localResult = await context_.Task
              .Include(x => x.TaskInitiator)
              .Include(x => x.AssignedUser)
              .Include(x => x.Status)
              .Include(x => x.Type)
              .Where(x => x.TaskInitiator.Id == CurrentUserId)
              .ToListAsync();

            var result = ConvertToTasksDTO(localResult);

            CreatedTasksGrid.DataSource = result;
            CreatedTasksGrid.Columns[0].Visible = false;
            CreatedTasksGrid.Columns[1].HeaderText = "Название Заявки";
            CreatedTasksGrid.Columns[2].HeaderText = "Тип Задания";
            CreatedTasksGrid.Columns[3].HeaderText = "Инициатор";
            CreatedTasksGrid.Columns[4].Visible = false;
            CreatedTasksGrid.Columns[5].HeaderText = "Описане";
            CreatedTasksGrid.Columns[6].HeaderText = "Статус";
            CreatedTasksGrid.Columns[7].HeaderText = "Приоритет";
            CreatedTasksGrid.Columns[9].HeaderText = "Дата Открытия Заявки";
            CreatedTasksGrid.Columns[10].HeaderText = "Дата Закрытия Заявки";
            CreatedTasksGrid.Columns[8].HeaderText = "Ответ";
            gridView = CreatedTasksGrid;

            if (!keyValues.ContainsKey(3))
                keyValues.Add(3, result);
            else
            {
                keyValues.Remove(3);
                keyValues.Add(3, result);
            }
        }

        private async void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedRow = e.RowIndex;
                var taskDTO = new TasksDTO(gridView, SelectedRow);

                TasksForm TasksForm = new TasksForm(taskDTO, context_, action);

                //TasksForm.TaskID = Convert.ToInt32(gridView.Rows[SelectedRow].Cells[0].Value);
                //TasksForm.Title.Text = gridView.Rows[SelectedRow].Cells[1].Value.ToString();
                //TasksForm.TaskType.Text = gridView.Rows[SelectedRow].Cells[2].Value.ToString();
                //TasksForm.Initiator.Text = gridView.Rows[SelectedRow].Cells[3].Value.ToString();
                //TasksForm.Assigned.Text = gridView.Rows[SelectedRow].Cells[4].Value.ToString();
                //TasksForm.Descripton.Text = gridView.Rows[SelectedRow].Cells[5].Value.ToString();
                //TasksForm.Status.Text = gridView.Rows[SelectedRow].Cells[6].Value.ToString();
                //TasksForm.Priority.Text = gridView.Rows[SelectedRow].Cells[7].Value.ToString();
                //TasksForm.StartDate.Text = gridView.Rows[SelectedRow].Cells[8].Value.ToString();
                //TasksForm.CloseDate.Text = gridView.Rows[SelectedRow].Cells[9].Value.ToString();
                //TasksForm.Answer.Text = gridView.Rows[SelectedRow].Cells[10].Value.ToString();

                if (gridView == FreeTasksGrid)
                {
                    TasksForm.AssignedeSelf.Visible = true;
                    TasksForm.Assigned.Visible = false;
                    TasksForm.AssignedText.Visible = false;
                }
                else if (gridView == AssignedTasksGrid)
                {
                    TasksForm.CloseTask.Visible = true;
                    TasksForm.Answer.ReadOnly = false;
                    TasksForm.Answer.Enabled = true;
                }
                TasksForm.CurrentUser = CurrentUserId;
                TasksForm.ShowDialog();

                if (gridView == FreeTasksGrid)
                {
                    await SetFreeTasks(sender, e);
                }
                else if (gridView == AssignedTasksGrid)
                {
                    await SetAssignedTasks(sender, e);
                }
            }
            catch { }
        }


        private void CreatTask_Click(object sender, EventArgs e)
        {
            CreateTaskForm CreateForm = new CreateTaskForm(context_, action);
            CreateForm.CurrentUserId = CurrentUserId;
            CreateForm.ShowDialog();

        }

        private void ExportExcelReport_Click(object sender, EventArgs e)
        {

            HSSFWorkbook workbook = new HSSFWorkbook();

            ISheet Sheet = null;

          

            foreach (var item in keyValues) 
            {
                var RowIndex = 1;

                Sheet = workbook.CreateSheet("Отчет" + item.Key);

                IRow HeaderRow = Sheet.CreateRow(0);
                //Create The Actual Cells
                CreateCell(HeaderRow, 1, "Инициатор", null);
                CreateCell(HeaderRow, 2, "Назначенный пользователь", null);
                CreateCell(HeaderRow, 3, "Название Заявки", null);
                CreateCell(HeaderRow, 4, "Тип Задания", null);
                CreateCell(HeaderRow, 5, "Описане", null);
                CreateCell(HeaderRow, 6, "Статус", null);
                CreateCell(HeaderRow, 7, "Приоритет", null);
                CreateCell(HeaderRow, 8, "Ответ", null);
                CreateCell(HeaderRow, 9, "Дата Открытия Заявки", null);
                CreateCell(HeaderRow, 10, "Дата Закрытия Заявки", null);

               
               

                var localResult = keyValues.TryGetValue(item.Key, out var values)
                    ?values
                    :null ;

                

                foreach (var value in localResult)
                {
                    var CurrentRow = Sheet.CreateRow(RowIndex);

                    CreateCell(CurrentRow, 1, value.TaskInitiatorName, null);
                    CreateCell(CurrentRow, 2, value.AssignedUserName, null);
                    CreateCell(CurrentRow, 3, value.Title, null);
                    CreateCell(CurrentRow, 4, value.TaskTypeName, null);
                    CreateCell(CurrentRow, 5, value.Description, null);
                    CreateCell(CurrentRow, 6, value.TaskStatusName, null);
                    CreateCell(CurrentRow, 7, value.Priority.ToString(), null);
                    CreateCell(CurrentRow, 8, value.Answer, null);
                    CreateCell(CurrentRow, 9, value.StartDate.ToString(), null);
                    CreateCell(CurrentRow, 10, value.EndDate.ToString(), null);
                    RowIndex++;
                }

            }

            int lastColumNum = Sheet.GetRow(0).LastCellNum;
            for (int i = 0; i <= lastColumNum; i++)
            {
                Sheet.AutoSizeColumn(i);
                GC.Collect();
            }
            // Write Excel to disk 
            using (var fileData = new FileStream(ReportsPath+ "Report.xls", FileMode.Create))
            {
                workbook.Write(fileData);
            }


        }

        private void CreateCell(IRow CurrentRow, int CellIndex, string Value, HSSFCellStyle Style)
        {
            ICell Cell = CurrentRow.CreateCell(CellIndex);
            Cell.SetCellValue(Value);
            Cell.CellStyle = Style;
        }



        

    }
}
