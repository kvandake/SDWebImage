# SDWebImage

Asynchronous image downloader with cache support

This is Obj-C Binding Project based on https://github.com/rs/SDWebImage.

###Usage 

```
ImgCustomImage.Sd_setImageWithURL(NSUrl.FromString("http://a5.files.biography.com/image/upload/c_fit,cs_srgb,dpr_1.0,h_1200,q_80,w_1200/MTE5NDg0MDU0NTIzODQwMDE1.jpg"),
											  UIImage.FromBundle("placeholder"),
											  SDWebImageOptions.RefreshCached);
```

###Settings

```
<key>NSAppTransportSecurity</key>
<dict>
	<key>NSAllowsArbitraryLoads</key>
	<true/>
</dict>
```
