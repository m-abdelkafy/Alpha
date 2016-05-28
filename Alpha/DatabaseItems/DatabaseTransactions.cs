using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Alpha.DatabaseItems
{
	public class DatabaseTransactions
	{
		//private static DialogResult _dr;

		// TODO: To be finished, boring :D
		#region GetEntity
		public static List<Category> GetCategory(int? id = null, string name = null, string nameAr = null)
		{
			var context = DatabaseManager.CreateConnection();
			context.Category.Load();
			return new List<Category>(context.Category.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (name == null || itm.Name == name)
				&& (nameAr == null || itm.NameAr == nameAr)));
		}
		public static List<Brand> GetBrand(int? id = null, string name = null, string nameAr = null)
		{
			var context = DatabaseManager.CreateConnection();
			context.Brand.Load();
			return new List<Brand>(context.Brand.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (name == null || itm.Name == name)
				&& (nameAr == null || itm.NameAr == nameAr)));
		}
		public static List<Client> GetClient(int? id = null, string name = null, string nameAr = null, string cell = null, string address = null)
		{
			var context = DatabaseManager.CreateConnection();
			context.Client.Load();
			return new List<Client>(context.Client.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (name == null || itm.Name == name)
				&& (nameAr == null || itm.NameAr == nameAr)
				&& (cell == null || itm.Cell == cell)
				&& (address == null || itm.Address == address)
				));
		}
		public static List<Supplier> GetSupplier(int? id = null, string name = null, string nameAr = null, string cell = null, string address = null)
		{
			var context = DatabaseManager.CreateConnection();
			context.Supplier.Load();
			return new List<Supplier>(context.Supplier.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (name == null || itm.Name == name)
				&& (nameAr == null || itm.NameAr == nameAr)
				&& (cell == null || itm.Cell == cell)
				&& (address == null || itm.Address == address)
				));
		}
		public static List<Warranty> GetWarranty(int? id = null, string name = null, string nameAr = null)
		{
			var context = DatabaseManager.CreateConnection();
			context.Warranty.Load();
			return new List<Warranty>(context.Warranty.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (name == null || itm.Name == name)
				&& (nameAr == null || itm.NameAr == nameAr)));
		}
		public static List<Transaction> GetTransaction(int? id = null, DateTime? datetime = null,
			int? clientId = null, int? supplierId = null, bool? isSellingTransaction = null)
		{
			var context = DatabaseManager.CreateConnection();
			context.Transaction.Load();
			return new List<Transaction>(context.Transaction.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (datetime == null || itm.DateTime == datetime)
				&& (clientId == null || itm.ClientId == clientId)
				&& (supplierId == null || itm.SupplierId == supplierId)
				&& (isSellingTransaction == null || itm.IsSellingTransaction == isSellingTransaction)
				));
		}
		public static List<Expence> GetExpence(int? id = null, string name = null, string nameAr = null,
			decimal? price = null, DateTime? datetime = null)
		{
			var context = DatabaseManager.CreateConnection();
			context.Expence.Load();
			return new List<Expence>(context.Expence.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (name == null || itm.Name == name)
				&& (nameAr == null || itm.NameAr == nameAr)
				&& (price == null || itm.Price == price)
				&& (datetime == null || itm.Date == datetime)
				));
		}
		public static List<Maintenance> GetMaintenance(int? id, int? clientId, int? transactionId, int? itemId,
			string itemDescription, bool? isWarranty, int? warrantyId, decimal? cost, int? durationInDays)
		{
			var context = DatabaseManager.CreateConnection();
			context.Maintenance.Load();
			return new List<Maintenance>(context.Maintenance.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (clientId == null || itm.ClientId == clientId)
				&& (transactionId == null || itm.TransactionId == transactionId)
				&& (itemId == null || itm.ItemId == itemId)
				&& (itemDescription == null || itm.ItemDescription == itemDescription)
				&& (isWarranty == null || itm.IsWarranty == isWarranty)
				&& (warrantyId == null || itm.WarrantyId == warrantyId)
				&& (cost == null || itm.Cost == cost)
				&& (durationInDays == null || itm.DurationInDays == durationInDays)
				));
		}
		public static List<Installment> GetInstallment(int? id, int? transactionId, int? numberOfInstallments, int? installmentEveryNumberOfMonths,
			decimal? installmentCost, DateTime? startDate, bool? isDebit, int? clientId, int? supplierId)
		{
			var context = DatabaseManager.CreateConnection();
			context.Installment.Load();
			return new List<Installment>(context.Installment.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (transactionId == null || itm.TransactionId == transactionId)
				&& (numberOfInstallments == null || itm.NumberOfInstallments == numberOfInstallments)
				&& (installmentEveryNumberOfMonths == null || itm.InstallmentEveryNumberOfMonths == installmentEveryNumberOfMonths)
				&& (installmentCost == null || itm.InstallmentCost == installmentCost)
				&& (startDate == null || itm.StartDate == startDate)
				&& (isDebit == null || itm.IsDebt == isDebit)
				&& (clientId == null || itm.ClientId == clientId)
				&& (supplierId == null || itm.SupplierId == supplierId)
				));
		}
		public static List<Item> GetItem(int? id = null, string serial = null,
			int? supplierId = null, bool? isUsed = null, int? warrantyId = null,
			int? categoryId = null, int? brandId = null, bool? isSold = null)
		{
			var context = DatabaseManager.CreateConnection();
			context.Item.Load();
			return new List<Item>(context.Item.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (serial == null || itm.Serial == serial)
				&& (supplierId == null || itm.SupplierId == supplierId)
				&& (isUsed == null || itm.IsUsed == isUsed)
				&& (warrantyId == null || itm.WarrantyId == warrantyId)
				&& (categoryId == null || itm.CategoryId == categoryId)
				&& (brandId == null || itm.BrandId == brandId)
				&& (isSold == null || itm.IsSold == isSold)
				));
		}
		public static List<ItemTransaction> GetItemTransaction(int? id, int? transactionId, int? itemId, decimal? unitPrice, int? count, bool? isNotFinal)
		{
			var context = DatabaseManager.CreateConnection();
			context.ItemTransaction.Load();
			return new List<ItemTransaction>(context.ItemTransaction.Local.Where(itm =>
				(id == null || itm.ID == id)
				&& (transactionId == null || itm.TransactionId == transactionId)
				&& (itemId == null || itm.ItemId == itemId)
				&& (unitPrice == null || itm.UnitPrice == unitPrice)
				&& (count == null || itm.Count == count)
				&& (isNotFinal == null || itm.IsNotFinal == isNotFinal)
				));
		}
		#endregion

		#region AddEntity
		public static void AddClient(int id, string name, string nameAr, string cell, string address, decimal credit)
		{
			var context = DatabaseManager.CreateConnection();
			context.Client.Add(
				new Client
			{
				ID = id,
				Name = name,
				NameAr = nameAr,
				Cell = cell,
				Address = address,
				Credit = credit
			});
			DatabaseManager.Save();
		}
		public static void AddSupplier(int id, string name, string nameAr, string cell, string address, decimal credit)
		{
			var context = DatabaseManager.CreateConnection();
			context.Supplier.Add(
				new Supplier
				{
					ID = id,
					Name = name,
					NameAr = nameAr,
					Cell = cell,
					Address = address,
					Credit = credit
				});
			DatabaseManager.Save();
		}
		public static void AddCategory(int id, string name, string nameAr)
		{
			var context = DatabaseManager.CreateConnection();
			context.Category.Add(
				new Category
				{
					ID = id,
					Name = name,
					NameAr = nameAr
				});
			DatabaseManager.Save();
		}
		public static void AddBrand(int id, string name, string nameAr)
		{
			var context = DatabaseManager.CreateConnection();
			context.Brand.Add(
				new Brand
				{
					ID = id,
					Name = name,
					NameAr = nameAr
				});
			DatabaseManager.Save();
		}
		public static void AddTransaction(int id, DateTime dt, int? clientId, int? supplierId, bool isSellingTransaction, bool save = true)
		{
			var context = DatabaseManager.CreateConnection();
			context.Transaction.Add(
				new Transaction
				{
					ID = id,
					DateTime = dt,
					ClientId = clientId,
					SupplierId = supplierId,
					IsSellingTransaction = isSellingTransaction
				});
			if (save)
				DatabaseManager.Save();
		}

		public static void AddItemTransaction(int id, int transactionId, int itemId, decimal unitPrice, int count, bool isNotFinal, bool save = true)
		{
			var context = DatabaseManager.CreateConnection();
			context.ItemTransaction.Add(
				new ItemTransaction
				{
					ID = id,
					TransactionId = transactionId,
					Count = count,
					ItemId = itemId,
					UnitPrice = unitPrice,
					IsNotFinal = isNotFinal
				});
			if (save)
				DatabaseManager.Save();
		}

		#endregion


		/// <summary>
		///     Delete category and all its items. (WARNING: SEE IMPLEMENTATION)
		/// </summary>
		/// <param name="s"></param>
		public static void DeleteCategory(string s)
		{
			///////////////////////////////////
			///Delete brands  under it too??///
			///////////////////////////////////


			//var context = DatabaseManager.CreateConnection();

			//int categoryID = (from category in context.Categories
			//                  where category.Name == s
			//                  select category.ID).Single();

			//var itemsToDelete = from item in context.Items
			//                    where item.FK_CategoryID == categoryID
			//                    select item;
			//foreach (var item in itemsToDelete)
			//{
			//    context.Items.DeleteOnSubmit(item);
			//}

			//var categoryToDelete = (from category in context.Categories
			//                        where category.Name == s
			//                        select category).Single();
			//context.Categories.DeleteOnSubmit(categoryToDelete);

			//DatabaseManager.Save();
		}

		/// <summary>
		///     Delete brand and all its items.
		/// </summary>
		/// <param name="s"></param>
		public static void DeleteBrand(string s)
		{
			var context = DatabaseManager.CreateConnection();

			var brandId = (from brand in context.Brand
						   where brand.Name == s
						   select brand.ID).Single();

			var itemsToDelete = from item in context.Item
								where item.BrandId == brandId
								select item;
			foreach (var item in itemsToDelete)
			{
				context.Item.Remove(item);
				DatabaseManager.Save();
			}


			var brandToDelete = (from brand in context.Brand
								 where brand.Name == s
								 select brand).Single();
			context.Brand.Remove(brandToDelete);
			DatabaseManager.Save();
		}

		/// <summary>
		///     Deletes client and all their transactions.
		/// </summary>
		/// <param name="s"></param>
		public static void DeleteClient(string s)
		{
			//var context = DatabaseManager.CreateConnection();

			//int clientID = (from client in context.Clients
			//                where client.Name == s
			//                select client.ID).Single();

			//var transactionsToDelete = from transaction in context.Transactions
			//                           where transaction.FK_ClientID == clientID
			//                           select transaction;
			//foreach (var transaction in transactionsToDelete)
			//{
			//    context.Transactions.DeleteOnSubmit(transaction);
			//}

			//var clientToDelete = (from client in context.Clients
			//                      where client.Name == s
			//                      select client).Single();
			//context.Clients.DeleteOnSubmit(clientToDelete);

			//DatabaseManager.Save();
		}

		/// <summary>
		///     Delete supplier , all items listed under them and all their transactions. (WARNING: SEE IMPLEMENTATION)
		/// </summary>
		/// <param name="s"></param>
		public static void DeleteSupplier(string s)
		{
			//var context = DatabaseManager.CreateConnection();

			//int supplierID = (from supplier in context.Suppliers
			//                  where supplier.Name == s
			//                  select supplier.ID).Single();

			//var transactionsToDelete = from transaction in context.Transactions
			//                           where transaction.FK_SupplierID == supplierID
			//                           select transaction;
			//foreach (var transaction in transactionsToDelete)
			//{
			//    context.Transactions.DeleteOnSubmit(transaction);
			//}

			//////////////////////////////////////////////////////????????????????????
			//var itemsToDelete = from item in context.Items
			//                    where item.FK_SupplierID == supplierID
			//                    select item;
			//foreach (var item in itemsToDelete)
			//{
			//    context.Items.DeleteOnSubmit(item);
			//}
			//////////////////////////////////////////////////////????????????????????
			////Or set these items' supplier to NULL??
			//var supplierToDelete = (from supplier in context.Suppliers
			//                        where supplier.Name == s
			//                        select supplier).Single();
			//context.Suppliers.DeleteOnSubmit(supplierToDelete);

			//DatabaseManager.Save();
		}

		//public static int SellTransaction(string serial, decimal quantity, decimal unitPrice, string client)
		//{
		//	return 1;
		//	///////REMAKE!!!!
		//	//0 -> Error
		//	//1 -> Success

		//	//var context = DatabaseManager.CreateConnection();
		//	//DateTime thisTransactionDateTime = DateTime.Now;

		//	////Check if item exists:
		//	//string unitID = "";
		//	//try
		//	//{
		//	//    unitID = (from item in context.Items
		//	//              where item.ItemID == _serial
		//	//              select item.ItemID).Single();
		//	//}
		//	//catch (Exception)
		//	//{
		//	//    if (Properties.Settings.Default.CULTURE == "en")
		//	//    {
		//	//        MessageBox.Show("No item exists with serial \"" + _serial + "\". Please check the serial.", "No such item");
		//	//    }
		//	//    else if (Properties.Settings.Default.CULTURE == "ar")
		//	//    {
		//	//        MessageBox.Show("لا يوجد بند بهذا الرقم المسلسل \"" + _serial + "\". من فضلك تحقق من الرقم المسلسل.", "لا يوجد بند");
		//	//    }

		//	//    return 0;
		//	//}


		//	//if (unitID == "")
		//	//{
		//	//    MessageBox.Show("Cannot find an item with this serial.");
		//	//    return 0;
		//	//}
		//	//else
		//	//{
		//	//    //Givens
		//	//    var itemToBeUpdated = (from item in context.Items
		//	//                           where item.ItemID == unitID
		//	//                           select item).Single();


		//	//    int fk_price = (from item in context.Items
		//	//                    where item.ID == unitID
		//	//                    select item.FK_PriceID).Single();

		//	//    int fk_client = (from client in context.Clients
		//	//                     where client.Name == _client
		//	//                     select client.ID).Single();
		//	//    //Price logic:
		//	//    Price p = new Price()
		//	//    {
		//	//        Price1 = _unitPrice,
		//	//        DateTime = thisTransactionDateTime
		//	//    };
		//	//    context.Prices.Add(p);
		//	//    DatabaseManager.Save();

		//	//    var thisPriceID = (from price in context.Prices
		//	//                       where price.DateTime == thisTransactionDateTime
		//	//                       select price.ID).Single();

		//	//    //One less item logic:                
		//	//    if (remainingItems < 0)
		//	//    {
		//	//        if (Properties.Settings.Default.CULTURE == "en")
		//	//        {
		//	//            MessageBox.Show("Number of items in stock is less than quantity to be sold(" +
		//	//           _quantity + "), maximum number of items to sell for this item is " +
		//	//           itemToBeUpdated.Quantity, "Cannot complete transaction");
		//	//        }
		//	//        else if (Properties.Settings.Default.CULTURE == "ar")
		//	//        {
		//	//            MessageBox.Show("عدد البنود في المخزن أقَل من العدد الذي تريد ان تبيعه (" + _quantity + "), اقصى عدد لبيع هذا البند هو : " + itemToBeUpdated.Quantity, "لا يمكن اتمام العملية");
		//	//        }
		//	//        return 0;
		//	//    }
		//	//    else if (remainingItems == 0)
		//	//    {
		//	//        context.Items.DeleteOnSubmit(itemToBeUpdated);
		//	//        DatabaseManager.Save();
		//	//    }
		//	//    else
		//	//    {
		//	//        itemToBeUpdated.Quantity -= (int)_quantity;
		//	//        DatabaseManager.Save();
		//	//    }

		//	//    //Transaction logic:
		//	//    var thisPrice = (from price in context.Prices
		//	//                     where price.DateTime == thisTransactionDateTime
		//	//                     select price).Single();
		//	//    if (thisPrice.Price1 < itemToBeUpdated.Price.Price1)
		//	//    {
		//	//        if (Properties.Settings.Default.CULTURE == "en")
		//	//        {
		//	//            dr = MessageBox.Show("You will sell this item for less than its cost...are you sure?", "Warning", MessageBoxButtons.OKCancel);
		//	//        }
		//	//        else if (Properties.Settings.Default.CULTURE == "ar")
		//	//        {
		//	//            dr = MessageBox.Show("ستقوم ببيع هذا البند بـأقَل من سعر التكلفة...هل انت متأكد؟", "تحذير", MessageBoxButtons.OKCancel);
		//	//        }

		//	//        if (dr == DialogResult.Cancel)
		//	//        {
		//	//            return 0;
		//	//        }
		//	//        else
		//	//        {
		//	//            Transaction t = new Transaction()
		//	//            {
		//	//                DateTime = DateTime.Now,
		//	//                FK_ClientID = fk_client,
		//	//                FK_PriceID = thisPriceID
		//	//            };
		//	//            context.Transactions.Add(t);
		//	//            DatabaseManager.Save();
		//	//            return 1;
		//	//        }
		//	//    }
		//	//    return 1;
		//	//}
		//}

		public static void BuyTransaction(string serial, string category, string brand, bool used,
			string supplier, decimal unitCost, int warranty, int quantity)
		{
			////REMAKE!!!
			//0 -> Error
			//1 -> Success

			//var context = DatabaseManager.CreateConnection();
			//DateTime thisTransactionDateTime = DateTime.Now;

			////Check if item exists:
			//string unitID = "";
			//try
			//{
			//    unitID = (from item in context.Items
			//              where item.ID == _serial
			//              select item.ID).Single();
			//}
			//catch (Exception)
			//{
			//    if (unitID == "")
			//    {
			//        Price p = new Price()
			//        {
			//            Price1 = _unitCost,
			//            DateTime = thisTransactionDateTime
			//        };
			//        context.Prices.Add(p);
			//        DatabaseManager.Save();

			//        var thisPriceID = (from price in context.Prices
			//                           where price.DateTime == thisTransactionDateTime
			//                           select price.ID).Single();
			//        Warranty w;
			//        Item i;

			//        if (_warranty != -1)
			//        {
			//            w = new Warranty()
			//            {
			//                Duration = _warranty
			//            };

			//            thisWarrantyID = (from warranty in context.Warranties
			//                              select warranty.ID).Last();
			//            ////////////////////////////////////////////////////
			//            //////KDA MAZBOOT ENO YGEEB ID A5ER WARRANTY???/////
			//            ////////////////////////////////////////////////////
			//        }

			//        var thisSupplierID = (from supplier in context.Suppliers
			//                              where supplier.Name == _supplier
			//                              select supplier.Supplier1).Single();

			//        var thisCategoryID = (from category in context.Categories
			//                              where category.Name == _category
			//                              select category.Category1).Single();

			//        var thisBrandID = (from brand in context.Brands
			//                           where brand.Name == _brand
			//                           select brand.Brand1).Single();

			//        if (_warranty != -1)
			//        {
			//            i = new Item()
			//            {
			//                ID = _serial,
			//                FK_PriceID = thisPriceID,
			//                Quantity = (int)_quantity,
			//                FK_SupplierID = thisSupplierID,
			//                Used = _used,
			//                FK_WarrantyID = thisWarrantyID,
			//                FK_CategoryID = thisCategoryID,
			//                FK_BrandID = thisBrandID
			//            };
			//        }
			//        else
			//        {
			//            i = new Item()
			//            {
			//                ID = _serial,
			//                FK_PriceID = thisPriceID,
			//                Quantity = (int)_quantity,
			//                FK_SupplierID = thisSupplierID,
			//                Used = _used,
			//                FK_CategoryID = thisCategoryID,
			//                FK_BrandID = thisBrandID
			//            };
			//        }

			//        context.Items.Add(i);
			//        DatabaseManager.Save();

			//        Transaction t = new Transaction()
			//        {
			//            DateTime = thisTransactionDateTime,
			//            FK_PriceID = thisPriceID,
			//            FK_SupplierID = thisSupplierID
			//        };
			//        context.Transactions.Add(t);
			//        DatabaseManager.Save();

			//        return 1;
			//    }
			//    else
			//    {
			//        if (Properties.Settings.Default.CULTURE == "en")
			//        {
			//            MessageBox.Show("An item with this serial already exixts, please specify another serial.", "Item exists");
			//        }
			//        else if (Properties.Settings.Default.CULTURE == "ar")
			//        {
			//            MessageBox.Show("يوجد بند بنفس الرقم المسلسل, من فضلك اختر رقم مسلسل أخر", "البند موجود");
			//        }

			//        return 0;
			//    }

			//if (Properties.Settings.Default.CULTURE == "en")
			//{
			//    MessageBox.Show("An item with this serial already exixts, please specify another serial.", "Item exists");
			//}
			//else if (Properties.Settings.Default.CULTURE == "ar")
			//{
			//    MessageBox.Show("يوجد بند بنفس الرقم المسلسل, من فضلك اختر رقم مسلسل أخر", "البند موجود");
			//}
			//return 0;
		}
		public static void ExpenseTransaction(string expenseName, decimal expensePrice)
		{
			////0 -> Error
			////1 -> Success

			//try
			//{
			//    var context = DatabaseManager.CreateConnection();
			//    DateTime thisTransactionDateTime = DateTime.Now;
			//    context.spAddExpence(_expenseName, _expensePrice);
			//    return 1;
			//}
			//catch (Exception)
			//{
			//    return 0;
			//}
		}
	}
}