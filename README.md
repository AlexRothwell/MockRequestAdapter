# MockRequestAdapter for IRequestAdapter
A mocking library for C# Kiota clients using a fluent library. This library is heavily inspired by the [mockhttp library](https://github.com/richardszalay/mockhttp) by richardszalay

## Unit testing Kiota client consumers without MockRequestAdapter
The [simple example provided by Microsoft](https://learn.microsoft.com/en-us/openapi/kiota/testing#kiota-client-unit-testing) is shown below with some sections removed for brevity
```C#
public class PostsRequestsTests
{
    private static readonly List<Post> postsMock =
        [ new Post { Id = 1, Title = "Post Title #1", Body = "Posts Body #1" } ];

    // Basic test for GET /posts
    [Fact]
    public async Task All_Posts()
    {
        // Arrange
        var adapter = Substitute.For<IRequestAdapter>();
        var postsClient = new PostsClient(adapter);

        // Return the mocked list of posts
        adapter.SendCollectionAsync(
            Arg.Any<RequestInformation>(),
            Arg.Any<ParsableFactory<Post>>(),
            Arg.Any<Dictionary<string, ParsableFactory<IParsable>>>(),
            Arg.Any<CancellationToken>())
            .ReturnsForAnyArgs(postsMock);

        // Act
        var posts = await postsClient.Posts.GetAsync();

        // Assert
        Assert.NotNull(posts);
        Assert.Equal(postsMock.Count, posts.Count);
    }
}
```

As you can see, the simplest mock for `IRequestAdapter` requires a lot of configuration, most of which is of low importance in a unit test.
If you have a test which would call a Kiota client multiple times with different methods, each of these substitution statements would need to be more complex.
With more complex tests, the intention of each test gets harder to understand as you have to understand the meaning of any boilerplate code.

## Using MockRequestAdapter
TODO as library is implemented
