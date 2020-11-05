using System;

namespace ClassLibTest
{
    public class Class1
    {
        public static String  DisplayGreeting(String name)
        {
            String time = DateTime.Now.ToString("h:mm:ss tt");

            return $"{time} Hello, {name}!";
        }
    }
}
