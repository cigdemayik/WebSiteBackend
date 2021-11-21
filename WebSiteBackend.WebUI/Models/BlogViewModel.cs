using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.BlogDtos;

namespace WebSiteBackend.WebUI.Models
{
    public class BlogViewModel
    {
        public List<BlogDto> Blogs { get; set; }
    }
}
