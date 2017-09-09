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
	[Register ("DetailView")]
	partial class DetailView
	{
		[Outlet]
		UIKit.UIButton btn_NextView { get; set; }

		[Outlet]
		UIKit.UIButton btn_ShowEvaluationView { get; set; }

		[Action ("prs_Btn:")]
		partial void prs_Btn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btn_NextView != null) {
				btn_NextView.Dispose ();
				btn_NextView = null;
			}

			if (btn_ShowEvaluationView != null) {
				btn_ShowEvaluationView.Dispose ();
				btn_ShowEvaluationView = null;
			}
		}
	}
}
