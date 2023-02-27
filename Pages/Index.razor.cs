using AutoMapper;
using Microsoft.AspNetCore.Components;

namespace BlazorDependenciesDemo.Pages;

public partial class Index
{
    private long _elapsed;
    [Inject] private IMapper Mapper { get; init; }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            _elapsed = TimeStateContainer.Stop();
            StateHasChanged();
        }
    } 
}