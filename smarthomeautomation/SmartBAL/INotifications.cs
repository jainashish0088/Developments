using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBAL
{
    interface INotifications
    {
        bool SendEmail<T>(T request);
        bool SendSms<T>(T request);
    }
}
