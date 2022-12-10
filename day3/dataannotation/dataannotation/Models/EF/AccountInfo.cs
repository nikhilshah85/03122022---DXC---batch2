using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace dataannotation.Models.EF
{
    public partial class AccountInfo
    {

        [Required(ErrorMessage = "Account Number cannot be left blank")]
        [Range(1,60000,ErrorMessage ="Account Number should be in a range of 1 and 55000 only")]
        [Display(Name ="Account Number")]
        public int AccNo { get; set; }
        [StringLength(20,MinimumLength =3,ErrorMessage ="Name should be between 3 and 20 characters only")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Account cannot be opened without a valid Name")]
        [Display(Name ="First Name")]
        public string AccName { get; set; } = null!;
        [Display(Name ="Account Type")]
        public string AccType { get; set; } = null!;
        [Display(Name ="Available Balance")]
        public int AccBalance { get; set; }

        [EmailAddress(ErrorMessage ="This does not look to be a valid email address")]
        [Display(Name ="Email Address")]
        public string AccEmail { get; set; } = null!;
        [Display(Name ="Active")]
        public bool AccIsActive { get; set; }
    }
}
