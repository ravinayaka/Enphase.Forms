using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SampleForms.PCL
{	
	public partial class Settings : ContentPage
	{	
		public Settings ()
		{
			InitializeComponent ();

		}
		public void onDoneButtonClicked(object obj, EventArgs args){

			Navigation.PushModalAsync (new LandingPage());
		}
		public void onLogoutClicked(object obj, EventArgs args){

			Navigation.PushModalAsync (new LoginPage ());
		}
	}
}

