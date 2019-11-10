﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();
            sld1.Value = 0.01;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblHello.Text = string.Format("Value is {0:F2}", e.NewValue*100);
        }
    }
}