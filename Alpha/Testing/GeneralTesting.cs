using System;
using System.Linq;
using Alpha.BusinessLogic;
using Alpha.DatabaseItems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alpha.Testing
{
	[TestClass]
	public class GeneralTesting
	{
		[TestMethod]
		public void GetCategoriesUT()
		{
			//Assuming there exists at least one element in Category table with ID = 10:
			var temp = DatabaseTransactions.GetCategory(10, null, null);
			Assert.AreEqual(temp.Count, 1);
		}

		[TestMethod]
		public void GetLastIdUT()
		{
			var temp = GenericHelper.GetNextId<Category>();
		}

		[TestMethod]
		public void AddTransactionUT()
		{
			var context = DatabaseManager.CreateConnection();
			using (context.Database.BeginTransaction())
			{
				int nextId = GenericHelper.GetNextId<Transaction>();
				DatabaseTransactions.AddTransaction(nextId, DateTime.Now, 11, null, true);
				Assert.AreEqual(context.Transaction.Local.Any(itm => itm.ID == nextId), true);
			}
		}

		[TestMethod]
		public void GetItemUT()
		{
			var context = DatabaseManager.CreateConnection();
			using (context.Database.BeginTransaction())
			{
				var temp = DatabaseTransactions.GetItem(null,"LT34223569028");
				Assert.AreEqual(temp[0] == null, false);
			}
		}
	}
}