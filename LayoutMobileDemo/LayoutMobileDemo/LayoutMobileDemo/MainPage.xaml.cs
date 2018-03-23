using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutMobileDemo
{
	public partial class MainPage : ContentPage
	{
        private MainPageViewModel _vm;
		public MainPage()
		{
			InitializeComponent();
            _vm = new MainPageViewModel();
            BindingContext = _vm;
		}
	}
}
