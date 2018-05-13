using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Models
{
    [Table("ModuleData")]
    [Serializable]
    public class ModuleData
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public byte[] Module { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
