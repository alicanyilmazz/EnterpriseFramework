using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Core.Utilities.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Generic Service Base (Such as IProductService,ICategoryService,IUserService etc.)</typeparam>
    public class WcfProxy<T> 
    {
        public static T CreateChannel()
        {
            string baseAddress = ConfigurationManager.AppSettings["ServiceAddress"];
            string address = string.Format(baseAddress,typeof(T).Name.Substring(1));
            
            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding,address);
            
            return channel.CreateChannel();
        }
    }
}
