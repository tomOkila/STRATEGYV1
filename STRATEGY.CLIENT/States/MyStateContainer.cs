using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;

namespace STRATEGY.CLIENT.States
{
    public class MyStateContainer
    {
        public StrategicPlan StrategicPlanValue { get; set; }
        public Plan PlanValue { get; set; }
        public Employee EmployeeValue { get; set; }
        public RegisterUserDTO AppUsersValue { get; set; }

        public event Action OnStateChange;
        public void SetStrategicPlan(StrategicPlan StrategicPlanValue)
        {
            this.StrategicPlanValue = StrategicPlanValue;
            NotifyStateChanged();
        }

        public void SetEmployee(Employee EmployeeValue)
        {
            this.EmployeeValue = EmployeeValue;
            NotifyStateChanged();
        }

        public void SetPlan(Plan PlanValue)
        {
            this.PlanValue = PlanValue;
            NotifyStateChanged();
        }

        public void SetAppUsers(RegisterUserDTO AppUsersValue)
        {
            this.AppUsersValue = AppUsersValue;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}
