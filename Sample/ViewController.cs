using System;
using AsyncSDWebImage;
using UIKit;
using Foundation;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//	[imageView sd_setImageWithURL:[NSURL URLWithString:@"http://www.domain.com/path/to/image.jpg"]
			//placeholderImage:[UIImage imageNamed:@"placeholder.png"]];

			ImgCustomImage.Sd_setImageWithURL(NSUrl.FromString("http://a5.files.biography.com/image/upload/c_fit,cs_srgb,dpr_1.0,h_1200,q_80,w_1200/MTE5NDg0MDU0NTIzODQwMDE1.jpg"),
											  UIImage.FromBundle("placeholder"),
											  SDWebImageOptions.RefreshCached);

		}
	}
}
