using System;

public class User
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string ContactDetails { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public User(string name, string address, string contactDetails, string username, string password)
    {
        Name = name;
        Address = address;
        ContactDetails = contactDetails;
        Username = username;
        Password = password;
    }

    public bool Authenticate(string username, string password)
    {
        return Username == username && Password == password;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Address: {Address}, Contact Details: {ContactDetails}, Username: {Username}, Password: {Password}";
    }
}
