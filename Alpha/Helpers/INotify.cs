using System.Windows.Forms;

namespace Alpha
{
	public interface INotify
	{
		//object MessageText { get; set; } 
		ToolStripStatusLabel StatusLabel { get; set; }
	}
}