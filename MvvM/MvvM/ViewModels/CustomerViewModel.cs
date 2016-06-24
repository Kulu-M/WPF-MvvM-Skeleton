using System;
using System.Diagnostics;
using System.Windows.Input;
using MvvM.Commands;
using MvvM.Models;

namespace MvvM.ViewModels
{
    internal class CustomerViewModel
    {
        /// <summary>
        /// Inintialize a new instance of CustomerViewModel class
        /// </summary>
        public CustomerViewModel()
        {
            _Customer = new Customer("Matze");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        private Customer _Customer;

        /// <summary>
        /// Get Customer instance
        /// </summary>
        public Customer Customer
        {
            get { return _Customer; }
        }

        /// <summary>
        /// Get the UpdateCommand for the ViewModel
        /// </summary>
        public ICommand UpdateCommand
        {
            get; private set;
        }


        /// <summary>
        /// Get or set bool indicating if customer can be updated
        /// </summary>
        public bool CanUpdate {
            get
            {
                if (Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }

        /// <summary>
        /// Save changes made to the Customer instance
        /// </summary>
        public void SaveChanges()
        {
            Debug.Assert(false, string.Format("{0} was updated.", Customer.Name));
        }
    }
}
