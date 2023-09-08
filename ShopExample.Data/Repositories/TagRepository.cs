﻿

namespace ShopExample.Data.Repositories
{

    using ShopExample.Data.Infrastructure;
    using ShopExample.Model.Model;

    interface ITagRepository : IRepository<Tag>
    {

    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
