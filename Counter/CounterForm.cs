namespace Counter
{
	using System;
	using System.Diagnostics;
	using System.Globalization;
	using System.Threading;
	using System.Windows.Forms;

	public partial class CounterForm : Form
	{
		public CounterForm()
		{
			InitializeComponent();

			Debug.WriteLine(string.Format("UI running on thread '{0}'.", Thread.CurrentThread.ManagedThreadId));
		}

		private void CountButton_Click(object sender, EventArgs e)
		{
			uxCountButton.Enabled = false;

			new MethodInvoker(StartCounter).BeginInvoke(null, null);
		}

		private void StartCounter()
		{
			int i = 0;

			while (true)
			{
				UpdateCounter(i++);
			}
		}

		private void UpdateCounter(int i)
		{
			// Checks whether we have a handle otherwise InvokeRequired might fail
			if (!IsHandleCreated)
			{
				// Do something like throwing an exception
			}

			// Checks whether we're on the correct thread.
			if (InvokeRequired)
			{
				Debug.WriteLine(string.Format("Executing on thread '{0}'.", Thread.CurrentThread.ManagedThreadId));

				IAsyncResult r = BeginInvoke(new Action<int>(UpdateCounter), i);

				r.AsyncWaitHandle.WaitOne();
			}
			else
			{
				Debug.WriteLine(string.Format("Updating on thread '{0}'.", Thread.CurrentThread.ManagedThreadId));

				uxCounter.Text = i.ToString(CultureInfo.InvariantCulture);
			}
		}
	}
}