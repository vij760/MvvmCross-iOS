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
	[Register ("SearchResultsCell")]
	partial class SearchResultsCell
	{
		[Outlet]
		UIKit.UILabel lbl_FirstName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lbl_FirstName != null) {
				lbl_FirstName.Dispose ();
				lbl_FirstName = null;
			}
		}
	}
}
