﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACM2.Library
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a list of strings to title case
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ConvertToTitleCase(this string source)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(source);
        }
    }
}
