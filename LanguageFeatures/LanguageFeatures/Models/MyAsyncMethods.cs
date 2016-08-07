﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {

        public static async Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync("http://apress.com");

            return httpMessage.Content.Headers.ContentLength;
        }
    }
}