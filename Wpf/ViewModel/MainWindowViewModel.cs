using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Wpf.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel
    {
		private List<Valute> _Valute;

		public List<Valute> Valute
		{
			get { return _Valute; }
			set { _Valute = value; PropChanged("Valute"); }
		}

        private double _ValoreSelezionatoDa;

        public double ValoreSelezionatoDa
        {
            get { return _ValoreSelezionatoDa; }
            set { _ValoreSelezionatoDa = value; PropChanged("ValoreSelezionatoDa"); }
        }

        private double _ValoreSelezionatoa;

        public double ValoreSelezionatoa
        {
            get { return _ValoreSelezionatoa; }
            set { _ValoreSelezionatoa = value; PropChanged("ValoreSelezionatoa"); }
        }

        private double _Importo;
        public double Importo
        {
            get { return _Importo; }
            set { _Importo = value; PropChanged("Importo"); }
        }

        private double _Risultato;
        public double Risultato
        {
            get { return _Risultato; }
            set { _Risultato = value; PropChanged("Risultato"); }
        }
        public MainWindowViewModel()
		{
            _Valute = new List<Valute>()
            {
                new Valute()
                {
                    Valore = 0,
                    Testo = "Lira"
                },

                new Valute()
                {
                    Valore = 1,
                    Testo = "Dem"
                },

                new Valute()
                {
                    Valore = 2,
                    Testo = "franchi"
                },

                new Valute()
                {
                    Valore = 3,
                    Testo = "Euro"
                }
            };

            Valute = _Valute;
		}

        public void Converti()
        {
            var client = new ServiceReference1.Service1Client();

            //Calcolo convertitore lira
            if(ValoreSelezionatoDa == 0 && ValoreSelezionatoa == 1)
            {
                Risultato = client.ConvertiDaLiraADem(Importo);
            }
            else if(ValoreSelezionatoDa == 0 && ValoreSelezionatoa == 2)
            {
                Risultato = client.ConvertiDaLiraAFranchi(Importo);
            }
            else if (ValoreSelezionatoDa == 0 && ValoreSelezionatoa == 3)
            {
                Risultato = client.ConvertiDaLiraAEuro(Importo);
            }
        }
            

    }
}
