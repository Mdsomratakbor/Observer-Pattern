using SocialMediaPost.Observers;
using SocialMediaPost.Subjects;

Post post = new Post();

User alice = new User("Alice");
User bob = new User("Bob");
User carol = new User("Carol");

post.AddFollower(alice);
post.AddFollower(bob);
post.AddFollower(carol);

post.UpdateContent("Check out my vacation photos!");

Task.Delay(1000).Wait();
for (int i=0; i<10; i++)
{
    Console.WriteLine("waiting for new post !!");
}
Task.Delay(1000).Wait();

// Bob decides to unfollow the post
post.RemoveFollower(bob);

Console.WriteLine("Bob decides to unfollow the post");



post.UpdateContent("New recipe: Chocolate cake!");