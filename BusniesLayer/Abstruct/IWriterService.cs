using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniesLayer.Abstruct
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void Writeradd(Writer writer);
        void WriterDelete(Writer writer);
        void Writerupdate(Writer writer);
        Writer GetByID(int id);
    }
}
