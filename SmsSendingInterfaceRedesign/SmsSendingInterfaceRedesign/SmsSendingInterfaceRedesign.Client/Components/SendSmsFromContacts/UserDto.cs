using System.Reflection;

namespace SmsSendingInterfaceRedesign.Client.Components.SendSmsFromContacts;

public sealed class UserDto()
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    [UserPropertySelector(UserPropertySelector.MobileNumber)]
    public required string MobileNumber { get; init; }

    [UserPropertySelector(UserPropertySelector.FirstName)]
    public required string FirstName { get; init; }
    
    [UserPropertySelector(UserPropertySelector.LastName)]
    public required string LastName { get; init; }
    
    [UserPropertySelector(UserPropertySelector.Email)]
    public required string Email { get; init; }
    
    [UserPropertySelector(UserPropertySelector.StreetAddress)]
    public required string StreetAddress { get; init; }
    
    [UserPropertySelector(UserPropertySelector.PostalCode)]
    public required string PostalCode { get; init; }
    
    [UserPropertySelector(UserPropertySelector.PostCity)]
    public required string PostCity { get; init; }
    
    [UserPropertySelector(UserPropertySelector.Gender)]
    public required string Gender { get; init; }
    
    [UserPropertySelector(UserPropertySelector.Birth)]
    public required string Birth { get; init; }

    public string FullName => $"{FirstName} {LastName}";

    public string ResolvePreviewMessage(string template)
    {
        var result = template;

        foreach (var prop in this.GetType().GetProperties())
        {
            var attr = prop.GetCustomAttribute(typeof(UserPropertySelectorAttribute)) as UserPropertySelectorAttribute;
            if (attr != null)
            {
                var value = prop.GetValue(this)!.ToString();
                var replacedValue = $"""<span style="color: red;">{value}</span>""";
                result = result.Replace($"[{attr.Selector}]", replacedValue);
            }
        }

        return result;
    }
}
