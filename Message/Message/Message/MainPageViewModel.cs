using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Message
{
    public class MainPageViewModel
    {
        public Command ButtonClickedCommand { get; set; }

        public MainPageViewModel()
        {
            ButtonClickedCommand = new Command(HandleButtonClick);
        }

        private void HandleButtonClick()
        {
            MessagingCenter.Send<MainPageViewModel>(this, "ButtonClicked");
        }
    }
}
