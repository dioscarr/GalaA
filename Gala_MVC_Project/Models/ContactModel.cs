﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;
namespace Gala_MVC_Project.Models
{
    public class ContactModel
    {
        public Contact contact { get; set; }
        public ContactModel() {
            contact = ManageContact.GetAllContact().FirstOrDefault();
        }

    }
}