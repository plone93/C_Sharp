using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStudy.Extensions
{
    //string에 메서드를 추가
    public static class StringExtensions
    {
        public static bool IsNumeric(this string str)
        {
            long result;
            return long.TryParse(str, out result);//long으로 변환 가능한가
        }

        public static bool IsDateTime(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            } 
            else
            {
                DateTime result;
                return DateTime.TryParse(str, out result);
            }
        }
    }
}
