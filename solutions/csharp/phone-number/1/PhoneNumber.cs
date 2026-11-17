using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        if (string.IsNullOrEmpty(phoneNumber))
        {
            throw new ArgumentException("Номер телефону не може бути порожнім.");
        }

        string digits = Regex.Replace(phoneNumber, @"\D", "");


        if (Regex.IsMatch(phoneNumber, @"[a-zA-Z@:!]"))
        {
            throw new ArgumentException("Номер телефону містить недопустимі символи (літери).");
        }

        if (digits.Length == 11)
        {
            if (digits[0] == '1')
            {
                digits = digits.Substring(1);
            }
            else
            {
                throw new ArgumentException("Недійсний код країни (має бути 1 для NANP).");
            }
        }

        if (digits.Length != 10)
        {
            throw new ArgumentException("Номер телефону має мати довжину рівно 10 цифр (або 11 з кодом 1).");
        }

        if (digits[0] < '2' || digits[3] < '2')
        {
            throw new ArgumentException("Код зони або код станції не може починатися з 0 або 1.");
        }

        return digits;
    }
}