using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace ColorCodeStandard
{
    public class ColorData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            throw new NotImplementedException();
        }
    }
}
