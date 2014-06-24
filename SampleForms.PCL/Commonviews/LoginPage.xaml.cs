using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SampleForms.PCL
{	
	public partial class LoginPage : ContentPage
	{	
		public LoginPage ()
		{
			InitializeComponent ();
		}
		public void OnNextButtonClicked(object obj, EventArgs args){
			Navigation.PushModalAsync(new LandingPage());
		}
	}
}

