
using System.Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace OperationRoomSystemPC.ViewModel
{
    public class ViewModelLocator
    {
        //注册ViewModel
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginPageViewModel>();
            SimpleIoc.Default.Register<PatientListPageViewModel>();
            SimpleIoc.Default.Register<IndexPageViewModel>();
            SimpleIoc.Default.Register<VideoManagePageViewModel>();
            SimpleIoc.Default.Register<RealTimeOperationPageViewModel>();
            SimpleIoc.Default.Register<VideoHubPageViewModel>();
            SimpleIoc.Default.Register<VideoRepositoryPageViewModel>();
            SimpleIoc.Default.Register<ConsultationHubPageViewModel>();
            SimpleIoc.Default.Register<SettingPageViewModel>();
            SimpleIoc.Default.Register<UserEditPageViewModel>();
            SimpleIoc.Default.Register<OperationHubPageViewModel>();
            SimpleIoc.Default.Register<ReferralRecordPageViewModel>();
            SimpleIoc.Default.Register<EMRHubPageViewModel>();
            SimpleIoc.Default.Register<OperationPlanPageViewModel>();
        }

        //ViewModel的注入对象
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        public LoginPageViewModel LoginPage => ServiceLocator.Current.GetInstance<LoginPageViewModel>();

        public PatientListPageViewModel PatientListPage => ServiceLocator.Current.GetInstance<PatientListPageViewModel>();

        public IndexPageViewModel IndexPage => ServiceLocator.Current.GetInstance<IndexPageViewModel>();

        public VideoManagePageViewModel VideoManagePage => ServiceLocator.Current.GetInstance<VideoManagePageViewModel>();

        public RealTimeOperationPageViewModel RealTimeOperationPage => ServiceLocator.Current.GetInstance<RealTimeOperationPageViewModel>();

        public VideoHubPageViewModel VideoHubPage => ServiceLocator.Current.GetInstance<VideoHubPageViewModel>();

        public VideoRepositoryPageViewModel VideoRepositoryPage => ServiceLocator.Current.GetInstance<VideoRepositoryPageViewModel>();

        public ConsultationHubPageViewModel ConsultationHubPage => ServiceLocator.Current.GetInstance<ConsultationHubPageViewModel>();

        public SettingPageViewModel SettingPage => ServiceLocator.Current.GetInstance<SettingPageViewModel>();

        public UserEditPageViewModel UserEditPage => ServiceLocator.Current.GetInstance<UserEditPageViewModel>();

        public OperationHubPageViewModel OperationHubPage => ServiceLocator.Current.GetInstance<OperationHubPageViewModel>();

        public ReferralRecordPageViewModel ReferralRecordPage => ServiceLocator.Current.GetInstance<ReferralRecordPageViewModel>();

        public EMRHubPageViewModel EMRHubPage => ServiceLocator.Current.GetInstance<EMRHubPageViewModel>();

        public OperationPlanPageViewModel OperationPlanPage => ServiceLocator.Current.GetInstance<OperationPlanPageViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}