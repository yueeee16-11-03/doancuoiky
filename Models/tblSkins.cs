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
    [Table("tblSkins")]
    public class tblSkins{
        [Key] 
        public long SkinID {get;set;}
        public string? Nameskin {get;set;}

        public string? Description {get;set;} 
        public string? Images {get;set;}
        public string? author {get;set;}
        public DateTime? createted_Date {get;set;}
        public bool? IsActive {get;set;}
         public long? ChampionsID {get;set;}
        public string? NameChampions { get; set; }
        public  tblChampions? Champions{ get; set; }
        
        

    }
    }
