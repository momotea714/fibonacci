using Fibonacci.Core.Models;
using System.Data.Entity;

namespace Fibonacci.Core.DataBase
{
    //モデルを変更したらNugetPakegeManagerで以下の二つを実行
    //Add-Migration XXXXXXXXXXXX←善きに計らって
    //Update-Database
    public class FibonacciDBContext : DbContext
    {
        public FibonacciDBContext()
            : base("Fibonacci")
        {
        }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleData> ModuleDatas { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Method> Methods { get; set; }
        public DbSet<Argument> Arguments { get; set; }
        public DbSet<ReturnValue> ReturnValues { get; set; }
        public DbSet<ReferenceModule> ReferenceModules { get; set; }
    }
}
