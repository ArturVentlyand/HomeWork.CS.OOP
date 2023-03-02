using System;

namespace Task3
{
    internal class Program
    {
        enum HTTPError
        {
            Bad_Request,
            Unauthorized,
            Payment_Require,
            Forbidden,
            Not_Found,
            Method_Not_Allowed,
            Not_Acceptable,
            Proxy_Authentication_Required,
            Request_Timeout,
            Conflict,
            Gone,
            Length_Required,
            Precondition_Failed,
            Payload_Too_Large,
            URI_Too_Long,
            Unsupported_Media_Type,
            Range_Not_Satisfiable,
            Expectation_Failed,
            Im_a_teapot,
            Unprocessable_Entity = 22,
            Locked,
            Failed_Dependency,
            Upgrade_Required = 26,
            Client_Closed_Request = 99
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number your error: ");
            int errorUser = int.Parse(Console.ReadLine());
            int numberingError = errorUser - 400;
            var answer = (HTTPError)numberingError;

            if (Enum.IsDefined(typeof(HTTPError), answer) == false)
            {
                Console.WriteLine("Not find your error!");
            }
            else
            {
                Console.WriteLine($"Your error {errorUser} is a : {answer}");
            }

        }
    }
}