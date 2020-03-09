namespace BugListCollector.Models
{
	public class ProjectModel
	{
		string projectName;
		BugsListModel bugs;

		ProjectModel ()
		{ }

		ProjectModel (string p, BugsListModel b)
		{
			projectName = p;
			bugs = b;
		}
	}
}
