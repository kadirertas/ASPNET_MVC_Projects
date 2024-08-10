



using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Concerete;
using InterfaceAbstractDemo.Entities;

BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());



Customer customer = new Customer { Id = 1, DateOfBirth = new DateTime(2007, 12, 25),

    FirstName = "İsmail",
    LastName = "Topraktepe",
    NationalityId = "55555555555"
};


customerManager.Save(customer); 


