using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Models
{
    [Table("Module")]
    [Serializable]
    public class Module
    {
        public int Id { get; set; }
        public string DisplayModuleName { get; set; }
        public Byte[] Icon { get; set; }
        public string ModuleDescription { get; set; }
        public string AssemblyName { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
