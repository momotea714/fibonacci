using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Models
{
    [Table("ReturnValue")]
    [Serializable]
    public class ReturnValue
    {
        public int Id { get; set; }
        public int MethodId { get; set; }
        public int ReturnValueIndex { get; set; }
        public string ReturnValueType { get; set; }
        public string Description { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
