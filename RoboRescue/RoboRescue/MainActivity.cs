using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace RoboRescue
{
    [Activity(Label = "RoboRescue", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
    public class Person
    {
        bool canSwim;
        int X;
        int Y;
    }
    public class Claw
    {
        int X;
        int Y;
    }
}

