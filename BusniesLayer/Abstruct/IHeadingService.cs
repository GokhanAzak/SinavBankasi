using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniesLayer.Abstruct
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void HeadingAdd(Heading heading);
        Heading GetByID(int id);
        void HeadingDelete(Heading heading);
        void HeadingUpdate(Heading heading);

    }
}
