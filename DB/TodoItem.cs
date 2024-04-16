using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Threading.Tasks;

namespace DB
{
    public class TodoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdToDoItem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
    }
}