﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Telegraph.Net.Models
{
    public class GetPageRequest
    {
        /// <summary>
        /// Required. Path to the Telegraph page (in the format Title-12-31, i.e. everything that comes after http://telegra.ph/).
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// If true, content field will be returned in Page object.
        /// </summary>
        [JsonProperty("return_content")]
        public bool ReturnContent { get; set; }
    }
}
