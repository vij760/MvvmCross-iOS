using System.Collections.Generic;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;


namespace MvvmCTable.core
{
	public class SearchResultViewModel : MvxViewModel
	{
		private string msg;


		public List<VijiModel> Vijis { get; set; }

		public SearchResultViewModel()
		{

			msg = "welcome to mvvmCross";

			Vijis = new List<VijiModel>();

			for (int i = 0; i < 10; i++)
			{
				Vijis.Add(new VijiModel()
				{
					FirstName = $"First Name {i}",
					LastName = $"Last Name {i}"
				});
			}
		}

		public string Msg
		{
			get
			{
				return msg;
			}

			set
			{
				msg = value;
				RaisePropertyChanged(() => Msg);
			}
		}


		public ICommand ClickCommand
		{
			get
			{
				return new MvxCommand(HandleClick);
			}


		}

		public void HandleClick()
		{
			//Code that accesses StringProperty (which contains the UITextField's value)

		  var msg1 = "welcome to mvvmCross";
			ShowViewModel<DetailViewModel>();

		}




	}




	public class VijiModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

	}
}
