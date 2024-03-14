namespace Pie.Shop.Web.Pages
{
    using BethanysPieShopHRM.Shared.Domain;
    using Models;

    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!; // Revisit Explanation 
        bool LoaderVisible { get; set; } = true;

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }
    }
}