using System;

namespace BugListCollector.Models
{
	public class BugModel
	{
		internal EventHandler<bool> BugUpdated;

		bool bugFixed;
		string bugID;
		string bugText;
		string bugName;


	}
}
