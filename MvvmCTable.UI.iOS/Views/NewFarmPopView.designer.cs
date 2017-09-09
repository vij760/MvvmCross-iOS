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
	[Register ("NewFarmPopView")]
	partial class NewFarmPopView
	{
		[Outlet]
		UIKit.UILabel lbl_Test { get; set; }

		[Outlet]
		UIKit.UIButton prs_Cancel { get; set; }

		[Outlet]
		UIKit.UITableView table_View { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lbl_Test != null) {
				lbl_Test.Dispose ();
				lbl_Test = null;
			}

			if (table_View != null) {
				table_View.Dispose ();
				table_View = null;
			}

			if (prs_Cancel != null) {
				prs_Cancel.Dispose ();
				prs_Cancel = null;
			}
		}
	}
}
