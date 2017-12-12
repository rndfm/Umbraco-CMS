﻿using Umbraco.Core.Events;
using Umbraco.Core.Logging;
using Umbraco.Core.Scoping;

namespace Umbraco.Core.Services
{
    // fixme that one does not add anything = kill
    public abstract class ScopeRepositoryService : RepositoryService
    {
        protected ScopeRepositoryService(IScopeProvider provider, ILogger logger, IEventMessagesFactory eventMessagesFactory)
            : base(provider, logger, eventMessagesFactory)
        { }
    }
}
