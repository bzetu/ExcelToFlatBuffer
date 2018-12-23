using System.Collections;
using System.Collections.Generic;

namespace GameMain
{
    using global::System;
    using global::FlatBuffers;
    public interface ITable
    {
        IFlatbufferObject GetElement(int i);
    }
}