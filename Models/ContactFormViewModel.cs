//using System;
//using System.ComponentModel.DataAnnotations;
//using System.Xml.Linq;
//using Microsoft.AspNetCore.Mvc.ModelBinding;

//public class ContactFormViewModel
//{
//    [Required]
//    [StringLength(50, MinimumLength = 8)]
//    public string CampusEmail { get; }

//    [Required(ErrorMessage = "Please enter your name")]
//    [StringLength(50, MinimumLength = 2)]
//    public string Name { get; set; }

//    [Required(ErrorMessage = "Please enter a valid email address")]
//    [EmailAddress(ErrorMessage = "Invalid email format")]
//    public string Email { get; set; }

//	[Required(ErrorMessage = "Please enter your message")]
//	[StringLength(500, MinimumLength = 2)]
//    public string Message { get; set; }
//}