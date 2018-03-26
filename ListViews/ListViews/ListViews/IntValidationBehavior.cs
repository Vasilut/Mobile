using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListViews
{
    public class IntValidationBehavior: Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(bindable);
        }


        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            bool valid = int.TryParse(e.NewTextValue, out int result);
            Entry entry = sender as Entry;
            entry.TextColor = valid ? Color.Default : Color.Red;
        }
    }
}
