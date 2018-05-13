using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Models
{
    [Table("Argument")]
    [Serializable]
    public class Argument
    {
        public int Id { get; set; }
        public int MethodId { get; set; }
        public int AargumentIndex { get; set; }
        public string AargumentType { get; set; }
        public string AargumentInitialValue { get; set; }
        public string Description { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
