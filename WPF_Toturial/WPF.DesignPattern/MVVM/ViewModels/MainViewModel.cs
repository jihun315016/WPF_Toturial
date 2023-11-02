using System.Windows.Input;
using WPF.DesignPattern.Models;
using WPF.DesignPattern.MVVM.Commands;

namespace WPF.DesignPattern.MVVM.ViewModels
{
    public class MainViewModel
    {
        private readonly IPersonRepository _personRepository;

        // 바인딩된 커맨드 함수를 불러오기 위해서는 ICommand를 상속받는 객체를 하나 만들어야 함
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CanCelCommand { get; set; }

        
        // 여기에 있는 값이 화면에 바인딩된다.
        // 문자열이 들어가도 오류가 발생하지 않도록 일단 string으로 변환
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Age { get; set; } = "";

        public MainViewModel(IPersonRepository personRepository)
        {
            _personRepository = personRepository;

            SaveCommand = new Commands.SaveCommand(this, personRepository);

            DeleteCommand = new RelayCommand<object>(Delete);
        }

        // object 파라미터는 사용하지 않기 때문에 _로 지정
        private void Delete(object _)
        {
            int.TryParse(Id, out int id);
            if (_personRepository.DeleteOne(id))
            {
                // 데이터 Clear
                // 데이터 Display
                // 4:20~
            }
        }
    }
}
