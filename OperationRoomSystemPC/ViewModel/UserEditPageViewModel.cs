using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace OperationRoomSystemPC.ViewModel
{
    public class UserEditPageViewModel : ViewModelBase
    {

        public UserEditPageViewModel()
        {
            SwitchCommand = new RelayCommand<string>(SwitchAction);
        }

        private void SwitchAction(string obj)
        {
            var result = true;
            bool.TryParse(obj, out result);

            this.IsChangePassword = result;
        }

        private bool _isChangePassword;

        public bool IsChangePassword
        {
            get { return _isChangePassword; }
            set
            {
                _isChangePassword = value;

                RaisePropertyChanged(nameof(IsChangePassword));
            }
        }

        public RelayCommand<string> SwitchCommand { get; set; }

    }
}
