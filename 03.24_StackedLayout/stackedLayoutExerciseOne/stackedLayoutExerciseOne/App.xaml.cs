﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace stackedLayoutExerciseOne
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WelcomeScreen();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
