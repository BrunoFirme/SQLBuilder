using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SQLBuilder.Models
{
    class InsertTable
    {

        public int id { get; set; }
        public int fk_project { get; set; }
        public string table { get; set; }
        public int order { get; set;  }

        public InsertTable()
        {


        }

        public InsertTable(int NewId, int newFk, string newTable, int newOrder)
        {

            this.id = NewId;
            this.fk_project = newFk;
            this.table = newTable;
            this.order = newOrder;

        }

    }
}
