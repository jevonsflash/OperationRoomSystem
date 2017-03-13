using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using OperationRoomSystemPC.Common;
using OperationRoomSystemPC.Util;
using OperationRoomSystemPC.View;

namespace OperationRoomSystemPC.ViewModel
{
    public class IndexPageViewModel
    {
        public IndexPageViewModel()
        {
            this.GoPageCommand = new RelayCommand<string>(GoPageAction);
        }

        private void GoPageAction(string pageType)
        {
            var type = Type.GetType(App.Current.GetType().Namespace + ".View." + pageType, true, true);
            Messenger.Default.Send(new NavigationArg(type), TokenUtil.NavigationToken);
        }

        public RelayCommand<string> GoPageCommand { get; set; }
    }
}
