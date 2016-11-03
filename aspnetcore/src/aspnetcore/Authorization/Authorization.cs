using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using aspnetcore.Models;
using Microsoft.Extensions.Options;

namespace aspnetcore.Authorization
{
    public class AdminEmailHandler : AuthorizationHandler<AdminEmailRequirement, Email>
    {
        private readonly IOptions<AdminEmails> _optionsAccessor;

        public AdminEmailHandler(IOptions<AdminEmails> optionsAccessor)
        {
            _optionsAccessor = optionsAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AdminEmailRequirement requirement, Email resource)
        {

            if (resource == null)
            {
                return Task.FromResult(0);
            }

            if (_optionsAccessor?.Value?.Emails == null)
            {
                return Task.FromResult(0);
            }

            if (_optionsAccessor.Value.Emails.Contains(resource.To))
            {
                context.Succeed(requirement);
            }

            return Task.FromResult(0);

        }
    }

    public class AdminEmailRequirement : IAuthorizationRequirement
    {
    }

    public class AdminEmails
    {
        public List<string> Emails { get; set; }
    }
}
