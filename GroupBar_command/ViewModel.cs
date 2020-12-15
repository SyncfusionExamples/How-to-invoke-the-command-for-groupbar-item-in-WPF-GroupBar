using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GroupBar_command
{
    public class ViewModel
    {
        private ICommand mouseDownClick;
        public ICommand MouseDownClick
        {
            get { return mouseDownClick; }
            set { mouseDownClick = value; }
        }

        private ObservableCollection<Model> groupItemCollection;
        public ObservableCollection<Model> GroupItemCollection
        {
            get { return groupItemCollection; }
            set { groupItemCollection = value; }
        }

        public ViewModel()
        {
            GroupItemCollection = new ObservableCollection<Model>();
            GroupItemCollection.Add(new Model() { Header = "GroupBarItem1", Content = "This is GroupBarItem", IsSelected = true });
            GroupItemCollection.Add(new Model() { Header = "GroupBarItem2", Content = "This is GroupBarItem1", IsSelected = true });
            GroupItemCollection.Add(new Model() { Header = "GroupBarItem3", Content = "This is GroupBarItem2", IsSelected = false });
            GroupItemCollection.Add(new Model() { Header = "GroupBarItem4", Content = "This is GroupBarItem3", IsSelected = true });
            GroupItemCollection.Add(new Model() { Header = "GroupBarItem5", Content = "This is GroupBarItem4", IsSelected = true });
            MouseDownClick = new DelegateCommand<object>(MouseDownClicked);
        }

        private void MouseDownClicked(object obj)
        {
            MessageBox.Show("Mouse down event called ");
            /* Perform your actions here */
        }
    }
}
