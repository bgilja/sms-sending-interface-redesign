using Bogus;
using static Bogus.DataSets.Name;

namespace SmsSendingInterfaceRedesign.Client.Components.SendSmsFromContacts;

public static class UserFaker
{
    public static readonly Faker<UserDto> Faker = new Faker<UserDto>("en_US")
        .RuleFor(user => user.MobileNumber, (faker, user) => faker.Phone.PhoneNumber())
        .RuleFor(user => user.Gender, (faker, user) => faker.Person.Gender.ToString())
        .RuleFor(user => user.FirstName, (faker, user) => user.Gender == Gender.Male.ToString() ? faker.Name.FirstName(Gender.Male) : faker.Name.FirstName(Gender.Female))
        .RuleFor(user => user.LastName, (faker, user) => faker.Name.LastName())
        .RuleFor(user => user.Email, (faker, user) => faker.Person.Email)
        .RuleFor(user => user.StreetAddress, (faker, user) => faker.Person.Address.Street)
        .RuleFor(user => user.PostalCode, (faker, user) => faker.Person.Address.ZipCode)
        .RuleFor(user => user.PostCity, (faker, user) => faker.Person.Address.City)
        .RuleFor(user => user.Birth, (faker, user) => faker.Person.DateOfBirth.ToShortDateString());
}
