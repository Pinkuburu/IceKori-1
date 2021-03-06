using System.Collections.Generic;
using System.Linq;

namespace Assets.Plugins.IceKori.Syntax.BaseType
{
    [System.Serializable]
    public class IceKoriArray : IceKoriBaseType
    {
        public List<IceKoriBaseType> Value;
        public IceKoriArray()
        {
            ID = 6;
            Reducible = false;
        }

        public IceKoriArray(List<IceKoriBaseType> value)
        {
            ID = 6;
            Reducible = false;
            Value = value;
        }

        public override string ToString()
        {
            return $"[{Value.Select(value => value.ToString()).Aggregate((last, next) => last  + ", " + next)}]";
        }

        public override object Unbox()
        {
            return Value.Select(value => value.Unbox());
        }
    }
}