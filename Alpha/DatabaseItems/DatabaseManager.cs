using System;
using System.Windows.Forms;
using Alpha.Properties;

namespace Alpha.DatabaseItems
{
	public static class DatabaseManager
	{
		private static IV_ACEntities _instance;
		public static IV_ACEntities CreateConnection()
		{
			return _instance ?? (_instance = new IV_ACEntities());
		}
		public static void Save()
		{
			try
			{
				_instance.SaveChanges();
			}
			catch (Exception ex)
			{
				switch (Settings.Default.AlphaCulture)
				{
					case "en":
						MessageBox.Show(ex.Message, @"Error updating database");
						break;
					case "ar":
						MessageBox.Show(ex.Message, @"خطأ في التحميل");
						break;
				}
			}
		}
	}
}