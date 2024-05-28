using System.Net.Mime;
using System ;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using dona.Models;
namespace dona.Model
{
    [Table("tblGames")]
    public class tblGames{
        [Key] 
        public long GameID {get;set;}
    
        public string? Title {get;set;} 
        public string? Decriptions_title {get;set;}
        public string? Images {get;set;}
        public string? Link {get;set;}
        public string? author {get;set;}
        public DateTime? createted_Date {get;set;}
        public string? Lane {get;set;}
        public string? decriptions_lane{get;set;}
        public bool? IsActive {get;set;}
         public long? ChampionsID {get;set;}
        public string? NameChampions { get; set; }
        public  tblChampions? Champions{ get; set; }
        
      
        

    }
    }
