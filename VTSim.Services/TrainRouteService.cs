namespace VTSim.Services
{
    using System.Collections.ObjectModel;

    using VTSim.Models;

    public class TrainRouteService
    {
        public TrainRouteService(int trainNumber)
        {
            this.TrainNumber = trainNumber;
        }

        public int TrainNumber { get; set; }

        public ObservableCollection<TrainStation> GetRoute()
        {
            return new ObservableCollection<TrainStation>();
        }
    }
}
