namespace SmsSendingInterfaceRedesign.Client.Components.SendSmsFromContacts;

public sealed class UserDto(string firstName, string lastName)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string FirstName { get; private set; } = firstName;
    public string LastName { get; private set; } = lastName;

    public string FullName => $"{FirstName} {LastName}";
}
