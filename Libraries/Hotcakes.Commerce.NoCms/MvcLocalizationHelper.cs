﻿#region License

// Distributed under the MIT License
// ============================================================
// Copyright (c) 2016 Hotcakes Commerce, LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, 
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or 
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.

#endregion

using System;
using System.Collections.Generic;
using Hotcakes.Commerce.Globalization;

namespace Hotcakes.Commerce.NoCms
{
    public class MvcLocalizationHelper : ILocalizationHelper
    {
        public string GetString(string key)
        {
            throw new NotImplementedException();
        }

        public string GetString(string key, string culture)
        {
            throw new NotImplementedException();
        }

        public string GetFormattedString(string key, params object[] args)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetResourceDictionary()
        {
            throw new NotImplementedException();
        }

        public string GetJsEncodedString(string key)
        {
            throw new NotImplementedException();
        }

        public string GetJsEncodedString(string key, string[] characters)
        {
            throw new NotImplementedException();
        }
    }
}