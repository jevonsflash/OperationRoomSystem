using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using OperationRoomSystemPC.Common;

namespace OperationRoomSystemPC.ViewModel
{
    public class ReferralRecordPageViewModel : ViewModelBase
    {

        public ReferralRecordPageViewModel()
        {

            this.TabNavigationInfos = new List<TabNavigationInfo>()
            {

                new TabNavigationInfo() { Title = "测试医院1", },
                new TabNavigationInfo() { Title = "测试医院2", },
                new TabNavigationInfo() { Title = "测试医院3", },
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
