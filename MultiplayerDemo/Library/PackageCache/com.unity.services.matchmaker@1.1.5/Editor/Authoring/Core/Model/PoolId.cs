using System;

namespace Unity.Services.Matchmaker.Authoring.Core.Model
{
    readonly struct PoolId
    {
        internal PoolId(Guid id)
        {
            Id = id;
        }

        internal Guid Id { get; }

        internal bool IsEmpty() => Id == Guid.Empty;

        public override string ToString() => Id.ToString();
    }
}
