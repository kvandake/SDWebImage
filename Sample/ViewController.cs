using System;
using SDWebImage;
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
            var f = SDWebImageManager.SharedManager;

            FLAnimatedImageView.SetImage(NSUrl.FromString("https://cloud.githubusercontent.com/assets/1567433/10417835/1c97e436-7052-11e5-8fb5-69373072a5a0.gif"),
                                                   UIImage.FromBundle("placeholder"),
                                                   SDWebImageOptions.RefreshCached, (arg0, arg1, arg2, arg3) =>
             {
                 SDImageCache.SharedImageCache().StoreImage(arg0, "fgfgg", HandleSDWebImageNoParamsBlock);
             });
            ImgCustomImage.SetImage(NSUrl.FromString("https://cloud.githubusercontent.com/assets/1567433/10417835/1c97e436-7052-11e5-8fb5-69373072a5a0.gif"),
                                              UIImage.FromBundle("placeholder"),
                                              SDWebImageOptions.RefreshCached);

        }

        void HandleSDWebImageNoParamsBlock()
        {
            var im = SDImageCache.SharedImageCache().ImageFromCacheForKey("fgfgg");
        }
    }
}
