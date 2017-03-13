using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OperationRoomSystemPC.Enum;

namespace OperationRoomSystemPC.ViewModel
{
    public class ConsultationHubPageViewModel : ViewModelBase
    {


        public ConsultationHubPageViewModel()
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
