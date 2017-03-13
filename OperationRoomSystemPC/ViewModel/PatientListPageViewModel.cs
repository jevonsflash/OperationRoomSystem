using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using OperationRoomSystemPC.Common;
using OperationRoomSystemPC.Manager;
using OperationRoomSystemPC.Model;
using OperationRoomSystemPC.Util;
using OperationRoomSystemPC.View;

namespace OperationRoomSystemPC.ViewModel
{
    public class PatientListPageViewModel : ViewModelBase
    {

        public PatientListPageViewModel()
        {
            PropertyChanged += PatientListPageViewModel_PropertyChanged;

        }
        private void GoIndexAction()
        {
            Messenger.Default.Send(new NavigationArg(typeof(IndexPage)), TokenUtil.NavigationToken);
        }

        private void PatientListPageViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SelectedPatientInfo))
            {
                GoIndexAction();
            }
        }

        private ObservableCollection<PatientInfo> _patientInfos;

        public ObservableCollection<PatientInfo> PatientInfos
        {
            get
            {
                if (_patientInfos == null)
                {
                    _patientInfos = new ObservableCollection<PatientInfo>(DataManager.Current.PatientInfos);
                }
                return _patientInfos;
            }
            set
            {
                _patientInfos = value;
                base.RaisePropertyChanged(nameof(PatientInfos));
            }
        }
        private PatientInfo _selectedPatientInfo;

        public PatientInfo SelectedPatientInfo
        {
            get { return _selectedPatientInfo; }
            set
            {
                _selectedPatientInfo = value;
                base.RaisePropertyChanged(propertyName: "SelectedPatientInfo");

            }
        }


    }
}
