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

			CheckAccess(AccessLevel.Guest, "������� ����");
			CheckAccess(AccessLevel.User, "�������� �����������");
			CheckAccess(AccessLevel.Moderator, "������� ����");
			CheckAccess(AccessLevel.Admin, "�������� ��������� �������");
		}


		static void CheckAccess(AccessLevel userLevel, string action)
		{
			bool hasAccess = false;

			switch (userLevel)
			{
				case AccessLevel.Guest:
					hasAccess = action == "������";
					break;
				case AccessLevel.User:
					hasAccess = action == "������"  action == "�������� �����������";
					break;
				case AccessLevel.Moderator:
					hasAccess = action == "������"  action == "�������� �����������" || action == "������� ����";
					break;
				case AccessLevel.Admin:
					hasAccess = true;
					break;
			}

			if (hasAccess)
			{
				Console.WriteLine($"������ ��������: {userLevel} ����� {action}.");
			}
			else
			{
				Console.WriteLine($"������: ������������ ����! {userLevel} �� ����� {action}.");
			}
		}
	}
}