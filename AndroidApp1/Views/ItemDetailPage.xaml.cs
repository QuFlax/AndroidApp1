﻿using AndroidApp1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AndroidApp1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}