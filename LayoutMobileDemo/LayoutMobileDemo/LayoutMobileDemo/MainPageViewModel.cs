using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace LayoutMobileDemo
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public string Prompt { get; set; }
        public string Name { get; set; }

        private string _labelText = "Hello";

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public string LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                RaisePropertyChanged();
            }
        }

        private Command _changeTextCommand;

        public Command ChangeTextCommand
        {
            get
            {
                return _changeTextCommand ?? (_changeTextCommand = new Command(() => 
                {

                    LabelText = "GoodBye";
                }));
            }
        }

        public MainPageViewModel()
        {
            Prompt = "Full Name";
            Name = "Lucian Vasilut";
        }
    }
}
