using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Models
{
    [Table("Method")]
    [Serializable]
    public class Method
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string MethodName { get; set; }
        public string DisplayMethodName { get; set; }
        public string MethodDescription { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
