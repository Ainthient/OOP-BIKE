﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.ApplicationServices.Ports
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
