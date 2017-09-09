using System;
using System.Diagnostics.Contracts;
using Foundation;
using MvvmCross.Binding.ExtensionMethods;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace MvvmCTable.UI.iOS
{
	public class FarmPopTableSource : MvxTableViewSource
	{
		//public FarmPopTableSource()
		//{
		//}

		public FarmPopTableSource(IntPtr handle) : base(handle)
		{
		}

		public FarmPopTableSource(UITableView tableView): base(tableView)
		{
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{

			return ItemsSource.Count();
		}

		protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
		{
			var cell = (FarmPopUpCell)tableView.DequeueReusableCell(FarmPopUpCell.Identifier);
			return cell;
		}

		protected override object GetItemAt(NSIndexPath indexPath)
		{
			return ItemsSource?.ElementAt(indexPath.Row);
		}
	}
}
