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
    [Table("tblChampions")]
    public class tblChampions{
        [Key] 
        public long ChampionsID {get;set;}
        public string? NameChampions {get;set;}
        public string? Images {get;set;}
        public string? Link {get;set;}
        public string? author {get;set;}
        public DateTime? createted_Date {get;set;}
        public string? Decription {get;set;}
        public bool? IsActive {get;set;}
        public long PathID {get;set;}
      
        

    }
    }
