using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OperationRoomSystemPC.Enum;

namespace OperationRoomSystemPC.ViewModel
{
    public class FunctionGroupViewModel : ViewModelBase
    {

        public event EventHandler<EventArgs> OnFunctionGroupEnumRaisePropertyChanged;

        private FunctionGroupEnum _currentFunc;

        public FunctionGroupViewModel()
        {
            this.FunctionGroupSwitchCommand = new RelayCommand<string>(FunctionGroupSwitchAction);

        }

        public FunctionGroupEnum CurrentFunc
        {
            get { return _currentFunc; }
            set
            {
                _currentFunc = value;
                OnFunctionGroupEnumRaisePropertyChanged?.Invoke(this, new EventArgs());
                base.RaisePropertyChanged(nameof(CurrentFunc));
            }
        }

        public RelayCommand<string> FunctionGroupSwitchCommand { get; set; }

        private void FunctionGroupSwitchAction(string func)
        {
            switch (func)
            {
                case
                    "Function1":
                    this.CurrentFunc = FunctionGroupEnum.Function1;
                    break;
                case
                    "Function2":
                    this.CurrentFunc = FunctionGroupEnum.Function2;

                    break;
                case
                    "Function3":
                    this.CurrentFunc = FunctionGroupEnum.Function3;
                    break;
                case
                    "Function4":
                    this.CurrentFunc = FunctionGroupEnum.Function4;
                    break;
            }

        }
    }
}