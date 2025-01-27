﻿using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            
            if(!String.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if(char.IsUpper(letter))
                    {
                        result += " ";
                    }
                    result += letter;
                }
            }

            result = result.Trim();
            return result;
        }
    }
}
