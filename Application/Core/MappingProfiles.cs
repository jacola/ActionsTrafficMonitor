using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // We don't want to remove optional parameters so we exclude null updates. If we didn't do this,
            // we'd lose QueuedAt when we update StartedAt.
            CreateMap<WorkflowJob, WorkflowJob>().ForAllMembers(o
                => o.Condition((src, dest, srcmember, destmember) => srcmember != null));
        }
    }
}