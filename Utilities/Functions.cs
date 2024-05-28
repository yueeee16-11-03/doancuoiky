namespace dona.Utilities
{
    public class Functions
    {
        public static string TitleSlugGeneration(string type,string? title,long id)
        {
            return type + "-"+ SlugGenerator.SlugGenerator.GenerateSlug(title)+ "-"+id.ToString()+".html";

         }
         public static string getCurrentDate()
         {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

         }
    }
}