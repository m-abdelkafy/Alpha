using System;
using System.Collections.Generic;
using Alpha.BusinessLogic;
using Alpha.DatabaseItems;

namespace Alpha.Controllers
{
	internal static class SellTransactionController
	{
		internal static List<ItemTransaction> ItemTransLst = new List<ItemTransaction>();
		internal static int ThisTransactionId;
		static internal bool CommitTransaction()
		{
			try
			{
				return true;
			}
			catch (Exception)
			{

				throw;
				return false;
			}
		}

		static internal void CommitAndPrintTransaction()
		{
			if (CommitTransaction())
			{
				/////////////////////
				///Print code here///
				/////////////////////
			}
		}

		static internal void AddItemToInvoice(int transId, int itemId, int quantity, decimal price, bool isNotFinal)
		{
			ProgressHelper.StartProgress();

			ItemTransLst.Add(new ItemTransaction
			{
				ID = GenericHelper.GetNextId<ItemTransaction>(),
				TransactionId = transId,
				Count = quantity,
				ItemId = itemId,
				UnitPrice = price,
				IsNotFinal = isNotFinal
			});

			//ErrorHelper.Notify(ErrorHelper.NotifyMessage.ItemAddedSuccessfully, StatusLabel);

			ProgressHelper.EndProgress();
		}
	}
}