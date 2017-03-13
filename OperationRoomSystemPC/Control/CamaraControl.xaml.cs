using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OperationRoomSystemPC.Assets.Config;
using OperationRoomSystemPC.Common;

namespace OperationRoomSystemPC.Control
{
    /// <summary>
    /// CamaraControl.xaml 的交互逻辑
    /// </summary>
    public partial class CamaraControl : UserControl
    {

        public int m_lRealHandle = -1;
        public int m_lChannel = -1;
        private bool bAuto = false;
        public CamaraControl()
        {
            Loaded += CamaraControl_Loaded;

            InitializeComponent();


            this.m_lChannel = int.Parse(CamaraConfig.Channel);
        }

        private void CamaraControl_Loaded(object sender, RoutedEventArgs e)
        {


            this.CamaraSpeeds = new List<int>();
            this.CamaraSpeeds.Add(1);
            this.CamaraSpeeds.Add(2);
            this.CamaraSpeeds.Add(3);
            this.CamaraSpeeds.Add(4);
            this.CamaraSpeeds.Add(5);
            this.CamaraSpeeds.Add(6);
            this.comboBoxSpeed.ItemsSource = this.CamaraSpeeds;
            comboBoxSpeed.SelectedIndex = 3;

        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {


            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.PAN_LEFT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {

            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.PAN_LEFT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.TILT_UP, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.TILT_UP, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.PAN_RIGHT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.PAN_RIGHT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.TILT_DOWN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.TILT_DOWN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {


            if (!bAuto)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.PAN_AUTO, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                btnAuto.Content = "Stop";
                bAuto = true;
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(CHCActivityData.m_lUserID, m_lChannel, CHCNetSDK.PAN_AUTO, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                btnAuto.Content = "Auto";
                bAuto = false;
            }

        }


        public List<int> CamaraSpeeds { get; set; }
    }
}
