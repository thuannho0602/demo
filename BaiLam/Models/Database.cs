using BaiLam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace BaiLam.BAL
{
    public class Database
    {
        DatatProvide _provider = new DatatProvide();
        public Database()
        {
            _provider.Connect();
        }
        public void Disconnect()
        {
            _provider.Disconnect();
        }
      
    }
}