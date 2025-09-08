using STRATEGY.CLIENT.Models;

namespace STRATEGY.CLIENT.States
{
    public class MyStateContainer
    {
        public StrategicPlan StrategicPlanValue { get; set; }
        public Employee EmployeeValue { get; set; }

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
        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}
