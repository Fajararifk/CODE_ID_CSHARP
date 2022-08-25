namespace day01
{
    class ControlStatement
    {
        public static void ValidatePassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password required");
            }
            else if (password.Length < 8)
            {
                Console.WriteLine("Your password is too short, at least 8 character");
            }
            else
            {
                Console.WriteLine("Your password is strong");
            }
        }
        public static void EvenNumber()
        {
            Console.Write("Enter a number : ");
            var input = Console.ReadLine();
            //int number = Convert.ToInt32(input);
            int.TryParse(input, out int number); //out maka hasilnya akan dilemparkan ke number

            if (number % 2 == 0)
            {
                Console.WriteLine("Event Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
        public static void SwitchCase()
        {
            Console.WriteLine("Enter a Number 1-10: ");
            var input = Console.ReadLine();
            int.TryParse(input, out int number);
            switch(number)
            {
                case 1:
                    Console.WriteLine("Smallest Number");
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Prime Number");
                    break;
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Even Number");
                    break;
                case 9:
                    Console.WriteLine("Odd Number");
                    break;
                case 10:
                    Console.WriteLine("Highest Number");
                    break;
                default:
                    Console.WriteLine("Not in the range");
                    break;
            }
        }
    }
}