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
    internal class AdapterContinentes : BaseAdapter
    {
        Activity context;
        List<Contienente> lista;

        public AdapterContinentes(Activity context, List<Contienente> lista)
        {
            this.Context = context;
            this.Lista = lista;
            
        }

        public override int Count =>lista.Count;

        public Activity Context { get => context; set => context = value; }
        public List<Contienente> Lista { get => lista; set => lista = value; }

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
            //Elemento devuelto
            var item = lista[position];
            //Formato
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            TextView txtContinente = view.FindViewById<TextView>(Android.Resource.Id.Text1);
            txtContinente.Text = item.DescripcionPais;
            txtContinente.SetTextColor(Color.LightGray);
            
            TextView txtConteoContinente = view.FindViewById<TextView>(Android.Resource.Id.Text2);
            txtConteoContinente.Text = Global.lPaises.Where(p => p.ContinenteId == item.IdContinente).Count().ToString();
            txtConteoContinente.SetTextColor(Color.LightGray);
            
            return view;
        }
    }
}