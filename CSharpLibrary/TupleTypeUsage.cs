using System;
using FSharpLibrary;

using Xunit;

namespace CSharpLibrary
{
    public static class TupleTypeUsage
    {
        [Fact]
        public static void TupleTypeClass_IsSystemTuple()
        {
            var tuple = TupleType.CreateNameAndEmail("John Smith", "a@b.com");
            Assert.IsType<Tuple<string, string>>(tuple);
        }

        [Fact]
        public static void TupleTypeClass_IsValueTuple()
        {
            var tuple = TupleType.CreateStructNameAndEmail("John Smith", "a@b.com");
            Assert.IsType<ValueTuple<string, string>>(tuple);
        }
    }
}