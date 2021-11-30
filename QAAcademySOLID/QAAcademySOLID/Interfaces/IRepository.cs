using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAcademySOLID.Interfaces
{
    public interface IRepository
    {
        void Update();
        void Create();
        void Remove(int id);
        void Get(int id);
        void GetAll();
    }

    public interface IReadable
    {
        void Get(int id);
        void GetAll();

    }

    public interface IWriteable
    {
        void Update();
        void Create();
    }

    public interface IRemovable
    {
        void Remove(int id);
    }
}
