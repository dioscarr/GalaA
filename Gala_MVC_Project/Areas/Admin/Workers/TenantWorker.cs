﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using DAL.Models;

//namespace SecurityMonitor.Workes
//{
//    public class TenantWorker
//    {
//        GalaDBEntities db = new GalaDBEntities();
//        public List<Tenant> TenantsOnApartment(int AptID)
//        {
//            try
//            {
//                var Tenants = db.Tenant.Where(c => c.aptID == AptID).ToList();
//                return Tenants;
//            }
//            catch (Exception)
//            {
//                throw;
//            }        
//        }
//    }
//}