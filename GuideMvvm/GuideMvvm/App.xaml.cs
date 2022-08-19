﻿using GuideMvvm.Views;
using Xamarin.Forms;

namespace GuideMvvm
{
   public partial class App : Application
   {
      public App()
      {
         InitializeComponent();

         MainPage = new NavigationPage(new InitialPage());
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
