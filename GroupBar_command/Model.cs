using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBar_command
{
    public class Model : NotificationObject
    {
        private string header;
        public string Header
        {
            get { return header; }
            set { header = value; }
        }

        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private bool isselected;

        public bool IsSelected
        {
            get { return isselected; }
            set { isselected = value; }
        }


        private int invokeParameter = 1;

        public int InvokeParameter
        {
            get { return invokeParameter; }
            set { invokeParameter = value; RaisePropertyChanged("InvokeParameter"); }
        }
    }
}
