using Android.App;
using Android.Content;
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
    [Activity(Label = "ActivityDetalleContinente")]
    public class ActivityDetalleContinente : Activity
    {
        Contienente contienente;
        TextView txtNombre;
        ListView vlista;
        List<Pais> paisFiltrados;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.detalleContinente);
            int id = Intent.GetIntExtra("idContinente", 0);
            contienente = Global.lContinentes.Where(c => c.IdContinente == id).FirstOrDefault();

            txtNombre = FindViewById<TextView>(Resource.Id.lbl1);
            //txtDescripcion = FindViewById<TextView>(Resource.Id.lbl2);
            vlista = FindViewById<ListView>(Resource.Id.lv1);

            txtNombre.Text = contienente.DescripcionPais;
            paisFiltrados = Global.lPaises.Where(p => p.ContinenteId == contienente.IdContinente).ToList();
            vlista.Adapter = new AdapterPaises(this, paisFiltrados);
            //txtDescripcion.Text=contienente.

            //vlista.Adapter = new AdapterPaises(this, Global.lPaises);
            vlista.ItemClick += Lview_ItemClick;
        }

        private void Lview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityDetallePais));
            Pais pais = paisFiltrados[e.Position];
            i.PutExtra("idPais", pais.IdPais);
            StartActivity(i);
        }

    }
}