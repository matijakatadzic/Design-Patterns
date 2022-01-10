namespace BuilderDesignPattern.Business.Services
{
    public interface IPlanDirector
    {
        void SetPlanBuilder(IPlanBuilder builder);

        void BuildBasicPlan();

        void BuildEnterprisePlan(); 
    }
}
