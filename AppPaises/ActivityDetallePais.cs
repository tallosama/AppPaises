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
    [Activity(Label = "ActivityDetallePais")]
    public class ActivityDetallePais : Activity
    {
        Pais pais;
        TextView txtNombre, txtCapital, txtisoDos, txtisoTres, txtsalida, txtNumero;
        Button btnLlamar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.detallePais);

            int id = Intent.GetIntExtra("idPais", 0);
            pais = Global.lPaises.Where(p => p.IdPais == id).FirstOrDefault();

            txtNombre = FindViewById<TextView>(Resource.Id.lbl2);
            txtNombre.Text =pais.Descripcion;

            txtCapital = FindViewById<TextView>(Resource.Id.lbl3);
            txtCapital.Text = "Capital: " + pais.Capital;

            txtisoDos = FindViewById<TextView>(Resource.Id.lbl5);
            txtisoDos.Text = "ISO2: " + pais.IsoDos;

            txtisoTres = FindViewById<TextView>(Resource.Id.lbl6);
            txtisoTres.Text = "ISO3: " + pais.IsoTres;

            txtsalida = FindViewById<TextView>(Resource.Id.lbl4);
            txtsalida.Text = "Prefijo: " + pais.Prefijo.ToString();

            btnLlamar = FindViewById<Button>(Resource.Id.btnLlamar);
            btnLlamar.Click += BtnLlamar_Click;

            txtNumero = FindViewById<TextView>(Resource.Id.txtNumero);

        }

        private void BtnLlamar_Click(object sender, EventArgs e)
        {

            if (txtNumero.Text.Trim().Length == 0)
            {
                Toast.MakeText(Application.Context, "Debe de ingresar un número!", ToastLength.Short).Show();

            }
            else
            {
                Intent i = new Intent(Intent.ActionCall);
                i.SetData(Android.Net.Uri.Parse("tel:" + "+(" + pais.Prefijo + ")" + txtNumero.Text));
                StartActivity(i);
            }
            // 

        }
    }
}