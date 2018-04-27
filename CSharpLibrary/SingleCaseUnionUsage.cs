using FSharpLibrary;
using Xunit;

namespace CSharpLibrary
{
    public static class FSharpUsages
    {
        [Fact]
        public static void ClassSingleCaseUnion_HasItem_Equality()
        {
            var a = EmailAddress.NewEmailAddress("a@b.com");
            var b = EmailAddress.NewEmailAddress("a@b.com");

            Assert.Equal("a@b.com", a.Item);
            Assert.Equal("a@b.com", b.Item);
            
            Assert.True(a.Equals(b));
        }
        
        [Fact]
        public static void StructSingleCaseUnion_HasItem_Equality()
        {
            var a = StructEmailAddress.NewStructEmailAddress("a@b.com");
            var b = StructEmailAddress.NewStructEmailAddress("a@b.com");

            Assert.Equal("a@b.com", a.Item);
            Assert.Equal("a@b.com", b.Item);
            
            Assert.True(a.Equals(b));
        }

        [Fact]
        public static void ClassAggregateWithPrivates()
        {
            var aggregate = FSharpLibrary.ClassAggregateWithPrivates.Create("a@b.com");
            /*
                These statements will not compile:
                var emailAddress = PrivateEmailAddress.NewPrivateEmailAddress("a@b.com");
                var emailAddress = PrivateStructEmailAddress.NewPrivateStructEmailAddress("a@b.com");

                Assert.Equal("a@b.com", aggregate.PrivateEmailAddress.Item);
                Assert.Equal("a@b.com", aggregate.PrivateStructEmailAddress.Item);
            */
            
            Assert.True(aggregate.PrivateEmailAddress.Value.Equals("a@b.com"));
            Assert.True(aggregate.PrivateStructEmailAddress.Value.Equals("a@b.com"));

            Assert.NotEqual<object>(aggregate.PrivateEmailAddress, aggregate.PrivateStructEmailAddress);
        }
    }
}