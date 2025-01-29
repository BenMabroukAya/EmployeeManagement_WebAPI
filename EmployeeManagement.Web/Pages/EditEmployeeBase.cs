using EmployeeManagement.Models.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using WebApiEmployee__.Models;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public required NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
        }

        protected async Task HandleValidSubmit()
        {
            if (Employee.EmployeeId != 0)
            {
                await EmployeeService.UpdateEmployee(Employee);
            }

            NavigateToEmployeeList();
        }

        protected void NavigateToEmployeeList()
        {
            NavigationManager.NavigateTo("/EmployeeList");
        }
    }
}
