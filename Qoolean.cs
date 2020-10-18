using Jan0660.TralseNet.Extensions;
using System;

namespace Jan0660.TralseNet
{
    public struct Qoolean
    {
        private Random rand;
        private Random random
        {
            get
            {
                if (rand == null)
                    rand = new Random();
                return rand;
            }
        }
        #region != and == operators
        public static bool operator !=(bool a, Qoolean b)
            => a != b.random.NextBool();
        public static bool operator ==(bool a, Qoolean b)
            => a == b.random.NextBool();
        public static bool operator !=(Qoolean a, bool b)
            => a.random.NextBool() != b;
        public static bool operator ==(Qoolean a, bool b)
            => a.random.NextBool() == b;
        public static bool operator !=(Qoolean a, Qoolean b)
            => a.random.NextBool() != b.random.NextBool();
        public static bool operator ==(Qoolean a, Qoolean b)
            => a.random.NextBool() == b.random.NextBool();
        #endregion
        #region & and | operators
        public static bool operator &(bool a, Qoolean b)
            => a & b.random.NextBool();
        public static bool operator |(bool a, Qoolean b)
            => a | b.random.NextBool();
        public static bool operator &(Qoolean a, bool b)
            => a.random.NextBool() & b;
        public static bool operator |(Qoolean a, bool b)
            => a.random.NextBool() | b;
        public static bool operator &(Qoolean a, Qoolean b)
            => a.random.NextBool() & b.random.NextBool();
        public static bool operator |(Qoolean a, Qoolean b)
            => a.random.NextBool() | b.random.NextBool();
        #endregion
        public static bool operator true(Qoolean qoolean)
            => qoolean.random.NextBool();
        public static bool operator false(Qoolean qoolean)
            => qoolean.random.NextBool();
    }
}
