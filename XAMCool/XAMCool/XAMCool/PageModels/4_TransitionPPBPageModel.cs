using System;
using System.Collections.Generic;
using System.Text;
using XAMCool.Models;

namespace XAMCool.PageModels
{
    public class _4_TransitionPPBPageModel
    {
        public Contact Contact { get; set; }
        public _4_TransitionPPBPageModel(Contact _contact)
        {
            Contact = _contact;
        }
    }
}
