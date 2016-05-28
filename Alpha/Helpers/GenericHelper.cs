using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using Alpha.DatabaseItems;
using DevExpress.XtraLayout;

namespace Alpha.BusinessLogic
{
	public static class GenericHelper
	{
		/// <summary>
		/// Gets a full list of given type.
		/// </summary>
		/// <typeparam name="TEntity">Entity type.</typeparam>
		/// <param name="con">Context</param>
		/// <returns>List of all elements of given entity.</returns>
		public static List<TEntity> GetFromEF<TEntity>(IV_ACEntities con) where TEntity : class
		{
			IObjectContextAdapter adapter = con;
			ObjectContext oContext = adapter.ObjectContext;
			return oContext.CreateObjectSet<TEntity>().ToList();
		}

		/// <summary>
		/// Gets next id of given entity.
		/// </summary>
		/// <typeparam name="TEntity">Requierd entity for next id.</typeparam>
		/// <returns>New id for given entity.</returns>
		public static int GetNextId<TEntity>() where TEntity : class, IElementBase, new()
		{
			var con = DatabaseManager.CreateConnection();
			int res = GetFromEF<TEntity>(con).Max(itm => itm.IDField) + 1;
			return res;
		}

		public static void EnableControls(bool isEnabled, params Control[] c)
		{
			foreach (Control control in c)
			{
				control.Enabled = isEnabled;
			}
		}
		public static void EnableControls(bool isEnabled, Control.ControlCollection c)
		{
			foreach (Control control in c)
			{
				if (control is LayoutControl)
				{
					foreach (Control controlFromLayout in control.Controls)
					{
						controlFromLayout.Enabled = isEnabled;
					}
					break;
					//control.Controls[0].Enabled = isEnabled;
				}
				else
				{
					control.Enabled = isEnabled;
				}
			}
		}

		// TODO: Needs work: Only Item entity or generic??
		//public static bool CheckItemExists<TItemType>(string serial) where TItemType : class, IElementBase
		//{
		//	var context = DatabaseManager.CreateConnection();
		//	return GetFromEF<TItemType>(context).Any(itm => itm.SerialField.Equals(serial));
		//}

		public static bool CheckItemExists(string serial)
		{
			var context = DatabaseManager.CreateConnection();
			return context.Item.Any(itm => itm.Serial == serial);
		}
	}
}