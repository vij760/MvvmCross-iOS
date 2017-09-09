// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using MvvmCTable.core;

namespace MvvmCTable.UI.iOS
{
	public partial class SearchResultsCell : MvxTableViewCell
	{
		internal static readonly NSString Identifier = new NSString("SearchResultsCell");

		public SearchResultsCell (IntPtr handle) : base (handle)
		{
			CreateBindings();
		}

		public void CreateBindings()
		{
			this.DelayBind(() =>
			{
				
				MvxFluentBindingDescriptionSet<SearchResultsCell, VijiModel> set =
			   this.CreateBindingSet<SearchResultsCell, VijiModel>();

				set.Bind(lbl_FirstName).To(vm => vm.FirstName);

				set.Apply();
			});
		}
	}
}