﻿using Microsoft.AspNetCore.SignalR;

namespace SoLoMo.Services;

public class NameUserIdProvider : IUserIdProvider
{
    public string? GetUserId(HubConnectionContext connection)
    {
        return connection.User?.Identity?.Name ?? string.Empty;
    }
}
