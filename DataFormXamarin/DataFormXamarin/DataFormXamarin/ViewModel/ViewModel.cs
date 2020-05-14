using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class ViewModel
    {
        private Contacts contactsInfo;
        public Contacts ContactsInfo
        {
            get { return contactsInfo; }
            set { contactsInfo = value; }
        }
        public ViewModel()
        {
            this.ContactsInfo = new Contacts();
        }
    }
}
