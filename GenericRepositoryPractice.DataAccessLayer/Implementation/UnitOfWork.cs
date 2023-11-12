using GenericRepositoryPractice.DataAccessLayer.Context;
using GenericRepositoryPractice.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPractice.DataAccessLayer.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            TeacherRepository = new TeacherRepository(context);
            GroupRepository = new GroupRepository(context);
        }

        public ITeacherRepository TeacherRepository { get; }

        public IGroupRepository GroupRepository { get; }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
