﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common.DTOs
{
    public class ResultDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }

    public class ResultDto<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public T Data { get; set; }
    }
}
