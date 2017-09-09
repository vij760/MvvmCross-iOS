// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmCTable.UI.iOS
{
	[Register ("SearchResultView")]
	partial class SearchResultView
	{
		[Outlet]
		UIKit.UIButton btn_Test { get; set; }

		[Outlet]
		UIKit.UITableView table_View { get; set; }

		[Action ("prs_Btn:")]
		partial void prs_Btn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btn_Test != null) {
				btn_Test.Dispose ();
				btn_Test = null;
			}

			if (table_View != null) {
				table_View.Dispose ();
				table_View = null;
			}
		}
	}
}
