using Caliburn.Micro;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Toturial.Caliburn.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IHandle<string>
    {
        // Caliburn.Micro에서 제공하는 인터페이스
        // 이벤트 기반 통신을 지원한다.
        private IEventAggregator _eventAggregator;

        private string _message;
        public string Message 
        {
            get => _message;
            set
            {
                _message = value;
                NotifyOfPropertyChange("Message");
            }
        }

        public ShellViewModel()
        {
            _eventAggregator = new EventAggregator();
            _eventAggregator.SubscribeOnUIThread(this);
            Task.Run(async () =>
            {
                await ActivateItemAsync(new MainViewModel(_eventAggregator));
            });
        }

        public Task HandleAsync(string message, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
