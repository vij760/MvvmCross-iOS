using System.Collections.Generic;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace MvvmCTable.core
{
	public class DetailViewModel : MvxViewModel
	{
		public DetailViewModel()
		{
		}

		public ICommand ClickCommand
		{
			get
			{
				return new MvxCommand(HandleClick);
			}


		}

		public ICommand ClickShowEvaluation
		{
			get
			{
				return new MvxCommand(HandleEvaluation);
			}


		}

		public void HandleClick()
		{
			//Code that accesses StringProperty (which contains the UITextField's value)


			ShowViewModel<NewFarmPopViewModel>();

			//ShowViewModel<AViewModel>


		}

		public void HandleEvaluation()
		{

			ShowViewModel<EvaluationViewModel>();
		}
	}
}
