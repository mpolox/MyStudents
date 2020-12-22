using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Helpers
{
    public static class SchoolHelper
    {
        public static bool EsIgual(string s1, string s2)
        {
            if (s1 == s2) return true;
            if (s1 == null) return false;
            if (s2 == null) return false;
            var result = s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
            return result;
        }       
    }
}
