using HiBlogs.Core.AuditedEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HiBlogs.Core.Entities
{
    /// <summary>
    /// 博客和标签中间表
    /// </summary>
    public class BlogBlogTag : Entity<int>
    {
        public int BlogId { get; set; }
        public int TagId { get; set; }

        
        public virtual Blog Blog { get; set; }
   

        public virtual BlogTag BlogTag { get; set; }
    }
}
