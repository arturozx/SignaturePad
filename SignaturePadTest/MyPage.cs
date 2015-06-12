using System;

using Xamarin.Forms;
using Acr.XamForms.SignaturePad;

namespace SignaturePadTest
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			
			Acr.XamForms.SignaturePad.SignaturePadView sig = new SignaturePadView ();
			sig.HorizontalOptions = LayoutOptions.FillAndExpand;
			sig.VerticalOptions = LayoutOptions.FillAndExpand;


			sig.BackgroundColor = Color.White;
			sig.CaptionText = "Captation";
			sig.CaptionTextColor = Color.Black;
			sig.ClearText = "Clear";
			sig.ClearTextColor = Color.Black;
			sig.PromptText = "Sign";
			sig.PromptTextColor = Color.Black;
			sig.SignatureLineColor = Color.Black;
			sig.StrokeColor=Color.Black;
			sig.StrokeWidth = 4;

			Button btnSave = new Button{
				Text= "Save",
				HorizontalOptions=LayoutOptions.FillAndExpand,
				VerticalOptions=LayoutOptions.End
			};
			btnSave.Clicked+= delegate {
//				byte[] imgFirma;
//				MemoryStream ms = new MemoryStream ();
//				var img = sig.GetImage (ImageFormatType.Png);
//				img.Position = 0;
//				img.CopyTo (ms);
//				imgFirma = ms.ToArray ();
//				ms.Close();
//
				var img = sig.GetImage(ImageFormatType.Jpg);
				img.Position = 0;
				if (!sig.IsBlank) {
					Navigation.PushAsync(new MyPage2(img));
				}
			};

			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" },
					sig,
					btnSave
				}
			};
		}
	}
}


