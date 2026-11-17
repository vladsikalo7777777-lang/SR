using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly SortedDictionary<int, SortedSet<string>> _school = new SortedDictionary<int, SortedSet<string>>();
    private readonly HashSet<string> _allStudents = new HashSet<string>();

    public bool Add(string student, int grade)
    {
        if (_allStudents.Contains(student))
        {
            return false;
        }

        if (!_school.ContainsKey(grade))
        {
            _school[grade] = new SortedSet<string>();
        }

        _school[grade].Add(student);
        _allStudents.Add(student);
        return true;
    }

    public IEnumerable<string> Roster()
    {
        var rosterList = new List<string>();
        foreach (var gradeGroup in _school)
        {
            foreach (var student in gradeGroup.Value)
            {
                rosterList.Add(student);
            }
        }
        return rosterList;
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (_school.ContainsKey(grade))
        {
            return _school[grade];
        }
        return Enumerable.Empty<string>();
    }
}