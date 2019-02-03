using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public List<Vendor> Retrieve()
        {
            if(vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyx@xyz.com" });
            }

            foreach (var vendor in vendors)
            {
                vendor.CompanyName = vendor.CompanyName.ToUpper();
                Console.WriteLine(vendor);
            }

            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);
            }
            
            return vendors;
        }

        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Vendor>()
            {
                { "ABC Corp", new Vendor{ VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" } },
                { "XYZ Inc", new Vendor{ VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" } },
            };

            foreach (var element in vendors)
            {
                Console.WriteLine($"Key : {element.Key} & Value : {element.Value}");
            }

            //foreach (var companyName in vendors.Keys)
            //{
            //    Console.WriteLine(vendors[companyName]);
            //}

            //if(vendors.TryGetValue("XYZ Inc", out var vendor))
            //{
                //Console.WriteLine(vendor);
            //}
            
            return vendors;
        }

        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;
            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
