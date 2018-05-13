using Microsoft.Build.Evaluation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Utility
{
    public static class BuildUtility
    {
        public static bool BuildProject(string projectFilePath)
        {
            foreach (var item in ProjectCollection.GlobalProjectCollection.LoadedProjects.Where(x => x.FullPath == projectFilePath))
            {
                ProjectCollection.GlobalProjectCollection.UnloadProject(item);
            }

            var project = new Project(projectFilePath);
            project.SetProperty("Configuration", "Release");
            project.ReevaluateIfNecessary();
            
            var result = project.Build("Rebuild");
            ProjectCollection.GlobalProjectCollection.UnloadProject(project);

            return result;
        }
    }
}
