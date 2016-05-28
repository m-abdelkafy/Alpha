using System;
using System.Windows.Forms;
using Alpha.BusinessLogic;
using Alpha.DatabaseItems;
using Alpha.Properties;

namespace Alpha.Utilities
{
	public static class ControlHelperUtil
	{
		private static ErrorProvider _err = new ErrorProvider();

		public static void SetErrorMessage(Exception ex, string messageEn = null, string messageAr = null)
		{
			switch (Settings.Default.AlphaCulture)
			{
				case "en":
					MessageBox.Show(ex.Message, messageEn);
					break;
				case "ar":
					MessageBox.Show(ex.Message, messageAr);
					break;
			}
		}
		internal static void NumbersOnlyString(KeyPressEventArgs e, Control ctrl)
		{
			// allows 0-9, backspace, and decimal
			if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
			{
				e.Handled = true;
				return;
			}

			// checks to make sure only 1 decimal is allowed
			if (e.KeyChar != 46) return;
			TextBox textBox = ctrl as TextBox;
			if (textBox != null && textBox.Text.IndexOf(e.KeyChar) != -1)
				e.Handled = true;

			//Handle last char is decimal point here?
			if (ctrl.Text[ctrl.Text.Length - 1] == '.')
			{
				string s = ctrl.Text.TrimEnd('.');
				ctrl.Text = s;
			}

			_err.SetError(ctrl, ErrorHelper.GetNotifyMessage(ErrorHelper.NotifyMessage.NumbersOnly));
		}

		// TODO: Needs work
		internal static bool CheckControlIfEmpty(Control c, int iconPadding = 0)
		{
			bool isError = false;
			_err.BlinkRate = 0;

			if (c is TextBox)
			{
				TextBox t = c as TextBox;
				if (string.IsNullOrEmpty(t.Text) && t.Enabled)
				{
					_err.SetIconPadding(t, iconPadding);
					switch (Settings.Default.AlphaCulture)
					{
						case "en":
							_err.SetError(t, "Field required.");
							break;
						case "ar":
							_err.SetError(t, "حقل مطلوب.");
							break;
					}

					isError = true;
				}
				else if (t.Enabled == false) //For disabled textbox
				{
					_err.SetError(t, string.Empty);
				}
				else
				{
					_err.SetError(t, string.Empty);
				}
			}
			else if (c is ComboBox)
			{
				ComboBox cb = c as ComboBox;
				if (cb.SelectedIndex == 0)
				{
					_err.SetIconPadding(cb, 30);
					switch (Settings.Default.AlphaCulture)
					{
						case "en":
							_err.SetError(cb, "Field required.");
							break;
						case "ar":
							_err.SetError(cb, "حقل مطلوب.");
							break;
					}
					isError = true;
				}
				else
				{
					_err.SetError(cb, string.Empty);
				}
			}
			return isError;
		}

		internal static bool IsListEmpty(ComboBox cb)
		{
			if (cb.Items.Count != 0) return false;
			if (Settings.Default.AlphaCulture == "en")
			{
				MessageBox.Show("List is empty, nothing to delete.", "Error");
			}
			else if (Settings.Default.AlphaCulture == "ar")
			{
				MessageBox.Show("القائمة فارغة, لا يوجد شيء للمسح", "خطأ");
			}

			return true;
		}
		internal static void StartProgressBarAnimation(this ToolStripProgressBar tspb)
		{
			tspb.Style = ProgressBarStyle.Marquee;
			tspb.MarqueeAnimationSpeed = 30;
		}
		internal static void StopProgressBarAnimation(this ToolStripProgressBar tspb)
		{
			tspb.Style = ProgressBarStyle.Continuous;
			tspb.MarqueeAnimationSpeed = 0;
		}
		public static void PrepareCombobox<TItem>(this ComboBox cb) where TItem : class, IElementBase, new()
		{
			IV_ACEntities con = DatabaseManager.CreateConnection();
			cb.DisplayMember = "Name";
			cb.ValueMember = "ID";
			cb.DataSource = GenericHelper.GetFromEF<TItem>(con);
		}
	}
}