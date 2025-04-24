namespace SmsSendingInterfaceRedesign.Client.Components.SendSmsFromContacts;

public sealed class UserGroupDto(string name, IList<UserDto> users)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; } = name;
    public IList<UserDto> Users { get; private set; } = users;
}
