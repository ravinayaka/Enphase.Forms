using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Net;
using SampleForms.Library;

namespace SampleForms.PCL
{	
	public partial class FirstPage : ContentPage
	{	
		public FirstPage ()
		{
			InitializeComponent ();
		}

		public void OnNextButtonClicked(object obj, EventArgs args){

			//DisplayAlert ("Sample", "OnNextButtonClicked","Ok", "Cancel");

			//MyClass myClass = new MyClass ();
			//myClass.getResponse ();
			Navigation.PushModalAsync(new SecondPage());
		}
	}
}

