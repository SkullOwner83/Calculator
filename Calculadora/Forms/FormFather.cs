using System.Runtime.InteropServices;

namespace Calculadora
{
	public partial class FormFather : Form
	{
		//Import windows drag form native library
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

		public FormFather()
		{
			InitializeComponent();
		}

		public void WindowLoad(object sender, EventArgs e)
		{
			LblTitle.Text = this.Text;
		}

		//Drag window from his header
		private void DragWindow(object sender, MouseEventArgs e)
		{
			//Drag window if only click one time in header
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(this.Handle, 0x112, 0xf012, 0);
			}
		} 

		//Change window state on click in header buttons
		private void WindowButtons(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
