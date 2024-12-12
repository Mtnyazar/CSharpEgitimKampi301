using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void TDelete(EntityLayer.Concrete.Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.Concrete.Customer> TGetAll()
        {
            throw new NotImplementedException();
        }

        public EntityLayer.Concrete.Customer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(EntityLayer.Concrete.Customer entity)
        {
            if(entity.CustomerName!="" && entity.CustomerName.Length>=3 && entity.CustomerCity!=null && entity.CustomerSurname!="" && entity.CustomerName.Length <= 30)
            {
                //EKleme İşlemi Yap 
            }
            else
            {
                //Hata Mesajı Ver
            }
        }

        public void TUpdate(EntityLayer.Concrete.Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
