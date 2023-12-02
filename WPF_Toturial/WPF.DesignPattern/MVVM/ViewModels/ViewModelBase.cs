using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF.DesignPattern.MVVM.ViewModels
{
    // Save() 함수에서 속성들이 변경이 되었는데, 이 변경된 것을 UI에서 알지를 못 하는 것
    // > INotifyPropertyChanged를 통해 바인딩 된 데이터를 UI에 알려줄 수 있다.
    public class ViewModelBase : INotifyPropertyChanged
    {
        // 특정 속성이 변경됨을 알려주는 이벤트, 이 이벤트를 invoke해서 알려줘야 함
        public event PropertyChangedEventHandler? PropertyChanged;

        // [CallerMemberName]
        // 기본 값이 null로 지정되었을 때, 이 함수를 호출한 멤버의 이름이 그대로 넘어오게 된다.
        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
