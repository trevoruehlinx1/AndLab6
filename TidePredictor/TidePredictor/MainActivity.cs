using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;

namespace TidePredictor
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            string[] testData = Resources.GetStringArray(Resource.Array.test_data_array2);
            ListAdapter = new ArrayAdapter<string> (this, Resource.Layout.list_item, testData);

            ListView.TextFilterEnabled = true;

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);
        }
    }
}

