using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Oauth_Authentication_with_gmail.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}