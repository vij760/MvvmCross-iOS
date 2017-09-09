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
	[Register ("FarmPopUpCell")]
	partial class FarmPopUpCell
	{
		[Outlet]
		UIKit.UILabel lbl_StaticField { get; set; }

		[Outlet]
		UIKit.UITextField txt_InserNewFarmField { get; set; }

		[Outlet]
		UIKit.UITextField txt_SecondText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lbl_StaticField != null) {
				lbl_StaticField.Dispose ();
				lbl_StaticField = null;
			}

			if (txt_InserNewFarmField != null) {
				txt_InserNewFarmField.Dispose ();
				txt_InserNewFarmField = null;
			}

			if (txt_SecondText != null) {
				txt_SecondText.Dispose ();
				txt_SecondText = null;
			}
		}
	}
}
