using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Models
{
    [Table("ReferenceModule")]
    [Serializable]
    public class ReferenceModule
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string AssemblyName { get; set; }
        public byte[] Module { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
