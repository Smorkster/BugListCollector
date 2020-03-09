using System.Collections.Generic;

namespace BugListCollector.Models
{
	internal class ProjectsListModel
	{
		List<ProjectModel> projects;

		internal void AddProject(ProjectModel p)
		{
			projects.Add(p);
		}
	}
}
