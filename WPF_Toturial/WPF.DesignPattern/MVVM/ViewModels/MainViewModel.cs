using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.DesignPattern.Models;

namespace WPF.DesignPattern.MVVM.ViewModels
{
    public class MainViewModel
    {
        private readonly IPersonRepository _personRepository;
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CanCelCommand { get; set; }

        // 바인딩된 커맨드 함수를 불러오기 위해서는 ICommand를 상속받는 객체를 하나 만들어야 함



        // 문자열이 들어가도 오류가 발생하지 않도록 일단 string으로 변환
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Sex { get; set; } = "";
        public string Age { get; set; } = "";

        public MainViewModel(IPersonRepository personRepository)
        {
            _personRepository = personRepository;

            SaveCommand = new Commands.SaveCommand(this, personRepository);
        }
    }
}
