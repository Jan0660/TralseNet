using Jan0660.TralseNet.Extensions;
using System;
using System.Collections.Generic;

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

        public override bool Equals(object obj)
            => this.random.NextBool();

        public override int GetHashCode()
        {
            int hashCode = 1292478632;
            hashCode = hashCode * -1521134295 + EqualityComparer<Random>.Default.GetHashCode(rand);
            hashCode = hashCode * -1521134295 + EqualityComparer<Random>.Default.GetHashCode(random);
            return hashCode;
        }
    }
}
