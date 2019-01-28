using Proj3API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proj3API.DataAccess.Repository
{
    public interface IRepository
    {
        //CRUD for each model

        //Company
        bool CreateCompany(Company company);
        ICollection<Company> GetCompanies();
        Company GetCompany(int id);
        bool UpdateCompany(Company company);
        bool DeleteCompany(int id);

        //Invoices
        bool CreateInvoice(Invoice invoice);
        ICollection<Invoice> GetInvoices();
        Invoice GetInvoice(int id);
        bool UpdateInvoice(Invoice invoice);
        bool DeleteInvoice(int id);

        //Logs
        bool CreateLog(Logs log);
        ICollection<Logs> GetLogs();
        Logs GetLog(int id);
        bool UpdateLog(Logs log);
        bool DeleteLog(int id);

        //Order Details
        bool CreateOrderDetail(OrderDetail orderDetail);
        ICollection<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetail(int id);
        bool UpdateOrderDetail(OrderDetail orderDetail);
        bool DeleteOrderDetail(int id);

        //Order Headers
        bool CreateOrderHeader(OrderHeaders orderHeader);
        ICollection<OrderHeaders> GetOrderHeaders();
        OrderHeaders GetOrderHeader(int id);
        bool UpdateOrderHeader(OrderHeaders orderHeader);
        bool DeleteOrderHeader(int id);

        //People
        bool CreatePerson(People person);
        ICollection<People> GetPeople();
        People GetPerson(int id);
        bool UpdatePerson(People person);
        bool DeletePerson(int id);

        //Products
        bool CreateProduct(Products product);
        ICollection<Products> GetProducts();
        People GetProduct(int id);
        bool UpdateProduct(Products product);
        bool DeleteProduct(int id);

        //ProductTypes
        bool CreateProductType(ProductType productType);
        ICollection<ProductType> GetProductTypes();
        ProductType GetProductType(int id);
        bool UpdateProductType(ProductType productTypes);
        bool DeleteProductType(int id);


        //Addition Methods

        //Company

        //Invoices

        //Logs

        //Order Details

        //Order Headers

        //People

        //Products

        //ProductTypes

    }
}
