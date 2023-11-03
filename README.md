# ValidateLiveUnitTestIssueWithJson

If I have a _json_ file on [ValidateLiveUnitTestIssueWithJson/Blueprint/sample.json](ValidateLiveUnitTestIssueWithJson/Blueprint/sample.json)
and add that on [ValidateLiveUnitTestIssueWithJson/ValidateLiveUnitTestIssueWithJson.csproj](https://github.com/lgp1985/ValidateLiveUnitTestIssueWithJson/blob/80abd3c0c6b410597729eccc34e506ba68737778/ValidateLiveUnitTestIssueWithJson/ValidateLiveUnitTestIssueWithJson.csproj#L26C1-L27C1)
to `CopyToOutputDirectory` set to `Always`.
__Live unit Test__ fails to run the test, but if I run the same test with __Test Explorer__ this one runs fine.

I can see that [lut/ValidateLiveUnitTestIssueWithJson/v2/0/b/ValidateLiveUnitTestIssueWithJson/Blueprint/sample.json](lut/ValidateLiveUnitTestIssueWithJson/v2/0/b/ValidateLiveUnitTestIssueWithJson/Blueprint/sample.json)
or [lut/ValidateLiveUnitTestIssueWithJson/v2/0/b/ValidateLiveUnitTestIssueWithJson/bin/Debug/net6.0/Blueprint/sample.json](lut/ValidateLiveUnitTestIssueWithJson/v2/0/b/ValidateLiveUnitTestIssueWithJson/bin/Debug/net6.0/Blueprint/sample.json)
or [lut/ValidateLiveUnitTestIssueWithJson/v2/0/t/ValidateLiveUnitTestIssueWithJson/bin/Debug/net6.0/Blueprint/sample.json](lut/ValidateLiveUnitTestIssueWithJson/v2/0/t/ValidateLiveUnitTestIssueWithJson/bin/Debug/net6.0/Blueprint/sample.json)
all have the same problem, that its contents are same lenght but filled with 0x00 characters.

This scenario used to work on __Live unit Test__ previously, but on _Microsoft Visual Studio Enterprise 2022 (64-bit) - Current_ Version 17.7.6, it's now failing with the problem above.
This solution was hosted on a DEV Drive on Windows 11. And such was configured with `fsutil devdrv setfiltersallowed PrjFlt` before utilizing VS.

<img width="703" alt="image" src="https://github.com/lgp1985/ValidateLiveUnitTestIssueWithJson/assets/810024/da947388-d575-4c13-bbab-e22b4027d65a">

<img width="703" alt="image" src="https://github.com/lgp1985/ValidateLiveUnitTestIssueWithJson/assets/810024/e46a1c65-35a9-42cb-9596-ca01b2ad3f80">

```
 ValidateLiveUnitTestIssueWithJson.UnitTest1.Test1
   Source: UnitTest1.cs line 6
   Duration: 16 ms

  Message: 
System.Text.Json.JsonException : '0x00' is an invalid start of a value. Path: $ | LineNumber: 0 | BytePositionInLine: 0.
---- System.Text.Json.JsonReaderException : '0x00' is an invalid start of a value. LineNumber: 0 | BytePositionInLine: 0.

  Stack Trace: 
ThrowHelper.ReThrowWithPath(ReadStack& state, JsonReaderException ex)
JsonConverter`1.ReadCore(Utf8JsonReader& reader, JsonSerializerOptions options, ReadStack& state)
JsonSerializer.ReadCore[TValue](JsonConverter jsonConverter, Utf8JsonReader& reader, JsonSerializerOptions options, ReadStack& state)
JsonSerializer.ReadCore[TValue](JsonReaderState& readerState, Boolean isFinalBlock, ReadOnlySpan`1 buffer, JsonSerializerOptions options, ReadStack& state, JsonConverter converterBase)
JsonSerializer.ContinueDeserialize[TValue](ReadBufferState& bufferState, JsonReaderState& jsonReaderState, ReadStack& readStack, JsonConverter converter, JsonSerializerOptions options)
JsonSerializer.ReadAll[TValue](Stream utf8Json, JsonTypeInfo jsonTypeInfo)
JsonSerializer.ReadAllUsingOptions[TValue](Stream utf8Json, Type returnType, JsonSerializerOptions options)
JsonSerializer.Deserialize[TValue](Stream utf8Json, JsonSerializerOptions options)
UnitTest1.Test1() line 9
----- Inner Stack Trace -----
ThrowHelper.ThrowJsonReaderException(Utf8JsonReader& json, ExceptionResource resource, Byte nextByte, ReadOnlySpan`1 bytes)
Utf8JsonReader.ConsumeValue(Byte marker)
Utf8JsonReader.ReadFirstToken(Byte first)
Utf8JsonReader.ReadSingleSegment()
Utf8JsonReader.Read()
JsonConverter`1.ReadCore(Utf8JsonReader& reader, JsonSerializerOptions options, ReadStack& state)

```
This was created to provide support info for https://developercommunity.visualstudio.com/t/Live-Unit-Test-issue-with-CopyToOutputDi/10507598?
