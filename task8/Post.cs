namespace task8;

public class Post
{


    public string Title;
    public string Description;
    public int LikeCount;
    public List<string>post = new List<string>();
    public bool IsPublished;


    public void Publish( )
    {
          
       if(IsPublished==true)
         System.Console.WriteLine($"The post is published.");
         else 
          System.Console.WriteLine($"The post is  not published.");
         
    }

    public int Like()
    {
      LikeCount++;
      return LikeCount;

    }

    public List<string> Comment( string message)
    {

        post.Add(message);
        return post;
        
    }
    

}
