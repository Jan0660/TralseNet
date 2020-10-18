/*using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace Jan0660.TralseNet
{
    public enum TralseEnum { False, True, Tralse }
    public struct Boolean
    {
        public TralseEnum value;
        private bool Bool
        {
            get
            {
                switch (value)
                {
                    case TralseEnum.False:
                        return false;
                    case TralseEnum.True:
                        return true;
                    default:
                        return true;
                }
            }
        }
        public Boolean(bool b)
        {
            value = BoolToEnum(b);
        }
        public static TralseEnum BoolToEnum(bool b)
        {
            switch (b)
            {
                case true:
                    return TralseEnum.True;
                case false:
                    return TralseEnum.False;
                default:
                    return TralseEnum.Tralse;
            }
        }
        public static bool operator |(Boolean a, Boolean b)
        {
            if (a =)
        }
        public static bool EnumToBool(TralseEnum e)
        {
            switch (e)
            {
                case TralseEnum.False
            }
        }
    }
}*/
