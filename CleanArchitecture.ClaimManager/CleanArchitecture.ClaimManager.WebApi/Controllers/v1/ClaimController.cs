﻿using CleanArchitecture.ClaimManager.Application.Features.ExpenseClaims.Commands.CreateExpenseClaim;
using CleanArchitecture.ClaimManager.Application.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimManager.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClaimController : BaseApiController
    {
        // GET: api/<controller>
        //[HttpGet]
        //public async Task<IActionResult> Get([FromQuery] GetAllProductsParameter filter)
        //{

        //    return Ok(await Mediator.Send(new GetAllProductsQuery() { PageSize = filter.PageSize, PageNumber = filter.PageNumber }));
        //}

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    return Ok(await Mediator.Send(new GetProductByIdQuery { Id = id }));
        //}

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateExpenseClaimCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //[Authorize]
        //public async Task<IActionResult> Put(int id, UpdateProductCommand command)
        //{
        //    if (id != command.Id)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(await Mediator.Send(command));
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //[Authorize]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    return Ok(await Mediator.Send(new DeleteProductByIdCommand { Id = id }));
        //}
    }
}
