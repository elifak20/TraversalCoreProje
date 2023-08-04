﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Destnation).ToList();
            }
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            throw new NotImplementedException();
        }

        //public List<Comment> GetListCommentWithDestinationAndUser(int id)
        //{
        //    using (var c = new Context())
        //    {
        //        return c.Comments.Where(x => x.DestnationID == id).Include(x => x.AppUser).ToList();
        //    }
        //}
    }
}
