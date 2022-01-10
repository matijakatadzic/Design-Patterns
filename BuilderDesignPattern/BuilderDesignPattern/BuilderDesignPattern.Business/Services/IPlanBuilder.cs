using BuilderDesignPattern.DataContract.Models;

namespace BuilderDesignPattern.Business.Services
{
    public interface IPlanBuilder
    {
        void BuildDiskSpaceFeature();

        void BuildDatabaseFeature();

        void BuildBandwidthFeature();

        void BuildSslFeature();

        Plan GetPlan();
    }
}
