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
        public static int ToNumber(this string str)
        {
            str.Trim();
            return Convert.ToInt32(str);
        }
    }
}
