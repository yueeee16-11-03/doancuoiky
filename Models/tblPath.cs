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
    [Table("tblPath")]
    public class tblPath{
        [Key] 
        public long PathID {get;set;}
        public string? Decriptions_Path {get;set;}
        public string? NamePath {get;set;}
        public string? Images {get;set;}
        public string? Link {get;set;}
        public string? author {get;set;}
        public DateTime? createted_Date {get;set;}
    
        public bool? IsActive {get;set;}
        public string? NameChampions {get;set;}
         public long? ChampionsID {get;set;}
     
        public  tblChampions? Champions{ get; set; }
        
      
        

    }
    }
