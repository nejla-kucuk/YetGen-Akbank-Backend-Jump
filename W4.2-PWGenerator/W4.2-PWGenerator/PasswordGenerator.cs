﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4._2_PWGenerator
{
    public class PasswordGenerator
    {
        private readonly Random _random;

        private const string Numbers = "0123456789";
        private const string SpecialChars = "!@#$%^&*()";
        private const string LowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Full = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()";

        public PasswordGenerator()
        {
            _random = new Random();
        }

        public string Generate(int passwordLength, bool includeNumbers, bool includeLowerCase, bool includeUpperCase, bool includeSpecialChars)
        {
            var charsBuilder = new StringBuilder();

            if (includeNumbers)
                charsBuilder.Append(Numbers);

            if (includeLowerCase)
                charsBuilder.Append(LowerCaseChars);

            if (includeUpperCase)
                charsBuilder.Append(UpperCaseChars);

            if (includeSpecialChars)
                charsBuilder.Append(SpecialChars);

            var acceptedChars = charsBuilder.ToString();

            var passwordBuilder = new StringBuilder();


            for (int i = 0; i < passwordLength; i++)
            {
                var randomIndex = _random.Next(0, acceptedChars.Length);

                passwordBuilder.Append(acceptedChars[randomIndex]);
            }

            return passwordBuilder.ToString();
        }

    }
}
