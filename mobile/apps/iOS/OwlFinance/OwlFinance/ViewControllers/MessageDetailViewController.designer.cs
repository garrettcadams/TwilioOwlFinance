// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace OwlFinance.ViewControllers
{
    [Register ("MessageDetailViewController")]
    partial class MessageDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem DoneBarButton { get; set; }

        [Action ("DoneBarButton_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DoneBarButton_Activated (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (DoneBarButton != null) {
                DoneBarButton.Dispose ();
                DoneBarButton = null;
            }
        }
    }
}