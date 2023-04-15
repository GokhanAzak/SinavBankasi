using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniesLayer.Abstruct
{
    public interface IContentService
    {
        List<Content> GetList();
      
     
        void ContentAdd(Content content);
        Category GetByID(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
