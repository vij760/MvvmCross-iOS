using System;
using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.UI.iOS;
using MvvmCTable.UI.iOS;

namespace TipCalc.UI.iOS.Utilities
{
    public class StoryboardHelper : MvxIosViewsContainer
    {
        public StoryboardHelper()
        {
        }

        protected override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            try
            {
                var storyboard = UIStoryboard.FromName(AppDelegate.MainStoryboard, null);
                if (storyboard != null)
                {
                    var uiViewController = storyboard.InstantiateViewController(viewType.Name);
                    var mvxIosView = uiViewController as IMvxIosView;
                    if (mvxIosView != null)
                    {
                        return mvxIosView;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return null;
        }
    }
}