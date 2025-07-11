﻿using InventoryControl.API.Filters;
using Microsoft.AspNetCore.Mvc;

namespace InventoryControl.API.Attributes
{
    public class AuthenticatedUserAttribute : TypeFilterAttribute
    {
        public AuthenticatedUserAttribute() : base(typeof(AuthenticatedUserFilter))
        {
        }
    }
}
