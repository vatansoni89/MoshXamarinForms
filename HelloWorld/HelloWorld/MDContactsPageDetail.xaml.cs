﻿using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MDContactsPageDetail : ContentPage
    {
        public MDContactsPageDetail(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException();
            }

            InitializeComponent();
            BindingContext = contact;
        }
    }
}