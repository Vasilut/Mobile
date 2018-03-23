using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViews.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public MainPageViewModel()
        {
            for(int i = 0;  i < 5; ++i)
            {
                Person p = new Person { Name = $"Luci {i}", Address = $"AdressOras {i + 1}" , ImageSource = $"man{i}.jpg"};
                People.Add(p);
            }
        }
    }
}
