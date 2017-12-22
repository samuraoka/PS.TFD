using System.Collections.Generic;

namespace Animals
{
    public class Dog
    {
        public IList<string> Bark(int numberOfTreats)
        {
            var response = new List<string>();

            for (int i = 0; i < numberOfTreats; i++)
            {
                response.Add("Woof");
            }

            return response;
        }
    }
}
