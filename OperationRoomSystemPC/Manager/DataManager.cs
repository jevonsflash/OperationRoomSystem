using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationRoomSystemPC.Model;

namespace OperationRoomSystemPC.Manager
{
    public class DataManager
    {
        private static DataManager _current;



        public static DataManager Current

        {

            get

            {

                if (_current == null)

                {

                    _current = new DataManager();



                }

                return _current;

            }



        }

        public DataManager()
        {


        }

        private List<PatientInfo> _patientInfos;

        public List<PatientInfo> PatientInfos
        {
            get
            {

                if (_patientInfos == null)
                {
                    _patientInfos = new List<PatientInfo>()
                    {
                        new PatientInfo()
                        {
                           BedNo ="42",Birthday="1987-4-5",DeptName="骨科",PatientGender=1,PatientId=2651523,PatientName="哈喽",PatientNo="sdf5s6552g",PatientSno  = "wf00001",StartTime="2017-12-12",TreatType=2
                        },                        new PatientInfo()
                        {
                           BedNo ="62",Birthday="1227-4-5",DeptName="骨科",PatientGender=1,PatientId=2651523,PatientName="你好呀",PatientNo="sdf5s6552g",PatientSno  = "wf00001",StartTime="2017-12-12",TreatType=2
                        }
                    };
                }
                return _patientInfos;
            }
            set
            {
                _patientInfos = value;
            }
        }


    }
}
