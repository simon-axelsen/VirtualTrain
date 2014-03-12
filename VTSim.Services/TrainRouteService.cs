using System.Collections.ObjectModel;
using VTSim.Models;

namespace VTSim.Services
{
    public class TrainRouteService
    {
        public TrainRouteService(int trainNumber)
        {
            TrainNumber = trainNumber;
        }

        public int TrainNumber { get; set; }

        public ObservableCollection<TrainStation> GetRoute()
        {
        }
    }
}
