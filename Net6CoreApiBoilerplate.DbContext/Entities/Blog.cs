﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Net6CoreApiBoilerplate.Infrastructure.DbUtility;

namespace Net6CoreApiBoilerplate.DbContext.Entities
{
    public class Blog : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Oid { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}
