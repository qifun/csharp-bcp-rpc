﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.dongxiguo.continuation.utils;
using haxe.lang;

namespace BcpRpc
{
    interface IWrappedHaxeIterator<Element>
    {
        bool HasNext();
        Element Next();
    }
}
