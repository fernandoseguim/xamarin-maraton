using System;
namespace DemoPortableLibrary.PCL
{
	public class PrinterManager
	{

		public IPrinter printer { get; set; }

		public PrinterManager(IPrinter printer)
		{

			this.printer = printer;
		}

		public void ShowMessage()
		{
			printer.ShowMessage();
		}
	}
}
