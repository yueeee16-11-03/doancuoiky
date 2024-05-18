using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 namespace dona.Models {
    [Table("tblMenu")]
    public class tblMenu
    {
        [Key]
        public int MenuID  {get; set;}
        public string?  MenuName {get; set;}
        public  bool? IsActive   {get; set;}
        public  string? CotrollerName  {get; set;}
        public  string? ActionName {get; set;}
        public  int Levers  {get; set;}
        public  int ParentID {get; set;}
        public int MenuOrder {get; set;}
        public int Position {get; set;}

        


        }
    }