
using System;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Widget;
using Plugin.CurrentActivity;

namespace Support.Droid
{

    [Activity(Label = "AddItemActivity")]
    public class AddItemActivity : Activity
    {
        FloatingActionButton saveButton;
        EditText title, description;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);



            saveButton.Click += SaveButton_Click;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            Finish();
        }
    }
}
