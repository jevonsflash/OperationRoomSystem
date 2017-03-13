using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OperationRoomSystemPC.Enum;

namespace OperationRoomSystemPC.ViewModel
{
    public class OperationHubPageViewModel : ViewModelBase
    {
        public OperationHubPageViewModel()
        {
            _functionGroupViewModel = new FunctionGroupViewModel();
        }


        private readonly FunctionGroupViewModel _functionGroupViewModel;


        public FunctionGroupViewModel FunctionGroupViewModel
        {
            get
            {
                return _functionGroupViewModel;
            }
        }
    }
}
