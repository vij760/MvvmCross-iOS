using System;
using System.Diagnostics.Contracts;
using Foundation;
using MvvmCross.Binding.ExtensionMethods;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace MvvmCTable.UI.iOS
{
	public class SearchResultsTableViewSource : MvxTableViewSource
	{
		public SearchResultsTableViewSource(IntPtr handle) : base(handle)
		{
		}

		public SearchResultsTableViewSource(UITableView tableView): base(tableView)
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
			var cell = (SearchResultsCell)tableView.DequeueReusableCell(SearchResultsCell.Identifier);
			return cell;
		}

		protected override object GetItemAt(NSIndexPath indexPath)
		{
			return ItemsSource?.ElementAt(indexPath.Row);
		}
	}
}
