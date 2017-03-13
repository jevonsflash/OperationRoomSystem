using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using OperationRoomSystemPC.Assets.Config;
using OperationRoomSystemPC.Common;
using Vlc.DotNet.Wpf;
using Path = System.Windows.Shapes.Path;

namespace OperationRoomSystemPC.View
{
    /// <summary>
    /// RealTimeOperationPage.xaml 的交互逻辑
    /// </summary>
    public partial class RealTimeOperationPage
    {

        public RealTimeOperationPage()

        {

            InitializeComponent();

            myControl.MediaPlayer.VlcLibDirectoryNeeded += OnVlcControlNeedsLibDirectory;
            myControl.MediaPlayer.EndInit();
        }

        private void OnVlcControlNeedsLibDirectory(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            if (currentDirectory == null)
                return;
            if (AssemblyName.GetAssemblyName(currentAssembly.Location).ProcessorArchitecture ==
                ProcessorArchitecture.X86)
            {
                var path1 = System.IO.Path.Combine(currentDirectory, @"lib\x86\");

                e.VlcLibDirectory = new DirectoryInfo(path1);
            }
            else
            {
                var path = System.IO.Path.Combine(currentDirectory, @"lib\x64\");
                e.VlcLibDirectory = new DirectoryInfo(path);

            }
        }


        private void OnPlayButtonClick(object sender, RoutedEventArgs e)
        {
           CHCActivityData.m_bInitSDK = CHCNetSDK.NET_DVR_Init();

            CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

            CHCActivityData.m_lUserID = CHCNetSDK.NET_DVR_Login_V30(CamaraConfig.DVRIPAddress,8000, CamaraConfig.UserName, CamaraConfig.Password, ref DeviceInfo);
            if (CHCActivityData.m_lUserID < 0)
            {

                MessageBox.Show("error");
                return;
            }
            else
            {
                //登录成功
                MessageBox.Show("Login Success!");

            }
            
            myControl.MediaPlayer.Play(new Uri(string.Format("rtsp://{0}:{1}@{2}:{3}/Streaming/channels/101", CamaraConfig.UserName, CamaraConfig.Password, CamaraConfig.DVRIPAddress, CamaraConfig.DVRPortNumber)));


        }

        private void OnStopButtonClick(object sender, RoutedEventArgs e)
        {
            myControl.MediaPlayer.Stop();
        }


    }
}
