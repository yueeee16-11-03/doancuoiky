using System.Net.Mime;
using System ;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using dona.Model;

namespace dona.Models
{
    [Table("tblPost")]
    public class tblPost{
        [Key] 
        public long PostID {get;set;}
        public string? Title {get;set;}

        public string? Abstract {get;set;}
        public string? Contents {get;set;}
        public string? Images {get;set;}
        public string? Link {get;set;}
        public string? author {get;set;}
        public DateTime? createted_Date {get;set;}
        public bool? IsActive {get;set;}
        
        public int PostOrder {get;set;}
        public int MenuID { get; set; }
       
        

    }
    }
