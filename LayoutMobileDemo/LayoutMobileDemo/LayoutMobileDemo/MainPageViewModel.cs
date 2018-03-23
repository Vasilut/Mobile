using System;
using System.Collections.Generic;
using System.Text;

namespace LayoutMobileDemo
{
    public class MainPageViewModel
    {
        public string Prompt { get; set; }
        public string Name { get; set; }

        public MainPageViewModel()
        {
            Prompt = "Full Name";
            Name = "Lucian Vasilut";
        }
    }
}
