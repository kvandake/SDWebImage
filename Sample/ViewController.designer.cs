// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;
using SDWebImage;
using UIKit;

namespace Sample
{
    [Register("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIImageView ImgCustomImage { get; set; }

        [Outlet]
        FLAnimatedImageView FLAnimatedImageView { get; set; }

        [Outlet]
        UIButton Button { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (ImgCustomImage != null)
            {
                ImgCustomImage.Dispose();
                ImgCustomImage = null;
            }
        }
    }
}
