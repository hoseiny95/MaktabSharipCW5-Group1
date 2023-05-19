using ConsoleApp8.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Entity
{
    internal class PepoleList
    {
        List<Person> pepole = new List<Person>()
        {
            new Person(){Id= 1, Name ="zahra",Gender=0,City="shiraz",Address="street 1",Age=12,NationalCode="123456789",mobile=912234567,EmailAddress="zahra@g.com"},
            new Person(){Id= 2, Name ="masi",Gender=0,City="tehran",Address="street 2",Age=20,NationalCode="123456789",mobile=912234567,EmailAddress="masi@g.com"},
            new Person(){Id= 3, Name ="ali",Gender=1,City="esfahan",Address="street 3",Age=35,NationalCode="123456789",mobile=912234567,EmailAddress="ali@g.com"},
            new Person(){Id= 1, Name ="mahsa",Gender=0,City="shiraz",Address="street 1",Age=32,NationalCode="123456789",mobile=912234567,EmailAddress="mahsa@g.com"}



        };
    }
}
