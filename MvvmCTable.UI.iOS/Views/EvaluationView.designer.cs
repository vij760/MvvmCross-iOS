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
	[Register ("EvaluationView")]
	partial class EvaluationView
	{
		[Outlet]
		UIKit.UICollectionView collection_View { get; set; }

		[Outlet]
		UIKit.UIScrollView scroll_View { get; set; }

		[Outlet]
		UIKit.UIView scrollContentView { get; set; }

		[Outlet]
		UIKit.UIStackView stack_View { get; set; }

		[Outlet]
		UIKit.UIView view0 { get; set; }

		[Outlet]
		UIKit.UIView view1 { get; set; }

		[Outlet]
		UIKit.UIView view2 { get; set; }

		[Outlet]
		UIKit.UIView view3 { get; set; }

		[Outlet]
		UIKit.UIView view4 { get; set; }

		[Outlet]
		UIKit.UIView view5 { get; set; }

		[Outlet]
		UIKit.UIView view6 { get; set; }

		[Action ("prs_Add:")]
		partial void prs_Add (Foundation.NSObject sender);

		[Action ("prs_Btn:")]
		partial void prs_Btn (Foundation.NSObject sender);

		[Action ("prs_Remover:")]
		partial void prs_Remover (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (scroll_View != null) {
				scroll_View.Dispose ();
				scroll_View = null;
			}

			if (scrollContentView != null) {
				scrollContentView.Dispose ();
				scrollContentView = null;
			}

			if (stack_View != null) {
				stack_View.Dispose ();
				stack_View = null;
			}

			if (view0 != null) {
				view0.Dispose ();
				view0 = null;
			}

			if (view1 != null) {
				view1.Dispose ();
				view1 = null;
			}

			if (view2 != null) {
				view2.Dispose ();
				view2 = null;
			}

			if (view3 != null) {
				view3.Dispose ();
				view3 = null;
			}

			if (view4 != null) {
				view4.Dispose ();
				view4 = null;
			}

			if (view5 != null) {
				view5.Dispose ();
				view5 = null;
			}

			if (view6 != null) {
				view6.Dispose ();
				view6 = null;
			}

			if (collection_View != null) {
				collection_View.Dispose ();
				collection_View = null;
			}
		}
	}
}
