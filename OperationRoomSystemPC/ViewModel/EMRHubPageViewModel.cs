using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using OperationRoomSystemPC.Common;

namespace OperationRoomSystemPC.ViewModel
{
    public class EMRHubPageViewModel : ViewModelBase
    {
        public EMRHubPageViewModel()
        {


            this.TabNavigationInfos=new List<TabNavigationInfo>()
            {
                
                new TabNavigationInfo() { Title = "现病历", },
                new TabNavigationInfo() { Title = "既往史", },
                new TabNavigationInfo() { Title = "个人史", },
            };
        }







        private List<TabNavigationInfo> _tabNavigationInfos;

        public List<TabNavigationInfo> TabNavigationInfos
        {
            get { return _tabNavigationInfos; }
            set { _tabNavigationInfos = value; }
        }


    }
}
