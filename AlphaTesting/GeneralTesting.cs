using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alpha.DatabaseItems;

namespace AlphaTesting
{
	[TestClass]
	public class GeneralTesting
	{
		[TestMethod]
		public void GetCategoriesUT()
		{
			var temp = DatabaseTransactions.GetCategories(2, null);
		}
	}
}