using Android.App;
using Android.Widget;
using Android.OS;
using ListViewExample.Services;
using System.Collections.Generic;
using Android.Views;

namespace ListViewExample
{
    [Activity(Label = "ListViewExample", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        myServices theService = new myServices();
        List<string> namesLists = new List<string>();
        List<string> descriptionsList = new List<string>();
        List<string> picLocationsList = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            // SetContentView(Resource.Layout.Main);
            var myItems = theService.GetDataSet();

            foreach (var item in myItems)
            {
                namesLists.Add(item.Name);
                descriptionsList.Add(item.Description);
                picLocationsList.Add(item.Picture_Location);
            }

            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, namesLists);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);
            var nameTouched = namesLists[position] + " " + descriptionsList[position];
            Toast.MakeText(this, nameTouched, ToastLength.Short).Show();
        }
    }
}

