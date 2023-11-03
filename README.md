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

<img width="703" alt="image" src="https://github.com/lgp1985/ValidateLiveUnitTestIssueWithJson/assets/810024/da947388-d575-4c13-bbab-e22b4027d65a">

<img width="703" alt="image" src="https://github.com/lgp1985/ValidateLiveUnitTestIssueWithJson/assets/810024/e46a1c65-35a9-42cb-9596-ca01b2ad3f80">
