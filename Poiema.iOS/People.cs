using System;

using UIKit;

namespace Poiema.iOS
{
	public partial class People : UIViewController
	{
		protected People(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			UIPickerView racePicker = new UIPickerView();
			racePicker.Model = new RacePickerModel();
		}

		public class RacePickerModel : UIPickerViewModel
		{
			public override nint GetComponentCount(UIPickerView pickerView)
			{
				return 1;
			}

			public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
			{
				return 5;
			}

			public override string GetTitle(UIPickerView pickerView, nint row, nint component)
			{
				return "Test " + row.ToString();
			}

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

