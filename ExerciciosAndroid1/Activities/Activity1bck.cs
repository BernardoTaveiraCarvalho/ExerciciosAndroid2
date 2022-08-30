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

namespace ExerciciosAndroid1.Activities
{
    [Activity(Label = "Activity2")]
    public class Activity1bck : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutActivity1);
                Button btn_apontador_para = FindViewById<Button>(Resource.Id.btn);
                EditText txt_apontador_para = FindViewById<EditText>(Resource.Id.txt);
                TextView lbl2_apontador_para = FindViewById<TextView>(Resource.Id.lbl2);
                btn_apontador_para.Click += delegate
                {

                    try
                    {

                        double valor = double.Parse(txt_apontador_para.Text);
                        double resultado = Math.Sqrt(valor);
                        lbl2_apontador_para.Text = $"Resultado: {resultado}";
                    }
                    catch (SystemException e)
                    {
                        lbl2_apontador_para.Text = $"Erro: {e}";
                    }
                };
            
          
            
        }
    }
}