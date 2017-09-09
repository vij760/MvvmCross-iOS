using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCTable.core;

namespace MvvmCrossNew.core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			RegisterAppStart<SearchResultViewModel>();
		}
	}
}
