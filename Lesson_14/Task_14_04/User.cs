class User
{
    public static User CurrentUser { get; private set; }

    public string Username { get; private set; }

    private User(string username) 
    {
        Username = username;
    }

    public static void SetCurrentUserr(string username)
    {
        CurrentUser = new User(username);
    }

    public static void DisplayCurrentUser()
    {
        if (CurrentUser != null)
        {
            Console.WriteLine($"Текущий пользователь: {CurrentUser.Username}");
        }
        else
        {
            Console.WriteLine("Текущий пользователь не установлен");
        }
    }
}