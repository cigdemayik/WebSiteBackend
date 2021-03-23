﻿using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.DataAccess.Abstracts.Interfaces;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Repositories
{
    public class BlogRepository:GenericRepository<Blog>,IBlogRepository
    {
        private readonly WebSiteContext context;
        public BlogRepository(WebSiteContext context): base (context)
        {
            this.context = context;
        }
    }
}
