﻿using System;
using System.Collections.Generic;

namespace ShtikLive.Models.Present
{
    public class StartShow
    {
        public string Presenter { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public DateTimeOffset Time { get; set; }
        public string Place { get; set; }
        public string Markdown { get; set; }
    }
}