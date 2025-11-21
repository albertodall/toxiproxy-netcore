using Newtonsoft.Json;
using Toxiproxy.Net.Toxics;
using Xunit;

namespace ToxiproxyNetCore.Tests
{
    public class CustomeSerializersUnitTests
    {
        [Theory]
        [InlineData(ToxicDirection.UpStream, "\"upstream\"")]
        [InlineData(ToxicDirection.DownStream, "\"downstream\"")]
        public void ToxicDirection_Serializes_To_Lowercase(ToxicDirection direction, string expectedJson)
        {
            // Act
            var json = JsonConvert.SerializeObject(direction);

            // Assert
            Assert.Equal(expectedJson, json);
        }
    }
}
