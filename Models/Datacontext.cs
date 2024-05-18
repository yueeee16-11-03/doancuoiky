using System.Net.Mime;
using dona.Model;
using Microsoft.EntityFrameworkCore;

namespace dona.Models
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {
        }

        public DbSet<tblMenu> Menus { get; set; }
         public DbSet<viewPostMenu> ViewPostMenus {get;set;}
protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
    modelBuilder.Entity<tblMenu>().HasData(
        new tblMenu { MenuID  = 1, MenuName="Home",IsActive=true ,CotrollerName=null,ActionName=null,Levers=1,ParentID=0,MenuOrder=1,Position=1},
        new tblMenu { MenuID  = 2, MenuName="Game",IsActive=true ,CotrollerName=null,ActionName=null,Levers=1,ParentID=0,MenuOrder=2,Position=1},
        new tblMenu { MenuID  = 3, MenuName="Champions",IsActive=true ,CotrollerName=null,ActionName=null,Levers=1,ParentID=0,MenuOrder=3,Position=1},
        new tblMenu { MenuID  = 4, MenuName="New",IsActive=true ,CotrollerName=null,ActionName=null,Levers=1,ParentID=0,MenuOrder=4,Position=1},
        new tblMenu { MenuID  = 5, MenuName="About as",IsActive=true ,CotrollerName=null,ActionName=null,Levers=1,ParentID=0,MenuOrder=6,Position=1},
        new tblMenu { MenuID  = 6, MenuName="Riot Games",IsActive=true ,CotrollerName=null,ActionName=null,Levers=2,ParentID=4,MenuOrder=1,Position=1},
        new tblMenu { MenuID  = 7, MenuName="Game UpDate",IsActive=true ,CotrollerName=null,ActionName=null,Levers=2,ParentID=4,MenuOrder=2,Position=1},
        new tblMenu { MenuID  = 8, MenuName="EsPorts",IsActive=true ,CotrollerName=null,ActionName=null,Levers=2,ParentID=4,MenuOrder=3,Position=1},
        new tblMenu { MenuID  = 9, MenuName="Lore",IsActive=true ,CotrollerName=null,ActionName=null,Levers=2,ParentID=4,MenuOrder=4,Position=1},
        new tblMenu { MenuID  = 10, MenuName="Community",IsActive=true ,CotrollerName=null,ActionName=null,Levers=2,ParentID=4,MenuOrder=5,Position=1},
        new tblMenu { MenuID  = 11, MenuName="Merch",IsActive=true ,CotrollerName=null,ActionName=null,Levers=2,ParentID=4,MenuOrder=6,Position=1}
        
    );
     modelBuilder.Entity<viewPostMenu>().HasData(
      new viewPostMenu { PostID= 1, Title="TEAMFIGHT TACTICS PATCH 14.10 NOTES",Abstract="TFT UPDATE VERISON " ,Contents="With 14.10 we asked ourselves, “What's not working?” and after reworking Lissandra, nerfing a few overperformers, and making Prismatic Orbs feel more like rare high rolls, we set out to make the not working stuff, well… work better.",Images="Image/anh1.jpg", link=null,author="oai",createted_Date=DateTime.Parse("2024-05-10 08:00:00"), IsActive=true,PostOrder=1,MenuID=7,MenuName="Game UpDate"},
      new viewPostMenu { PostID= 2, Title="PATCH 14.10 NOTES",Abstract="We have quite a bit of stuff dropping in patch 14.10 " ,Contents="We have quite a bit of stuff dropping in patch 14.10: Split 1 end and Split 2 start details",Images="Image/anh2.jpg", link=null,author="oai",createted_Date=DateTime.Parse("2024-05-10 10:00:00"),IsActive=true,PostOrder=2,MenuID=7,MenuName="Game UpDate"},
      new viewPostMenu { PostID= 3, Title="STAYING THE COURSE |MSI 2024",Abstract=null ,Contents=null,Images="Image/anh3.jpg", link="https://www.youtube.com/watch?v=oJl_MKDUHqU",author="oai",createted_Date=DateTime.Parse("2024-05-10 11:00:00"),IsActive=true,PostOrder=3,MenuID=8,MenuName="EsPorts"},
      new viewPostMenu { PostID= 4, Title="TOP 5 PLAYS|BRACKET STAGE WK1",Abstract=null ,Contents=null,Images="Image/anh4.jpg", link="https://www.youtube.com/watch?v=8rPhx_W6YDE",author="oai",createted_Date=DateTime.Parse("2024-05-10 13:00:00"),IsActive=true,PostOrder=4,MenuID=8,MenuName="EsPorts"},
      new viewPostMenu { PostID= 5, Title="PREVIOUSLY ON STAR GUARDIAN",Abstract="In the beginning, the First Star gave birth to the universe and all life" ,Contents=" To protect its creations and ensure the cycle of life would continue for eternity, the First Star entrusted individuals iron-willed and pure of heart with fragments of its essence—starlight—as protectors of the universe throughout the ages.",Images="Image/anh5.jpg", link=null,author="oai",IsActive=true,createted_Date=DateTime.Parse("2024-05-10 13:00:00"),PostOrder=5,MenuID=9,MenuName="Lore"},
      new viewPostMenu { PostID= 6, Title="A LEAGUE OF LEGENDS NOVEL",Abstract="Camavor is a brutal land with a bloody legacy" ,Contents=" Kalista seeks to change that. When her young and narcissistic uncle, Viego, becomes king she vows to temper his destructive instincts as his loyal confidant, advisor, and military general.",Images="Image/anh6.jpg", link=null,author="oai",createted_Date=DateTime.Parse("2024-05-10 14:00:00"),IsActive=true,PostOrder=6,MenuID=9,MenuName="Lore"},
      new viewPostMenu { PostID= 7, Title="CELEBRATE PRIDE 2024: LEAGUE AND TFT",Abstract="There’s a lot going on for Pride this year across all our games" ,Contents="Pride content hits the Rift with Patch 14.11 and is available until Patch 14.12’s conclusion. The event brings a new mission and Pride Emote, “United,” featuring Twisted Fate and Neeko, as well as returning Pride emotes for 1 Blue Essence each—essence-ially free!",Images="Image/anh7.jpg", link=null,author="oai",IsActive=true,createted_Date=DateTime.Parse("2024-05-10 15:00:00"),PostOrder=7,MenuID=10,MenuName="Community"},
      new viewPostMenu { PostID=8, Title="STILL HERE REFERENCE MATERIALS",Abstract="Calling all cosplayers, fan artists, and creators of all kinds" ,Contents="Calling all cosplayers, fan artists, and creators of all kinds! We've got a gallery of reference images for the champions featured in our latest cinematic",Images="Image/anh8.jpg", link=null,author="oai",IsActive=true,createted_Date=DateTime.Parse("2024-05-10 16:00:00"),PostOrder=8,MenuID=10,MenuName="Community"}, 
      new viewPostMenu { PostID= 9, Title="THE MAGESEEKER : A LEAGUE OF  LEGENDS STORY GAMEPLAY",Abstract=null ,Contents=null,Images="Image/anh9.jpg", link="https://www.youtube.com/watch?v=-KHMMMHvDdM",author="oai",createted_Date=DateTime.Parse("2024-05-10 17:10:00"),IsActive=true,PostOrder=9,MenuID=6,MenuName="Riot Games"},
      new viewPostMenu { PostID= 10, Title="RIOT FORGE GAMES 2023|THE YEAR AHEAD",Abstract=null ,Contents=null,Images="Image/anh10.jpg", link="https://www.youtube.com/watch?v=n66QyujLXyg",author="oai",IsActive=true,createted_Date=DateTime.Parse("2024-05-10 17:11:00"),PostOrder=10,MenuID=6,MenuName="Riot Games"}
      
    );
    }

   


}
}

