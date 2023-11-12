using GenericRepositoryPractice.DataAccessLayer.Context;
using GenericRepositoryPractice.Domain.Entities;
using GenericRepositoryPractice.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPractice.DataAccessLayer.Implementation
{
    public class GroupRepository:GenericRepository<Group>,IGroupRepository
    {
        public GroupRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
