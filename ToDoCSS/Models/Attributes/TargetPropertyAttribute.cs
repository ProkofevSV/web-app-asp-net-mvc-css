﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoCSS.Models.Attributes
{
    public class TargetPropertyAttribute : Attribute
    {
        public TargetPropertyAttribute(string targetProperty)
        {
            TargetProperty = targetProperty;
        }

        public string TargetProperty { get; set; }
    }
}