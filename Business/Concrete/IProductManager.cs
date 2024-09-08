using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class IProductManager : IProductService
    {
        // Bu kısımda ilk defa constructor oluşturuyoruz ve IProductDal kullanarak
        // bir veri erişim nesnesi oluşturuyoruz product için

        //Bir field oluşturuyoruz bu fieldı constructor içerisinde newleyeceğiz.
        //Bu sayede ProductManager classı bir yerde new'lendiği zaman bu construcor çalışacak

        IProductDal _productDal;

        public IProductManager (IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
          
        }
    }
}
