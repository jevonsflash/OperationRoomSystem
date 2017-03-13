using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using OperationRoomSystemPC.Common;
using OperationRoomSystemPC.Model;

namespace OperationRoomSystemPC.ViewModel
{
    public class OperationPlanPageViewModel : ViewModelBase
    {
        public OperationPlanPageViewModel()
        {

            this.TabNavigationInfos = new List<TabNavigationInfo>()
            {

                new TabNavigationInfo() {Title = "人员安排",},
                new TabNavigationInfo() {Title = "药物管理",},
                new TabNavigationInfo() {Title = "添加",},
            };

            this.OperationPlanInfos=new List<OperationPlanInfo>()
            {
                
                new OperationPlanInfo() {Title = "人员安排", Content = "VIBlend is a privately held software company specialized in building advanced User Interface components for Windows Forms, WPF and Silverlight. We create every component with passion and dedication to high quality to deliver exceptional end-user experience. Our components provide rich functionality, easy to use APIs and unparalleled performance. We are proud to build components that help businesses and developers around the world deliver better applications in less time and with lower budget. "},
                new OperationPlanInfo() {Title = "药物管理",Content = "后台代码几乎没什么用 主要做个绑定 其实完全可以忽略 在这里也贴出来 给那些完全不懂的刚入门的小朋友看下吧（免得说我的例子没发运行 呵呵）后台代码几乎没什么用 主要做个绑定 其实完全可以忽略 在这里也贴出来 给那些完全不懂的刚入门的小朋友看下吧（免得说我的例子没发运行 呵呵）"},
                new OperationPlanInfo() {Title = "器械管理",Content = "从代码中可以看出 里面没有什么东东 就是一个Itemscontrol控件 设置alternationcount=2 就是说在控件里会 01 01 01的重复 alternationindex 下面就是在datatemplate里面设置trigger了"},
                new OperationPlanInfo() {Title = "器械管理",Content = "从代码中可以看出 里面没有什么东东 就是一个Itemscontrol控件 设置alternationcount=2 就是说在控件里会 01 01 01的重复 alternationindex 下面就是在datatemplate里面设置trigger了"},
                new OperationPlanInfo() {Title = "器械管理",Content = "从代码中可以看出 里面没有什么东东 就是一个Itemscontrol控件 设置alternationcount=2 就是说在控件里会 01 01 01的重复 alternationindex 下面就是在datatemplate里面设置trigger了"},
                new OperationPlanInfo() {Title = "器械管理",Content = "从代码中可以看出 里面没有什么东东 就是一个Itemscontrol控件 设置alternationcount=2 就是说在控件里会 01 01 01的重复 alternationindex 下面就是在datatemplate里面设置trigger了"}

            };
        }

        private string text = string.Empty;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                base.RaisePropertyChanged(nameof(Text));
            }
        }

        private List<TabNavigationInfo> _tabNavigationInfos;

        public List<TabNavigationInfo> TabNavigationInfos
        {
            get { return _tabNavigationInfos; }
            set { _tabNavigationInfos = value; }
        }



        private List<OperationPlanInfo> _operationPlanInfos;

        public List<OperationPlanInfo> OperationPlanInfos
        {
            get { return _operationPlanInfos; }
            set { _operationPlanInfos = value; }
        }
    }
}
