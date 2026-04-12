using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal : IGenericDal<Customer>
    {
        // Müşteri listesini getirirken, her müşterinin bağlı olduğu 'Job' (Meslek) 
        // tablosundaki verileri de (JobName vb.) içine dahil ederek getirir.
        // Bu işlem SQL'deki 'Inner Join' mantığı ile çalışır.
        List<Customer> GetCustomerListWithJob();
    }
}
