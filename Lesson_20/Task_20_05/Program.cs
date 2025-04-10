using System;

namespace AuthorizationSystem
{
	public enum AccessLevel
	{
		Guest,
		User,
		Moderator,
		Admin
	}

	class Program
	{
		static void Main(string[] args)
		{

			CheckAccess(AccessLevel.Guest, "удалить пост");
			CheckAccess(AccessLevel.User, "оставить комментарий");
			CheckAccess(AccessLevel.Moderator, "удалить пост");
			CheckAccess(AccessLevel.Admin, "изменить настройки системы");
		}


		static void CheckAccess(AccessLevel userLevel, string action)
		{
			bool hasAccess = false;

			switch (userLevel)
			{
				case AccessLevel.Guest:
					hasAccess = action == "читать";
					break;
				case AccessLevel.User:
					hasAccess = action == "читать"  action == "оставить комментарий";
					break;
				case AccessLevel.Moderator:
					hasAccess = action == "читать"  action == "оставить комментарий" || action == "удалить пост";
					break;
				case AccessLevel.Admin:
					hasAccess = true;
					break;
			}

			if (hasAccess)
			{
				Console.WriteLine($"Доступ разрешен: {userLevel} может {action}.");
			}
			else
			{
				Console.WriteLine($"Ошибка: Недостаточно прав! {userLevel} не может {action}.");
			}
		}
	}
}