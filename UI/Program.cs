using System;
using BusinessLayer;
using DataLayer;


namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
			//email: "employee@leaves.company";
			//password: "password"

			int count = 0;
			while (count < 5)
			{
				if (count == 4)
				{
					Console.WriteLine("Maximum tries exceeded!");
					return;
				}

				//SqlData.Connect();

				Console.WriteLine("Enter email for Login: ");
				string InputEmail = Console.ReadLine();
				Console.WriteLine("Enter Password: ");
				string InputPassword = Console.ReadLine();

				if (InputEmail == "employee@leaves.company" && InputPassword == "password")
				{
					Console.WriteLine("Login Succesful");
					Menu.selection();
					break;
				}


				else
				{
					count++;
				}


			}
		}
    }
}
