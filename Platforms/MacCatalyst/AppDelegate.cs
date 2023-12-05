using Foundation;
using UIKit;

namespace MauiMacCatalystCustomAboutDialogSample;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    // Uncomment to replace the About menu option with your own functionality
    // public override void BuildMenu(IUIMenuBuilder builder)
    // {
    //     base.BuildMenu(builder);

    //     var action = UIAction.Create("About this app", null, null, handler: (a) =>
    //     {
    //         Console.WriteLine("Custom about");
    //     });

    //     builder.ReplaceMenu(UIMenuIdentifier.About.GetConstant(), UIMenu.Create("", null,
    //         UIMenuIdentifier.About, UIMenuOptions.DisplayInline, new[] { action }));
    // }

    // Uncomment to remove the About menu item altogether
    // public override void BuildMenu(IUIMenuBuilder builder)
    // {
    //     base.BuildMenu(builder);

    //     builder.RemoveMenu(UIMenuIdentifier.About.GetConstant());
    // }
}
