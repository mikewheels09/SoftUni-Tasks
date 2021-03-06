﻿using System.Collections.Generic;

public class BookComparator : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        int result = y.Year.CompareTo(x.Year);
        if (result == 0)
        {
            result = x.Title.CompareTo(y.Title);
        }

        return result;
    }
}
