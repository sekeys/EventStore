using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index.IndexV3
{
    [TestFixture]
    public class destroying_ptable: IndexV1.destroying_ptable
    {
        public destroying_ptable()
        {
            _ptableVersion = PTableVersions.IndexV3;
        }
    }
}