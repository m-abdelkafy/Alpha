using System.Collections.Generic;
using System.Linq;

namespace Alpha.DatabaseItems
{
	public partial class ItemTransaction : IElementBase
	{
		public int IDField { get { return ID; } set { ID = value; } }

		public string ItemName
		{
			get
			{
				IV_ACEntities context = DatabaseManager.CreateConnection();
				Item item = DatabaseTransactions.GetItem(ItemId).First();
				List<Brand> brand = DatabaseTransactions.GetBrand(item.BrandId);
				List<Category> category = DatabaseTransactions.GetCategory(item.CategoryId);
				string resultStr =
					(category == null || category.Count == 0 ? "" : category[0].Name)
					+ " - " +
					(brand == null || brand.Count == 0 ? "" : brand[0].Name);
				return resultStr;
			}
		}
	}
}