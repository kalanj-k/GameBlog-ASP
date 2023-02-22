﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBlog.Domain
{
    public class Comment : Entity
    {
        public string Text { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }

        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}
