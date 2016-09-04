// Copyright (c) Microsoft. All rights reserved.

namespace System
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Indicates that a class can be serialized. This class cannot be inherited. 
    /// This is just a dummy implementation so that we can mark types as remote - able in the Portable Adapter.
    /// This would be Type Forwarded to the actual implementation in the desktop platform service only.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate,
        Inherited = false)]
    [ComVisible(true)]
    public sealed class SerializableAttribute : Attribute
    {
    }
}