using System;

using Xamarin.Forms;
using System.IO;

namespace SignaturePadTest
{
	public class MyPage2 : ContentPage
	{
		public MyPage2 (Stream stream)
		{
			Image oImage = new Image { 
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Source =  ImageSource.FromStream(() => stream)
			};
			Content = new StackLayout { 
				BackgroundColor=Color.White,
				Children = {
					oImage
				}
			};
		}
	}
}


