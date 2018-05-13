using Fibonacci.Core.DataBase;
using Fibonacci.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core
{
    public class FibonacciUtility
    {

        public static IList<Module> SelectModules()
        {
            try
            {
                {
                    return new FibonacciDBContext().Modules.ToList();
                }
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public static IList<Argument> SelectArguments()
        {
            return new FibonacciDBContext().Arguments.ToList();
        }

        public static IList<ReferenceModule> SelectRefereceModules()
        {
            return new FibonacciDBContext().ReferenceModules.ToList();
        }

        public static IList<ReturnValue> SelectReturnValues()
        {
            return new FibonacciDBContext().ReturnValues.ToList();
        }
    }
}
