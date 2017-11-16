﻿// ==========================================================================
//  AssetNotFoundException.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using System.Runtime.Serialization;

namespace Squidex.Infrastructure.Assets
{
    [Serializable]
    public class AssetNotFoundException : Exception
    {
        public AssetNotFoundException()
        {
        }

        public AssetNotFoundException(string message)
            : base(message)
        {
        }

        public AssetNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected AssetNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
