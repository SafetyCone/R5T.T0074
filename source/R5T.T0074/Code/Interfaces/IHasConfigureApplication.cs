using System;

using Microsoft.AspNetCore.Builder;


namespace R5T.T0074
{
    public interface IHasConfigureApplication<TApplicationBuilder>
        where TApplicationBuilder : IHasConfigureApplication<TApplicationBuilder>
    {
        TApplicationBuilder ConfigureApplication(Action<IApplicationBuilder> configureAction);
    }
}
