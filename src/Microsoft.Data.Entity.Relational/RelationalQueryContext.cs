// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING
// WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF
// TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR
// NON-INFRINGEMENT.
// See the Apache 2 License for the specific language governing
// permissions and limitations under the License.

using JetBrains.Annotations;
using Microsoft.AspNet.Logging;
using Microsoft.Data.Entity.ChangeTracking;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Query;
using Microsoft.Data.Entity.Relational.Utilities;

namespace Microsoft.Data.Entity.Relational
{
    public class RelationalQueryContext : QueryContext
    {
        private readonly RelationalConnection _connection;
        private readonly RelationalValueReaderFactory _valueReaderFactory;

        public RelationalQueryContext(
            [NotNull] IModel model,
            [NotNull] ILogger logger,
            [NotNull] StateManager stateManager,
            [NotNull] RelationalConnection connection,
            [NotNull] RelationalValueReaderFactory valueReaderFactory)
            : base(model, logger, stateManager)
        {
            Check.NotNull(connection, "connection");
            Check.NotNull(valueReaderFactory, "valueReaderFactory");

            _connection = connection;
            _valueReaderFactory = valueReaderFactory;
        }

        public virtual RelationalValueReaderFactory ValueReaderFactory
        {
            get { return _valueReaderFactory; }
        }

        public virtual RelationalConnection Connection
        {
            get { return _connection; }
        }
    }
}