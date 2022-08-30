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
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            LinearLayout mainLayout = new LinearLayout(this);
            mainLayout.Orientation = Orientation.Vertical;

            TextView lbl1 = new TextView(this);
            TextView lbl2 = new TextView(this);
            EditText txt = new EditText(this);
            Button btn = new Button(this);

            lbl1.Text = "Cálculo de Raiz Quadrada";
            lbl1.SetTextSize(Android.Util.ComplexUnitType.Dip, 30);
            btn.Text = "Calcular";
            btn.Click += delegate
            {
                try
                {

                
                double valor = double.Parse(txt.Text);
                double resultado = Math.Sqrt(valor);
                lbl2.Text = $"Resultado: {resultado}";
                }
                catch(SystemException e)
                {
                    lbl2.Text = $"Erro: {e}";
                }
            };

            mainLayout.AddView(lbl1);

            mainLayout.AddView(txt);

            mainLayout.AddView(btn);

            mainLayout.AddView(lbl2);
            SetContentView(mainLayout);
        }
    }
}