// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq.Expressions;
using Microsoft.Data.Entity.Utilities;
using JetBrains.Annotations;
using Remotion.Linq;
using Remotion.Linq.Clauses;

namespace Microsoft.Data.Entity.Query
{
    public abstract class QueryAnnotation
    {
        private IQuerySource _querySource;
        private QueryModel _queryModel;

        public virtual QueryModel QueryModel
        {
            get { return _queryModel; }
            [param: NotNull]
            set
            {
                Check.NotNull(value, nameof(value));

                _queryModel = value;
            }
        }

        public virtual void TransformExpressions([NotNull] Func<Expression, Expression> transformation)
        {
        }

        public virtual IQuerySource QuerySource
        {
            get { return _querySource; }
            [param: NotNull]
            set
            {
                Check.NotNull(value, nameof(value));

                _querySource = value;
            }
        }
    }
}
