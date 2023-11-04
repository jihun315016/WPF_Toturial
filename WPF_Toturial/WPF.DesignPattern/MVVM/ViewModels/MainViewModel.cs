using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.PeerToPeer.Collaboration;
using System.Windows.Input;
using WPF.DesignPattern.Models;
using WPF.DesignPattern.MVVM.Commands;

namespace WPF.DesignPattern.MVVM.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly IPersonRepository _personRepository;

    // 바인딩된 커맨드 함수를 불러오기 위해서는 ICommand를 상속받는 객체를 하나 만들어야 함
    public ICommand SaveCommand { get; set; }
    public ICommand DeleteCommand { get; set; }
    public ICommand CanCelCommand { get; set; }
    public ICommand MouseLeftButtonUpCommand { get; set; }


    private string _id = "";
    private string _name = "";
    private string _gender = "";
    private string _age = "";
    ObservableCollection<Person> _people;
    // 여기에 있는 값이 화면에 바인딩된다.
    // 문자열이 들어가도 오류가 발생하지 않도록 일단 string으로 변환
    public string Id
    {
        get => _id;
        set
        {
            _id = value;

            // OnPropertyChanged()를 호출하게 되면 이 함수를 호출한 Id라는 이름이 파라미터로 넘어가게 된다.
            // 이 기능이 [CallerMemberName] 어트리뷰트
            OnPropertyChanged();
        }
    }

    public string Name 
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged();
        }
    }
    public string Gender 
    {
        get => _gender;
        set
        {
            _gender = value;
            OnPropertyChanged();
        }
    }
    public string Age 
    {
        get => _age;
        set
        {
            _age = value;
            OnPropertyChanged();
        }
    }
    public ObservableCollection<Person> People 
    {
        get => _people;
        set
        {
            _people = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel(IPersonRepository personRepository)
    {
        _personRepository = personRepository;

        SaveCommand = new Commands.SaveCommand(this, personRepository);

        DeleteCommand = new RelayCommand<object>(Delete, CanDelete);

        CanCelCommand = new RelayCommand<object>(_ => Clear());

        MouseLeftButtonUpCommand = new RelayCommand<Person>(MouseLeftButtonUp);

        DisplayListView();
    }

    private void MouseLeftButtonUp(Person person)
    {
        Id = person.Id.ToString();
        Name = person.Name;
        Gender = person.Gender;
        Age = person.Age.ToString();
    }

    private bool CanDelete(object _)
    {
        int.TryParse(Id, out int id);
        return id > 0;
    }

    // object 파라미터는 사용하지 않기 때문에 _로 지정
    private void Delete(object _)
    {
        int.TryParse(Id, out int id);
        if (_personRepository.DeleteOne(id))
        {
            Clear();
            DisplayListView();
        }
    }

    public void Clear()
    {
        Id = "";
        Name = "";
        Gender = "";
        Age = "";

        // Id가 변경됨을 알려준다.
        // > 저장 버튼을 클릭하면 Id 값이 지워진다.
        // OnPropertyChanged("Id");
    }

    public void DisplayListView()
    {
        People = new ObservableCollection<Person>(_personRepository.GetAll()!);

        // People이 변경됨을 알려준다.
        // > 저장 버튼을 클릭하면 리스트 박스에 표시된다.
        // OnPropertyChanged("People");
    }
}
