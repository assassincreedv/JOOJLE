using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Repository
{
    public class ProductRepository:GenericRepository<Product>, IProductRepository
    {

        public ProductRepository() {
        }
    }
}