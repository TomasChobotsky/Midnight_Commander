using System;
using System.IO;

namespace Commander.Data
{
    public class TableContent
    {
        public bool IsSelected { get; set; }
        public string Value { get; set; }

        public TableContent(bool isSelected, string value)
        {
            IsSelected = isSelected;
            Value = value;
        }
    }
}