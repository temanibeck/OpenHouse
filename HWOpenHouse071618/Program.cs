using System;

namespace HWOpenHouse071618
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your new home!");
            Console.WriteLine();

            Console.WriteLine("This home has six magnificent room.");

            if (UI.UserAnswersYes("Would you like to see the kitchen room? Please enter: y/n."))
            {
                Console.WriteLine("This kitchen is simply magnificent." +
                                  "\n It has plenty of storage, which is a dream." +
                                  "\n These marble counter tops are to die for as well." +
                                  "\n The floors are freshly done.");
            }

            if (UI.UserAnswersYes("Would you like to see the dining room? Please enter: y/n."))
            {
                Console.WriteLine("This dining room is spacious and creatively designed." +
                                  "\n It has large floor to ceiling windows." +
                                  "\n Most people love the eye-catching chandelier." +
                                  "\n There is also plenty of wall space for pictures and other decor.");
            }

            if (UI.UserAnswersYes("Would you like to see the living room? Please enter: y/n."))
            {
                Console.WriteLine("This room is amazing." +
                                  "\n The fireplace is perfect for pictures." +
                                  "\n This is the largest room in the house." +
                                  "\n Most people tend to fall in love with the openness and the large windows.");
            }

            if (UI.UserAnswersYes("Would you like to see the guest bathroom? Please enter: y/n."))
            {
                Console.WriteLine("This bathroom is perhaps the best space in the house, next to the kitchen." +
                                  "\n It has brand new countertops." +
                                  "\n It also has jack and jill sinks." +
                                  "\n I personally adore the seperate shower and bathtub combo.");
            }

            if (UI.UserAnswersYes("Would you like to see the master bedroom? Please enter: y/n."))
            {
                Console.WriteLine("Like many modern homes, the master bedroom is located on the first floor." +
                                  "\n The windows in this room allow for magnificent amounts of natural light." +
                                  "\n It is the second largest room in the house." +
                                  "\n The hardwood floors are to die for.");
            }

            if (UI.UserAnswersYes("Would you like to see the master bathroom? Please enter: y/n."))
            {
                Console.WriteLine("This bathroom is perhaps the best space in the house, next to the kitchen." +
                                  "\n It has brand new countertops." +
                                  "\n It also has jack and jill sinks." +
                                  "\n I personally adore the seperate shower and bathtub combo.");
            }

            if (UI.UserAnswersYes("Would you like more information about this lovely home? Please enter: y/n."))
            {
                Console.WriteLine("The total asking price of the house is $300,500." +
                                  "\n It is only two years old." +
                                  "\n The sellers have agreed to handle all closing cost associated with the home." +
                                  "\n They have also agreed to pay neighborhood associations dues for the first six months.");
            }

            if (UI.UserAnswersYes("Are you interested in purchasing? Please enter: y/n."))
            { 
                Console.WriteLine("Awesome!");
            }
            else
            {
                Console.WriteLine("Well if you decide to change your mind, please give us a call." +
                                  "\n Thank you for your time.");
            }
        }
    }
}
