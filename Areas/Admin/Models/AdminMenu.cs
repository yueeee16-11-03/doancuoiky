using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dona.Areas.Admin.Models
{
    [Table("AdminMenu")]
 public class AdminMenu
    {
[Key]
public long? AdminMenuID {get;set;}
public string? ItemName {get;set;}
 public int ItemLever {get;set;}
public int ParentLever {get;set;}
public int ItemOrder {get;set;}
public bool? IsActive {get;set;}
public string? ItemTarget {get;set;}
public string? AreaName {get;set;}
public string ? ControllerName {get;set;}
public string? ActionName{get;set;}
public string? Icon {get;set;}

public string? IdName{get;set;}

 }
    }