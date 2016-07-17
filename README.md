# ColorCode (Portable)

*ColorCode (Portable)* is a [Portable Class Library][msdn-pcl] fork of Bashir
Souid's excellent [ColorCode][codeplex-colorcode] library for Syntax
Highlighting.

The goal of this project is to bring ColorCode to new audiences using the
Portable Class Library format.  At the same time, we are taking the latest
version of the tool and making it available on GitHub.  If you are currently
using the .NET Framework 3.5 compatible version then there is no reason to
switch to using this library.

If however, you want to start using Color Code 1.0.2+ with any of the
following platforms then you can consider switching to this portable class
library:

-   ASP.NET Core 1.0
-   Windows 8/10 Desktop
-   Windows Phone 8.1
-   Windows Phone Silverlight 8
-   Xamarin Android
-   Xamarin IOs

The biggest single change in converting this library is the removal of a
dependency on the `System.Drawing` namespace through the introduction of a
similar native .NET object used to represent the CSS colours defined in [CSS
Color Module Level 4][w3c-css4color].
 
  [msdn-pcl]: https://msdn.microsoft.com/en-us/library/gg597391(v=vs.110).aspx
  [codeplex-colorcode]: https://colorcode.codeplex.com/
  [w3c-css4color]: https://drafts.csswg.org/css-color-4/
