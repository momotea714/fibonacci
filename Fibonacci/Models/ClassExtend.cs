using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Models
{
    [Serializable]
    public class ClassExtend:Class
    {
        public bool IsUse { get; set; }
    }
}
