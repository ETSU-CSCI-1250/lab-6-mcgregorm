//This gave me way more trouble than I expected. I got the first 2 methods down perfect, struggled with the third one, and couldn't get a method that would actually run for the fourth.

//This just makes a small menu displaying the methods available, then takes the user's input on the method they chose.
Console.WriteLine("What method would you like to call?\nEnter 1 to call ShowCharacter.\nEnter 2 to call CalculateRetail.\nEnter 3 to call Celcius.\nEnter 4 to call IsPrime.\nInput the number of the method you would like to call:");
int userInput = Int32.Parse(Console.ReadLine());

//I chose to use a switch statement here, as I thought that would best account for the user's input and keep my code organized.
switch (userInput) 
{
    //Method 1 takes input from the user on a string and tells them the character at a HUMAN index position they chose.
    case 1:
        {
            Console.WriteLine("Input your string:");
            string message = Console.ReadLine();

            Console.WriteLine("Input your position:");
            int position = Int32.Parse(Console.ReadLine());

            ShowCharacter(message, position);

            static void ShowCharacter(string message, int position)
            {
                position = position - 1;
                Console.WriteLine(message[position]);
            }
        }
        break;

    //Method 2 takes input from the user on their item's cost and markup value, then calculates it. I used Decimal here as I was dealing with numbers relating to money.
    case 2:
        {
            Console.WriteLine("Input your item's wholesale cost to 2 decimal places:");
            decimal cost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter your item's markup percentage as a positive integer:");
            decimal markup = decimal.Parse(Console.ReadLine());

            CalculateRetail(cost, markup);

            static void CalculateRetail(decimal cost, decimal markup)
            {
                markup = (markup / 100) + 1;
                cost = cost * markup;
                Console.WriteLine($"Your final cost is ${cost}");
            }

        }
        break;

    //Method 3 takes input from the user on the temperature in farenheit, then converts it to celcius using a simple calculation.
    //Izzy and I worked together on this one, as I was struggling pretty badly. Though, I used a void returning value instead of a double as they did. It seemed simpler.
    case 3:
        {
            Console.WriteLine("Input your temperature in farenheit.");
            double tempF = double.Parse(Console.ReadLine());

            Celcius(tempF);

            static void Celcius(double tempF)
            { 
                    double tempC = (5.00 / 9.00);
                    tempC = Math.Round((tempC * (tempF - 32)), 1);
                    Console.WriteLine($"Your temperature in celcius is {tempC}");
                
            }
        }
        break;

    /* Method 4 gave me a bad time. I worked on it for about an hour and couldn't get anything without the red squiggles of death. I assumed we had to use a bool returning value and just
       couldn't get it to work quite right. I know we went over this in class, but I couldn't get even the simplest method demonstrated to work.                                        */

    case 4:
        {

        }
        break;
}