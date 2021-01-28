using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimsManager.Client.Pages.Claims
{
    public partial class ApproveClaim
    {

        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
        }

    }
}
