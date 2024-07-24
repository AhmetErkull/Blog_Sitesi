using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace Blog_Sitesi.Filters
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly AuthorizationPolicy _policy;

        public AdminAreaAuthorization(AuthorizationPolicy policy)
        {
            _policy = policy;
        }
        public void Apply(ControllerModel controller)
        {
            if (controller.Attributes.Any(x=>x is AreaAttribute area && area.RouteValue.Equals("Admin",StringComparison.OrdinalIgnoreCase)))
            {
                controller.Filters.Add(new AuthorizeFilter(_policy));
            }
        }
    }
}
