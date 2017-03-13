using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using OperationRoomSystemPC.Common;
using OperationRoomSystemPC.Util;
using OperationRoomSystemPC.View;

namespace OperationRoomSystemPC.ViewModel
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel()
        {
            this.LoginCommand = new RelayCommand(LoinAction);
            this.UserName = "用户名";
            this.Password = "密码";
        }

        private void LoinAction()
        {
            //
            Messenger.Default.Send(new NavigationArg(typeof(PatientListPage)), TokenUtil.NavigationToken);

        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private bool _isRememberMe;

        public bool IsRememberMe
        {
            get { return _isRememberMe; }
            set { _isRememberMe = value; }
        }


        public RelayCommand LoginCommand { get; set; }
    }
}
