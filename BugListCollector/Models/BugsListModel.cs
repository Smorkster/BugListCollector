using System.Collections.Generic;

namespace BugListCollector.Models
{
	internal class BugsListModel
	{
		List<BugModel> bugsList;

		internal void AddBug(BugModel newbug)
		{
			bugsList.Add(newbug);
		}
	}
}
