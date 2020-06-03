using BIKESobj.ApplicationServices.GetLocationListUseCase;
using BIKESobj.ApplicationServices.Ports;
using BIKESobj.DomainObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace BIKESobj.DesktopClient.InfrastructureServices.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IGetBIKESobjListUseCase _getBIKESobjListUseCase;

        public MainViewModel(IGetBIKESobjListUseCase getBIKESobjListUseCase)
            => _getBIKESobjListUseCase = getBIKESobjListUseCase;

        private Task<bool> _loadingTask;
        private bikesobj _currentBIKESobj;
        private ObservableCollection<bikesobj> _bikesobjs;

        public event PropertyChangedEventHandler PropertyChanged;

        public bikesobj CurrentBIKESobj
        {
            get => _currentBIKESobj; 
            set
            {
                if (_currentBIKESobj != value)
                {
                    _currentBIKESobj = value;
                    OnPropertyChanged(nameof(CurrentBIKESobj));
                }
            }
        }

        private async Task<bool> LoadBIKESobjs()
        {
            var outputPort = new OutputPort();
            bool result = await _getBIKESobjListUseCase.Handle(GetBIKESobjListUseCaseRequest.CreateAllBIKESobjsRequest(), outputPort);
            if (result)
            {
                BIKESobjs = new ObservableCollection<bikesobj>(outputPort.BIKESobjs);
            }
            return result;
        }

        public ObservableCollection<bikesobj> BIKESobjs
        {
            get 
            {
                if (_loadingTask == null)
                {
                    _loadingTask = LoadBIKESobjs();
                }
                
                return _bikesobjs; 
            }
            set
            {
                if (_bikesobjs != value)
                {
                    _bikesobjs = value;
                    OnPropertyChanged(nameof(BIKESobjs));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class OutputPort : IOutputPort<GetBIKESobjListUseCaseResponse>
        {
            public IEnumerable<bikesobj> BIKESobjs { get; private set; }

            public void Handle(GetBIKESobjListUseCaseResponse response)
            {
                if (response.Success)
                {
                    BIKESobjs = new ObservableCollection<bikesobj>(response.BIKESobjs);
                }
            }
        }
    }
}
