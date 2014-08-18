﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;
using Microsoft.Azure.WebJobs.Host.Converters;
using Microsoft.ServiceBus.Messaging;

namespace Microsoft.Azure.WebJobs.ServiceBus.Triggers
{
    internal class StringToBrokeredMessageConverter : IConverter<string, BrokeredMessage>
    {
        public BrokeredMessage Convert(string input)
        {
            return new BrokeredMessage(new MemoryStream(StrictEncodings.Utf8.GetBytes(input), writable: false));
        }
    }
}
