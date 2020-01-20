using JumpAPP.Models.WebRequest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpAPP.Services
{
    public class JsonConstant
    {
        public static string OrganiserRequest(OrganiserFormRequestModel organiserFormRequestModel)
        {

            string json = JsonConvert.SerializeObject(organiserFormRequestModel, Formatting.Indented);
            return json;
        }
    }
}
