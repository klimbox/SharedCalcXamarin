using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SharedCalc.Droid
{
	[Activity (Label = "SharedCalc.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

        private ICalculation c = new ServerCalculation("http://198.168.0.103:9999");


        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            TextView Screen = FindViewById<TextView>(Resource.Id.tbScreen);

            Button btnNum1 = FindViewById<Button>(Resource.Id.btnNum1);
            Button btnNum2 = FindViewById<Button>(Resource.Id.btnNum2);
            Button btnNum3 = FindViewById<Button>(Resource.Id.btnNum3);
            Button btnNum4 = FindViewById<Button>(Resource.Id.btnNum4);
            Button btnNum5 = FindViewById<Button>(Resource.Id.btnNum5);
            Button btnNum6 = FindViewById<Button>(Resource.Id.btnNum6);
            Button btnNum7 = FindViewById<Button>(Resource.Id.btnNum7);
            Button btnNum8 = FindViewById<Button>(Resource.Id.btnNum8);
            Button btnNum9 = FindViewById<Button>(Resource.Id.btnNum9);
            Button btnNum0 = FindViewById<Button>(Resource.Id.btnNum0);

            Button btnPlus = FindViewById<Button>(Resource.Id.btnPlus);
            Button btnMinus = FindViewById<Button>(Resource.Id.btnMin);
            Button btnMul = FindViewById<Button>(Resource.Id.btnMul);
            Button btnDiv = FindViewById<Button>(Resource.Id.btnDiv);

            Button btnCount = FindViewById<Button>(Resource.Id.btnCount);
            Button btnClear = FindViewById<Button>(Resource.Id.btnClear);

            btnClear.Click += (object sender, EventArgs e) =>
            {
                Screen.Text = "";
            };

            btnClear.Click += (object sender, EventArgs e) =>
            {
                Screen.Text = "";
            };

            // btCount Click Handle
            btnCount.Click += (object sender, EventArgs e) =>
            {
                int r = 0;
                try
                {
                    //r = CountFromString.Input(Screen.Text);
                    string[] inp = Screen.Text.Split(' ');
                    r = c.Calculate(inp[0], inp[2], inp[1]);
                    Screen.Text = r.ToString();
                }
                catch (System.Exception)
                {
                    Screen.Text = "Can't count, too hard =(";
                }

                
            };
            //end of Click

            btnNum1.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum1.Text;
            };

            btnNum2.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum2.Text;
            };

            btnNum3.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum3.Text;
            };

            btnNum4.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum4.Text;
            };

            btnNum5.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum5.Text;
            };

            btnNum6.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum6.Text;
            };

            btnNum7.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum7.Text;
            };

            btnNum8.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum8.Text;
            };

            btnNum9.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum9.Text;
            };

            btnNum0.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += btnNum0.Text;
            };


            btnPlus.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += " " + btnPlus.Text + " ";
            };

            btnMinus.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += " " + btnMinus.Text + " ";
            };

            btnMul.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += " " + btnMul.Text + " ";
            };

            btnDiv.Click += (object sender, EventArgs e) =>
            {
                Screen.Text += " " + btnDiv.Text + " ";
            };
        }
	}
}


