using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Alpha.DatabaseItems;
using Alpha.Properties;
using DevExpress.XtraGrid;

namespace Alpha.BusinessLogic
{
	public static class ErrorHelper
	{
		public static ErrorProvider Error = new ErrorProvider();
		private static readonly List<Control> _requiredFieldControls = new List<Control>();

		public enum NotifyMessage
		{
			Empty,
			SoldSuccessfully = 1,
			BoughtSuccessfully = 1,
			ProblemSelling = 2,
			ProblemBuying = 2,
			ItemAddedSuccessfully,
			RequiredField,
			NumbersOnly,
			Ready,
			Problem,
			ItemNonExistent,
		}
		public static string GetNotifyMessage(NotifyMessage notifyMessage)
		{
			if (notifyMessage == NotifyMessage.Empty)
			{
				return string.Empty;
			}
			if (notifyMessage == NotifyMessage.BoughtSuccessfully || notifyMessage == NotifyMessage.SoldSuccessfully)
			{
				return Settings.Default.AlphaCulture == "en" ? "Transaction completed successfully..." : "تمت العملية بنجاح...";
			}
			if (notifyMessage == NotifyMessage.ProblemSelling || notifyMessage == NotifyMessage.ProblemBuying)
			{
				return Settings.Default.AlphaCulture == "en" ? "Transaction failed..." : "فشلت العملية...";
			}
			if (notifyMessage == NotifyMessage.RequiredField)
			{
				return Settings.Default.AlphaCulture == "en" ? "Required field." : "حقل مطلوب.";
			}
			if (notifyMessage == NotifyMessage.NumbersOnly)
			{
				return Settings.Default.AlphaCulture == "en" ? "Numbers Only." : "الارقام فقط.";
			}
			if (notifyMessage == NotifyMessage.Ready)
			{
				return Settings.Default.AlphaCulture == "en" ? "Ready...     " : "جاهز...     ";
			}
			if (notifyMessage == NotifyMessage.ItemAddedSuccessfully)
			{
				return Settings.Default.AlphaCulture == "en" ? "Item added successfully" : "تمت الاضافة بنجاح";
			}
			if (notifyMessage == NotifyMessage.ItemNonExistent)
			{
				return Settings.Default.AlphaCulture == "en" ? "This item serial does not exist!" : "رقم مسلسل غير موجود!";
			}

			return Settings.Default.AlphaCulture == "en" ? "Problem occurred" : "خطأ بالبرنامج";
		}
		internal static void Notify(NotifyMessage notifyMessage, ToolStripStatusLabel statusLabel
			, int interval = 1000)
		{
			statusLabel.Text = GetNotifyMessage(notifyMessage);
			var notificationTimer = new Timer
			{
				Interval = interval,
				Enabled = true
			};

			notificationTimer.Tick += delegate { statusLabel.Text = GetNotifyMessage(NotifyMessage.Ready); };
		}

		internal static void Notify(NotifyMessage notifyMessage, Control control
			, int interval = 1000)
		{
			Error.SetError(control, GetNotifyMessage(notifyMessage));
		}

		public static void SetRequiredFields(params Control[] requiredControls)
		{
			foreach (Control requiredControl in requiredControls)
			{
				_requiredFieldControls.Add(requiredControl);
			}
		}
		public static int CheckItemBySerial(bool condition, Control controlContainingSerial,
			GridControl grdControl)
		{
			int itemId;
			if (!condition)
			{
				Notify(NotifyMessage.ItemNonExistent, controlContainingSerial);
				grdControl.DataSource = null;
				grdControl.Refresh();
				itemId = -1;
			}
			else
			{
				Notify(NotifyMessage.Empty, controlContainingSerial);
				List<Item> t = DatabaseTransactions.GetItem(null, controlContainingSerial.Text);
				grdControl.DataSource = t;
				if (t.Count > 0)
				{
					itemId = t[0].ID;
				}
				itemId = -1;
			}
			return itemId;
		}
		public static bool ValidateRequiredField()
		{
			if (_requiredFieldControls == null || _requiredFieldControls.Count == 0) return false;

			bool isValidated = true;
			foreach (Control control in _requiredFieldControls)
			{
				if (control is ComboBox)
				{
					if ((control as ComboBox).SelectedIndex != 0) continue;
					Error.SetError(control, GetNotifyMessage(NotifyMessage.RequiredField));
					isValidated = false;
				}
				else
				{
					if (control.Text != String.Empty) continue;
					Error.SetError(control, GetNotifyMessage(NotifyMessage.RequiredField));
					isValidated = false;
				}
			}
			if (!isValidated) return false;

			foreach (Control control in _requiredFieldControls)
			{
				Error.SetError(control, String.Empty);
			}
			return true;
		}
	}
}