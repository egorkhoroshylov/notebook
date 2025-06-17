using System;

namespace Notebook
{
    public class NotebookEntry
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime LastEdited { get; set; }

        public override string ToString()
        {
            return $"{FullName}, {PhoneNumber}, {Address}, {Birthday:dd.MM.yyyy}";
        }
    }
}
