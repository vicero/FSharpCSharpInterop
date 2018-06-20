using System;
using FSharpLibrary;
using Microsoft.FSharp.Core;
using Xunit;

namespace CSharpLibrary
{
    public static class RiderBugDemonstration
    {
        /// <summary>
        /// Converts <see cref="FSharpOption{T}"/> to <see cref="Nullable"/>.
        /// </summary>
        private static T? AsNullable<T>(this FSharpOption<T> opt) where T : struct {
            return FSharpOption<T>.get_IsNone(opt) ? new T?() : opt.Value;
        }

        [Fact]
        public static void Compiles_But_Rider_Shows_Error()
        {
            var structContainer = new StructContainer(null);
            
            Assert.Null(structContainer.ValueTypeProperty.AsNullable());   
        } 
    }
}