// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using MvvmCTable.core;

namespace MvvmCTable.UI.iOS
{
	public partial class FarmPopUpCell : MvxTableViewCell
	{
		internal static readonly NSString Identifier = new NSString("FarmPopUpCell");
		public FarmPopUpCell (IntPtr handle) : base (handle)
		{
			txt_InserNewFarmField.ShouldReturn += handleShouldReturn;
			CreateBindings();
			//bind();

		}

		private void CreateBindings()
		{
			this.DelayBind(() =>
			{

				MvxFluentBindingDescriptionSet<FarmPopUpCell, LabelStaticValue> set =
			   this.CreateBindingSet<FarmPopUpCell, LabelStaticValue>();

				set.Bind(lbl_StaticField).To(vm => vm.StaticValue);

				set.Bind(txt_InserNewFarmField).To(vm => vm.LastName);
				set.Bind(txt_InserNewFarmField).For("ShouldReturn").To(vm => vm.LastName);

				set.Apply();

				MvxFluentBindingDescriptionSet<FarmPopUpCell, TestModel> set1 =
			   this.CreateBindingSet<FarmPopUpCell, TestModel>();

				set1.Bind(txt_SecondText).To(vm => vm.SecondText);

				set1.Apply();


			});
		} 

		//private void bind()
		//{ 
		   


		//	this.DelayBind(() =>
		//	{
		//		MvxFluentBindingDescriptionSet<FarmPopUpCell, NewFarmPopViewModel> set =
		//			this.CreateBindingSet<FarmPopUpCell, NewFarmPopViewModel>();
		//		//set.Bind(txt_InserNewFarmField).For(txt => txt.Text).To(vm => vm.Name);
		//	 	set.Bind(txt_InserNewFarmField).To(vm => vm.Name);
		//		set.Bind(lbl_StaticField).To(vm => vm.Name);
		//	   //set.Bind(txt_InserNewFarmField).For("ShouldReturn").To(vm => vm.Name);
		//		set.Apply();

		//	});

		//}

		private bool handleShouldReturn(UITextField textField)
		{
			return true;
		}
	}
}
