using System;


namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //void Dispose();
        void Commit();
        void Dispose(bool disposing);
        Repository<T> Repository<T>() where T : class;
    }
}

