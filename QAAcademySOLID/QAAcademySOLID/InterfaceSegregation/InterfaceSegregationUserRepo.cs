using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QAAcademySOLID.Interfaces;

namespace QAAcademySOLID.InterfaceSegregation
{


    public class InterfaceSegregationUserRepo : IReadable, IWriteable, IRemovable
    {
        public void Create() { }
        public void Update() { }
        public void Remove(int id) { }
        public void Get(int id) { }
        public void GetAll() { }
    }

    public class ReportRepository : IReadable
    {
        public void Get(int id) { }
        public void GetAll() { }
    }
}
