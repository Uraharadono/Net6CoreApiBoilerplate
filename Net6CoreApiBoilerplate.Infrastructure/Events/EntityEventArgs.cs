using System;

namespace Net6CoreApiBoilerplate.Infrastructure.Events
{
    public class EntityEventArgs : EventArgs
    {
        public Type[] Types { get; }

        public EntityEventArgs(Type[] types)
        {
            Types = types;
        }
    }
}
