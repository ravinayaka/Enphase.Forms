using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SampleForms.PCL
{	
	public partial class LandingPage : ContentPage
	{	
		//private ListView mListView;
		public LandingPage ()
		{
			InitializeComponent ();
				
		}

		public void OnSettingsButtonClicked(object obj, EventArgs args){
			Navigation.PushModalAsync(new Settings());
		}
		public void OnConnectToEnvoyClicked(object obj, EventArgs args){
			Navigation.PushModalAsync(new ConnectToEnvoy());
		}


	}
}

