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
    [Table("tblLane")]
    public class tblLane{
        [Key] 
        public long LaneID {get;set;}
        public string? NameLane{get;set;}
        public string? Decriptions_Lane {get;set;}
        public string? Images {get;set;}
        public string? Link {get;set;}
        public string? author {get;set;}
        public DateTime? createted_Date {get;set;}
    
        public bool? IsActive {get;set;}
         public long? GameID {get;set;}
     
        public  tblGames? Games{ get; set; }
        
      
        

    }
    }
