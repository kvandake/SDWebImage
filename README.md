# SDWebImage+FLAnimatedImage

Asynchronous image downloader with cache support

This is Obj-C Binding Project based on 
* https://github.com/rs/SDWebImage 
* https://github.com/Flipboard/FLAnimatedImage.

### Usage 

#### SDWebImage
For more info please see https://components.xamarin.com/view/sdwebimage)
```csharp
ImageView.SetImage(NSUrl.FromString("https://cloud.githubusercontent.com/assets/1567433/10417835/1c97e436-7052-11e5-8fb5-69373072a5a0.gif"),
                                           UIImage.FromBundle("placeholder"),
                                           SDWebImageOptions.RefreshCached);
```


#### FLAnimatedImage
For more info please see https://github.com/Flipboard/FLAnimatedImage
```csharp
FLAnimatedImageView.SetImage(NSUrl.FromString("https://cloud.githubusercontent.com/assets/1567433/10417835/1c97e436-7052-11e5-8fb5-69373072a5a0.gif"),
                                           UIImage.FromBundle("placeholder"),
                                           SDWebImageOptions.RefreshCached);
```

### Settings
* Allow [http](https://developer.xamarin.com/guides/ios/platform_features/introduction_to_ios9/ats/):
```
<key>NSAppTransportSecurity</key>
<dict>
 <key>NSAllowsArbitraryLoads</key>
 <true/>
</dict>
```

### Powered By

* https://github.com/guntidheerajkumar/SDWebImage
* https://github.com/rs/SDWebImage
* https://github.com/Flipboard/FLAnimatedImage
