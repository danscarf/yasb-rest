﻿using System.Collections.Generic;

namespace Rest
{
    public class Book
    {
        public int Id { get; set; }
        public List<Author> Authors { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
    }
}
