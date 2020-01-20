using System;
using System.Collections.Generic;
using System.Text;

namespace JumpAPP.Models.WebResponse
{
    public class UserResponseModel
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string NomeCognome { get; set; }
        public int SYS_NONMODIFICABILE { get; set; }
        public string StringaUtente { get; set; }
    }
}
