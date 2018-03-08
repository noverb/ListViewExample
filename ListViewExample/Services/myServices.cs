using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewExample.Services
{
    class myServices
    {
        public List<myData> GetDataSet()
        {
            List<myData> myDataList = new List<myData>
            {
                // Idealy, your own app will go off and retrieve this information from a remote source. The exposed
                // method (GetDataSet) and the myData class should be the only items the caller should care about.
                new myData { Name = "John", Description = "This is a picture of a man", Picture_Location = "Pic00" },
                new myData { Name = "Mary", Description = "This is a picture of a woman", Picture_Location = "Pic01" },
                new myData { Name = "Peter", Description = "This is a picture of a man", Picture_Location = "Pic02" },
                new myData { Name = "Nancy", Description = "This is a picture of a woman", Picture_Location = "Pic03" },
                new myData { Name = "James", Description = "This is a picture of a man", Picture_Location = "Pic04" },
                new myData { Name = "Wanda", Description = "This is a picture of a woman", Picture_Location = "Pic05" },
                new myData { Name = "Laura", Description = "This is a picture of a woman", Picture_Location = "Pic06" },
                new myData { Name = "Anna", Description = "This is a picture of a woman", Picture_Location = "Pic07" },
                new myData { Name = "Beatrice", Description = "This is a picture of a woman", Picture_Location = "Pic08" },
                new myData { Name = "Ellen", Description = "This is a picture of a woman", Picture_Location = "Pic09" }
            };
            return myDataList;
        }
    }

    public class myData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture_Location { get; set; }
    }
}