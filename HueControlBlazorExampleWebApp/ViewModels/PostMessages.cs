﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HueControlBlazorExampleWebApp.ViewModels
{
    public class PostMessage
    {
        [Required, MinLength(1)]
        public string Text { get; set; }
    }
}
