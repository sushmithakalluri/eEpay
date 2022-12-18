using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public List<Customer> sortedcustlist;

    public void Insert(Customer[] customer)
    {
        // Consider the following data
        List<Customer> cust = new List<Customer>{
            new Customer { firstName = "Aaaa", lastName = "Bbbb", age = 20, id = 5 },
            new Customer { firstName = "Bbbb", lastName = "Cccc", age = 24, id = 6  },
            new Customer { firstName = "Yyyy", lastName = "Zzzz", age = 25, id = 8  }
        };

        //Consider the input customer is defined here with following values 
        List<Customer> cust1 = new List<Customer>{
            new Customer { firstName = "Ssss", lastName = "Tttt", age = 27, id = 7 }
        };

        // adding elements using object initializer syntax
        Customer cust2 = new Customer();
        cust2.firstName = "Ssss";
        cust2.lastName = "Tttt";
        cust2.age = 27;
        cust2.id = 7;
        cust.Add(cust2);

        Customer[] arrayCustomerss = cust.ToArray<Customer>();
        arrayCustomerss.Append(cust2);

        List<Customer> custlist = arrayCustomerss.ToList();
        List<Customer> sortedList = custlist.OrderBy(x => x.lastName).ToList();
        sortedcustlist = sortedList;

    }

    public List<Customer> Get()
    {
        return sortedcustlist;
    }

}
