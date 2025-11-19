using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.ReshetovaAA.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    result += item;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}