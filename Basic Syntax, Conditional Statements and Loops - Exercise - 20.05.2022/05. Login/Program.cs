using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            /*On the first line, you will be given a username and your 
             * task is to try to log in the user. The user's password is the username reversed. 
             * On the next lines, you will receive passwords:
                If the password is incorrect, print "Incorrect password. Try again.".
                If the password is correct, print "User {username} logged in." and stop the program.
                Keep in mind that if the password is still incorrect on the fourth attempt, 
            you should print: "User {username} blocked!".
             */

            string username = Console.ReadLine();
            string password = "";

            for ( int i = username.Length-1; i>=0; i--)
            {
                password += username[i]; 
            }

            string passwordAttempt = Console.ReadLine();
            int incorrectAttemptsCounter = 0;

            while ( passwordAttempt != password)
            {
                incorrectAttemptsCounter++;
                Console.WriteLine("Incorrect password. Try again.");
                passwordAttempt = Console.ReadLine();

                if ( incorrectAttemptsCounter >=3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

            }
            Console.WriteLine($"User {username} logged in.");

        }
    }
}
