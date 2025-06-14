﻿using Packages.Mediatr.Contracts.Common;

namespace Packages.Mediatr.Contracts.Services
{
    public interface IMediatr
    {
        Task SendAsync<T>(T command)
            where T : IRequest;

        Task<TResult> SendAsync<T, TResult>(T query)
            where T : IRequest<TResult>
            where TResult : class;
    }
}
