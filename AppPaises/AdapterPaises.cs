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
    internal class AdapterPaises : BaseAdapter
    {
        Activity context;
        List<Pais> lista;

        public AdapterPaises(Activity context, List<Pais> lista)
        {
            this.Context = context;
            this.Lista = lista;
        }

        public override int Count => lista.Count;

        public Activity Context { get => context; set => context = value; }
        public List<Pais> Lista { get => lista; set => lista = value; }

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

            TextView txtPais=view.FindViewById<TextView>(Android.Resource.Id.Text1);
            txtPais.Text = item.Descripcion;
            txtPais.SetTextColor(Color.LightGray);
            
            return view;
        }
    }
}