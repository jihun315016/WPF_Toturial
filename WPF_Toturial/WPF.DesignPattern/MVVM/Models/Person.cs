namespace WPF.DesignPattern.MVVM.Models;

public class Person
{
    public int Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Gender { get; set; } = default!;
    public int Age { get; set; } = default!;

    public void Update(Person person)
    {
        Name = person.Name;
        Gender = person.Gender;
        Age = person.Age;
    }
}
