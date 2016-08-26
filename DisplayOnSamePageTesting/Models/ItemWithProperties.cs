using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayOnSamePageTesting.Models
{
    public class ItemWithProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EditableProperty { get; set; }
        public string ConstantProperty { get; set; }
    }
}