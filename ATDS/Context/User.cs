using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDS.Context
{
    public class User
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public int WarehouseId { get; set; }
        public int StatusId { get; set; }
        public int DepartamentId { get; set; }

        public string Password { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }

        public UserPosition Position { get; set; }
        public Warehouse Warehouse { get; set; }
        public UserStatus Status { get; set; }
        public Departament Departament { get; set; }
        
    }
}
