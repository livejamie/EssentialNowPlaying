﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace NativeMessagingInterface
{
    [ServiceContract(Namespace = "OBS Now Playing")]
    interface ITestContract
    {
        [OperationContract]
        string getSongName();
    }
}
