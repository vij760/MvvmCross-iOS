using System;
using Foundation;
using MvvmCross.Binding.ExtensionMethods;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace MvvmCTable.UI.iOS
{
	public class CollectionViewSource : MvxCollectionViewSource
	{
	    

		public CollectionViewSource(UICollectionView collectionView) : base(collectionView)
		{ 
		}




		public override nint NumberOfSections(UICollectionView collectionView)
		{
			return 1;
		}

		public override nint GetItemsCount(UICollectionView collectionView, nint section)
		{
			return ItemsSource.Count();
		}

		public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
		{//
			CollectionViewCell cell = collectionView.DequeueReusableCell(CollectionViewCell.Identifier, indexPath) as CollectionViewCell;
			//cell.setValueOnLabel();
			return cell;
		}

		public override void WillDisplayCell(UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			CollectionViewCell cellz = cell as CollectionViewCell;

			cellz.CreateBindings();
		}
	


		//protected override object GetItemAt(NSIndexPath indexPath)
		//{
		//	//throw new NotImplementedException();
		//}

	}
}
