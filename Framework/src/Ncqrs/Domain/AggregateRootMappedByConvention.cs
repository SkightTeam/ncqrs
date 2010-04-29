﻿using System.Collections.Generic;
using Ncqrs.Domain.Mapping;

namespace Ncqrs.Domain
{
    public abstract class AggregateRootMappedByConvention : MappedAggregateRoot
    {
        protected AggregateRootMappedByConvention()
            : base(new ConventionBasedDomainEventHandlerMappingStrategy())
        {
        }

        protected AggregateRootMappedByConvention(IEnumerable<DomainEvent> history) : base(new ConventionBasedDomainEventHandlerMappingStrategy(), history)
        {
        }
    }
}
