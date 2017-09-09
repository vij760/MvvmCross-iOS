using System.Collections.Generic;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;



namespace MvvmCTable.core
{
	public class NewFarmPopViewModel : MvxViewModel
	{
		


		public List<LabelStaticValue> _farmStaticValue { get; set; }
		private string _name;

		public NewFarmPopViewModel()
		{
			

			_farmStaticValue = new List<LabelStaticValue>();

			_farmStaticValue.Add(new LabelStaticValue { StaticValue = "Name" });
			_farmStaticValue.Add(new LabelStaticValue { StaticValue = "Farm Address" });
			_farmStaticValue.Add(new LabelStaticValue { StaticValue = "Notes" });

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


			Close(this);
			//ShowViewModel<AViewModel>


		}

		//public string Name
		//{
		//	get
		//	{
		//		return _name;
		//	}

		//	set
		//	{
		//		_name = value;
		//		RaisePropertyChanged(() => Name);
		//	}
		//}
	}

	public class LabelStaticValue
	{
		public string StaticValue { get; set; }

		private string lastName;
		public string LastName 
		{ 
			get
			{
				return lastName;
			}
			set
			{

			lastName = value;
			}
		}
	}

	public class TestModel
	{
		

		private string secondText;
		public string SecondText
		{
			get
			{
				return secondText;
			}
			set
			{

				secondText = value;
			}
		}

	}
}
