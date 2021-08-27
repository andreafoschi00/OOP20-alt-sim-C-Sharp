using Severi.user.builder;
using Severi.user.records;
using Severi.user.validation;
using Xunit;

namespace Severi.test
{
    public class NameQualityTest : NameQuality
    {
        private readonly NameChecker _nameChecker = new ();
        private readonly FileOperationsTest _fileOperations = new ();
        
        [Fact]
        public void TestNameQuality()
        {
            _fileOperations.CopyRecordsFile();
            _fileOperations.ClearRecordsFile();
            _fileOperations.AddUser(UserBuilder.BuildUser("ciao", 400));
            
            Assert.Equal(NameResult.Correct, _nameChecker.CheckName("luca"));
            Assert.Equal(NameResult.Wrong, _nameChecker.CheckName("c#"));
            Assert.Equal(NameResult.Empty, _nameChecker.CheckName("      "));
            Assert.Equal(NameResult.TooLong, _nameChecker.CheckName("lucalucalucaluca"));
            Assert.Equal(NameResult.Taken, _nameChecker.CheckName("ciao"));
            
            _fileOperations.RemoveFileCopy();
        }
    }
}