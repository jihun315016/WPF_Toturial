using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.DesignPattern.MVVM.Models;
using WPF.DesignPattern.MVVM.ViewModels;
using WPF.DesignPattern.MVVM.Views;

namespace WPF.DesignPattern.MVVM.Commands
{
    public class SaveCommand : CommandBase
    {
        // 직접 입력한 속성 START
        private MainViewModel _mainViewModel;
        private IPersonRepository _personRepository;
        // 직접 입력한 속성 END
     
        public SaveCommand(MainViewModel mainViewModel, IPersonRepository personRepository)
        {
            _mainViewModel = mainViewModel;
            _personRepository = personRepository;
        }

        private Person GetPerson()
        {
            var person = new Person()
            {
                Name = _mainViewModel.Name,
                Gender = _mainViewModel.Gender
            };

            int.TryParse(_mainViewModel.Id, out int id);
            int.TryParse(_mainViewModel.Age, out int age);
            person.Id = id;
            person.Age = age;

            return person;
        }

        private bool IsValidSave(Person person)
        {
            if (person.Id <= 0)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.Name))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.Gender))
            {
                return false;
            }

            if (person.Age <= 0)
            {
                return false;
            }

            return true;
        }

        private void Save()
        {
            var person = GetPerson();
            if (_personRepository.SaveOne(person))
            {
                _mainViewModel.Clear();
                _mainViewModel.DisplayListView();
            }
        }

        // Execute 실행 가능 여부
        // false 반환 시 버튼 비활성화
        public override bool CanExecute(object? parameter)
        {
            return IsValidSave(GetPerson());
        }

        // 버튼이 실행될 때 호출
        public override void Execute(object? parameter)
        {
            Save();
        }        
    }
}
