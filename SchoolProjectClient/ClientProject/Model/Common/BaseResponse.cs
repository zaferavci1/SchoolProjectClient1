﻿using System;
namespace SchoolProjectClient.Client.Model.Common
{
	public class BaseResponse<T> where T : class, new()
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool IsSucceeded { get; set; }
    }
}

