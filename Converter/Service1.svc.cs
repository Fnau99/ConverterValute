using System;
using static Converter.IService1;

namespace Converter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //1 euro vale
        double Dem = 1.95583; 
        double Lira = 1936.27;
        double Franchi = 6.55957;

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        #region Lira
        public double ConvertiDaLiraADem(double value)
        {
            return value * Lira / Dem;
        }

        public double ConvertiDaLiraAFranchi(double value)
        {
            return value * Lira / Franchi;
        }

        public double ConvertiDaLiraAEuro(double value)
        {
            return value / Lira;
        }
        #endregion

        #region Dem
        public double ConvertiDaDemLira(double value)
        {
            return value * Dem / Lira;
        }

        public double ConvertiDaDemAFranchi(double value)
        {
            return value * Dem / Franchi;
        }

        public double ConvertiDaDemAEuro(double value)
        {
            return value / Lira;
        }
        #endregion

        #region Lira
        public double ConvertiDaFranchiADem(double value)
        {
            return value * Franchi / Dem;
        }

        public double ConvertiDaFranchiALira(double value)
        {
            return value * Franchi / Lira;
        }

        public double ConvertiDaFranchiAEuro(double value)
        {
            return value / Franchi;
        }
        #endregion

        #region Euro
        public double ConvertiDaEuroADem(double value)
        {
            return value * Dem;
        }

        public double ConvertiDaEuroALira(double value)
        {
            return value * Lira;
        }

        public double ConvertiDaEuroAFranchi(double value)
        {
            return value * Franchi;
        }
        #endregion

    }
}
