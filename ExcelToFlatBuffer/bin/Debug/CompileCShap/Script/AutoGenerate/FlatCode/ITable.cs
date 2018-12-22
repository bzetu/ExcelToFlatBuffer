using System.Collections;
using System.Collections.Generic;

namespace GameTable
{
    using global::System;
    using global::FlatBuffers;
    public interface ITable
    {
        IFlatbufferObject GetElement(int i);
    }
}