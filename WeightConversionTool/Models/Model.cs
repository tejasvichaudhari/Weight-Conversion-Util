using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WebApplication3
{
    public class Model : IModel
    {
        public List<String> setInfo(string FromNo, string Conversion, string Value)
        {
            List<String> l = new List<string>();

            double d = Convert.ToDouble(FromNo) * Convert.ToDouble(Value);
            l.Add(Convert.ToString(d));
            return l;
        }

    }
}