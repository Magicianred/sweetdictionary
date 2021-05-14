using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void WriterAdd(Writer writer);
        Writer GetById(int id);
        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);

    }
}
