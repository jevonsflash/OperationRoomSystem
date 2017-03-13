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
    public class VideoHubPageViewModel : ViewModelBase
    {
        public VideoHubPageViewModel()
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
