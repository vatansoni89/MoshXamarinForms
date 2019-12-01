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
    public partial class ContactMethodsPage : ContentPage
    {
        public ContactMethodsPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<string> {
            "None","EMail","SMS"
            };
        }

        public Xamarin.Forms.ListView ContactMethods { get { return listView; } }
    }
}