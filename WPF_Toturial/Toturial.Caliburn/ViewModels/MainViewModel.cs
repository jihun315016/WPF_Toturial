using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Toturial.Caliburn.ViewModels
{
    public class MainViewModel : Screen
    {
        private IEventAggregator _eventAggregator;
        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                NotifyOfPropertyChange("Title");
            }
        }

        public MainViewModel(IEventAggregator eventAgg)
        {
            Title = "Hello World";
            _eventAggregator = eventAgg;
        }

        protected override async Task OnDeactivateAsync(bool close, CancellationToken cancellationToken)
        {
            await _eventAggregator.PublishOnUIThreadAsync("Closing");
        }
    }
}
