using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDS.Context
{
    public class Tasks
    {
        public int id { get; set; }

        public int TaskInitiatorId { get; set; }
        public int? AssignedUserId { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public string Answer { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("getutcdate()")]
        public DateTime StartDate { get; set; }= DateTime.Now;

        public DateTime? EndDate { get; set; }

        public TaskStatus Status { get; set; }
        public TasksType Type { get; set; }
        public User TaskInitiator { get; set; }
        public User AssignedUser { get; set; }
    }
}
