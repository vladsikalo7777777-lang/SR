using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly HashSet<string> _usedNames = new HashSet<string>();
    private static readonly Random _random = new Random();
    
    private string _name;

    public string Name
    {
        get
        {
            if (_name == null)
            {
                _name = GenerateUniqueName();
            }
            return _name;
        }
    }

    public void Reset()
    {
        if (_name != null)
        {
            _usedNames.Remove(_name);
            _name = null;
        }
    }

    private string GenerateUniqueName()
    {
        string newName;
        do
        {
            char firstLetter = (char)('A' + _random.Next(26));
            char secondLetter = (char)('A' + _random.Next(26));
            int digits = _random.Next(1000);

            newName = $"{firstLetter}{secondLetter}{digits:D3}";
        } 
        while (!_usedNames.Add(newName));

        return newName;
    }
}