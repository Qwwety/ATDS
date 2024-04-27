using ATDS.Context;
using System;
using System.Windows.Forms;

namespace ATDS.DTOs
{
    public class TasksDTO
    {
        public int id { get; set; }
        public string TaskInitiatorName { get; set; }
        public string AssignedUserName { get; set; }
        public string Title { get; set; }
        public string TaskTypeName { get; set; }
        public string Description { get; set; }
        public string TaskStatusName { get; set; }

        public int Priority { get; set; }
        public string Answer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public TasksDTO(Tasks tasks)
        {
            id = tasks.id;
            TaskInitiatorName = tasks?.TaskInitiator?.Name;
            AssignedUserName=tasks?.AssignedUser?.Name;
            Title = tasks?.Title;
            TaskTypeName=tasks?.Type?.Name;
            Description = tasks?.Description;
            TaskStatusName = tasks?.Status?.Name;
            Priority = tasks.Priority;
            Answer = tasks?.Answer;
            StartDate = tasks.StartDate;
            EndDate = tasks.EndDate;
        }

        public TasksDTO(DataGridView dataGridView, int SelectedRow)
        {
            id = Convert.ToInt32(dataGridView.Rows[SelectedRow].Cells[0].Value);
            Title = dataGridView.Rows[SelectedRow].Cells[1].Value?.ToString();
            TaskTypeName = dataGridView.Rows[SelectedRow].Cells[2].Value?.ToString();
            TaskInitiatorName = dataGridView.Rows[SelectedRow].Cells[3].Value?.ToString();
            AssignedUserName = dataGridView.Rows[SelectedRow].Cells[4].Value?.ToString();
            Description = dataGridView.Rows[SelectedRow].Cells[5].Value?.ToString();
            TaskStatusName = dataGridView.Rows[SelectedRow].Cells[6].Value?.ToString();
            Priority = Convert.ToInt32(dataGridView.Rows[SelectedRow].Cells[7].Value);
            StartDate = Convert.ToDateTime(dataGridView.Rows[SelectedRow].Cells[9].Value);

            if(dataGridView.Rows[SelectedRow].Cells[10].Value != null)
            {
                EndDate = Convert.ToDateTime(dataGridView.Rows[SelectedRow].Cells[10].Value);
            }

            Answer = dataGridView.Rows[SelectedRow].Cells[8].Value?.ToString();
        }
    }
}
