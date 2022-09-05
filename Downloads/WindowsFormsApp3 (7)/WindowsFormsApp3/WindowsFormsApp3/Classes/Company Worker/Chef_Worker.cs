using System;
using WindowsFormsApp3.Company_Worker;

namespace WindowsFormsApp3.Classes.Company_Worker
{
    [Serializable]
    public class Chef : CompanyWorker
    {
        string chefType;
        public Chef(long idVal, string firstNameVal, string lastNameVal, string cellPhoneVal, DateTime birthVal, int salary, string title, long workerID) : base(idVal, firstNameVal, lastNameVal, cellPhoneVal, birthVal, salary, title, workerID)
        {
            this.Id = idVal;
            this.FirstName = firstNameVal;
            this.LastName = lastNameVal;
            this.CellPhone = cellPhoneVal;
            this.BirthDate = birthVal;
            this.WorkerID = workerID;
            this.Salary = salary;
            this.Title = title;
            this.ChefType = chefType;
        }
        public string ChefType { get { return chefType; } set { chefType = value; } }

        public override int CalculateSalary()
        {
            return base.CalculateSalary() + 2000;
        }
        ~Chef() { }
    }
}
