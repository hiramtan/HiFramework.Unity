﻿//****************************************************************************
// Description:
// Author: hiramtan@live.com
//****************************************************************************
using System;
using System.Collections.Generic;

namespace HiFramework
{
    interface IBindInfo
    {
        Type Type { get; }
        object ToInstance { get; }
        string AsName { get; }
    }
}
