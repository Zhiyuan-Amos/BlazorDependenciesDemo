using AutoMapper;

namespace BlazorDependenciesDemo;

public class DummyProfile : Profile
{
    public DummyProfile()
    {
        CreateMap<DummyOne, DummyTwo>();
    }
}