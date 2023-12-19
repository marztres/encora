using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encora
{
    public static class StringManipulator
    {
        public static string SortingOperations(string value)
        {
            return new string(value.GroupBy(o => o)
                                   .OrderByDescending(group => group.Count())
                                   .ThenBy(group => group.Key)
                                   .SelectMany(group => group)
                                   .ToArray());
        }
    }
}
