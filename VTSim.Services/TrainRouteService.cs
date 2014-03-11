using System.Collections.ObjectModel;
using VTSim.Models;

namespace VTSim.Services
{
    public class TrainRouteService
    {
        private int _trainNumber;

        public TrainRouteService(int trainNumber)
        {
            TrainNumber = trainNumber;
        }

        public int TrainNumber
        {
            get { return _trainNumber; }
            set { _trainNumber = value; }
        }

//        public ObservableCollection<TrainStation> GetRoute()
//        {
//            
//        }

    }
}
