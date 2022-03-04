﻿using ExpReader.Models;
using ExpReader.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpReader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReaderPage : ContentPage
    {
        public ReaderPage(Book path)
        {
            InitializeComponent();
            BindingContext = new ReaderVM(path);
        }
    }
}