using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    internal class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shorttitle)
        {
            Title = title;
            ShortTitle = shorttitle;
        }
    }
}