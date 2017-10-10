using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.View;
using Fragment = Android.Support.V4.App.Fragment;
using Android.Support.Design.Widget;
namespace Cnblogs.XamarinAndroid
{
    public class KbArticlesFragment : Fragment
    {
        private FloatingActionButton fab;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            base.OnCreateView(inflater, container, savedInstanceState);
            var  view = inflater.Inflate(Resource.Layout.fragment_kbArticles, container, false);
            fab = view.FindViewById<FloatingActionButton>(Resource.Id.fab_add);
            fab.Click += (s, e) =>
            {
                Snackbar.Make(fab,"123",Snackbar.LengthShort).Show();
            };
            return view;
        }
    }
}