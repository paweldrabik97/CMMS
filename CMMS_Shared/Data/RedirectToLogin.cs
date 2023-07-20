using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIdentity.Pages.Identity
{
    /// <summary>
    /// Use this component to automatically redirect to login page
    /// </summary>
    public class RedirectToLogin : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {            
            NavigationManager.NavigateTo("/login", true);
        }

    }
}
