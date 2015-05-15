// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.Data.Entity.FunctionalTests;

namespace Microsoft.Data.Entity.SqlServer.FunctionalTests
{
    public class IncludeAsyncSqlServerTest : IncludeAsyncTestBase<NorthwindQuerySqlServerFixture>
    {
        public IncludeAsyncSqlServerTest(NorthwindQuerySqlServerFixture fixture)
            : base(fixture)
        {
        }

        public override Task Include_references_then_include_collection_multi_level_predicate()
        {
            return base.Include_references_then_include_collection_multi_level_predicate();
        }
    }
}
