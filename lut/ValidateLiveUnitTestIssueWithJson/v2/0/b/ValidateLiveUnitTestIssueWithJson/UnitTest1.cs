namespace ValidateLiveUnitTestIssueWithJson
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using var fileStream = File.OpenRead("./Blueprint/sample.json");
            var obj = System.Text.Json.JsonSerializer.Deserialize<MyObj>(fileStream, new System.Text.Json.JsonSerializerOptions { PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase });
            Assert.Equal("value", obj!.Data);
        }
    }
}