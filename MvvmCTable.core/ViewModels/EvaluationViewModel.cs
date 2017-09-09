using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace MvvmCTable.core
{
	public class EvaluationViewModel: MvxViewModel
	{
		public List<JackModel> jack { get; set; }

		public EvaluationViewModel()
		{
			jack = new List<JackModel>();

			for (int a = 0; a < 10; a++)
			{
				jack.Add(new JackModel()
				{
					FirstName = $"no {a}",
					LastName = $"last {a}"

				});
			}
		}


	}

	public class JackModel
	{
		public string FirstName { 
			get;
			set; 
		}
		public string LastName 
		{ 
			get; 
			set;
		}

	}
}
