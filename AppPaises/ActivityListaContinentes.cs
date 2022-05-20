using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPaises
{
    [Activity(Label = "ActivityListaContinentes", MainLauncher = true)]
    public class ActivityListaContinentes : Activity
    { 
        ListView lview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.listaContinentes);
            lview = FindViewById<ListView>(Resource.Id.lvContinentes);
           
            lview.Adapter = new AdapterContinentes(this,Global.lContinentes);
            
            lview.ItemClick += Lview_ItemClick;
        }

        private void Lview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this,typeof(ActivityDetalleContinente));
            Contienente contienente = Global.lContinentes[e.Position];
            i.PutExtra("idContinente",contienente.IdContinente);
            StartActivity(i);
        }
    }
}