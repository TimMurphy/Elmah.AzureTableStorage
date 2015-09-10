﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Elmah.Repository.Tests.Helpers
{
    public class GivenData
    {
        public IDictionary Dictionary { get; set; }
        public string Key { get; set; }
        public object Value { get; set; }
        public TypeCode TypeCode { get; set; }
        public NameValueCollection NameValueCollection { get; set; }
    }
}