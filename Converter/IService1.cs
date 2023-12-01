using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Converter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        double ConvertiDaLiraADem(double value);

        [OperationContract]

        double ConvertiDaLiraAFranchi(double value);

        [OperationContract]

        double ConvertiDaLiraAEuro(double value);

        [OperationContract]

        double ConvertiDaDemLira(double value);

        [OperationContract]

        double ConvertiDaDemAFranchi(double value);

        [OperationContract]

        double ConvertiDaDemAEuro(double value);

        [OperationContract]

        double ConvertiDaFranchiADem(double value);

        [OperationContract]

        double ConvertiDaFranchiALira(double value);

        [OperationContract]

        double ConvertiDaFranchiAEuro(double value);

    }
        // TODO: Add your service operations here



        // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
