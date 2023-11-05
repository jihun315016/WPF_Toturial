# MVVM
## Models
- **Person**  
    - 데이터가 정의된 모델  
- **IPersonRepository**  
    - Person과 관련된 로직 처리가 명시된 인터페이스  
- **PersonRepository**  
    - Person과 관련된 로직을 처리하는 Repository 클래스  
<br/>

## Views
- **MainView**
    - 애플리케이션에 사용된 UI  
<br/>

## ViewModels
- **MainViewModel**  
    - View와 Model 사이의 연결 고리 역할
    - UI 로직 담당
        - 사용자 입력 처리 : ICommand를 활용한 이벤트 처리
        - Model의 상태 변경 : IPersonRepository를 통한 CRUD 
- **ViewModelBase**  
    - ViewModel들이 공통으로 사용되는 부분 작성
<br/>

## Commands
- **SaveCommand, RelayCommand**  
    - 각 이벤트 실행에 대한 로직
    - Command는 MVVM에서 ViewModel의 일부분으로 간주할 수 있다.
- **CommandBase**  
    - 각 Command가 동작할 공통 부분 작성
