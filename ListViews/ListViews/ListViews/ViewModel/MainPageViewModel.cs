using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static System.Math;

namespace ListViews.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public MainPageViewModel()
        {
            Random rand = new Random();
            for(int i = 0;  i < 5; ++i)
            {
                Person p = new Person { FirstName = $"Luci {i}", LastName= $"Vasilut{i}", Address = $"AdressOras {i + 1}" , ImageSource = $"man{i}.jpg"};
                p.Age = (decimal)(35 + rand.NextDouble());
                People.Add(p);
            }
        }
    }
}
