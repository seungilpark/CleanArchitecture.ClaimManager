﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Application.DTOs.Email
{
    public class EmailRequest
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
    }
}
