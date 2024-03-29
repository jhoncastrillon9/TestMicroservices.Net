﻿using Aforo255.Cross.Token.Src;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MS.AFORO255.Security.DTOs;
using MS.AFORO255.Security.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS.AFORO255.Security.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAccessService _accessService;
        private readonly JwtOptions _jwtOption;

        public AuthController(IAccessService accessService,
            IOptionsSnapshot<JwtOptions> jwtOption)
        {
            _accessService = accessService;
            _jwtOption = jwtOption.Value;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_accessService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AuthRequest request)
        {

            try
            {
                if (!_accessService.Validate(request.UserName, request.Password))
                {
                    return Unauthorized();
                }

                Response.Headers.Add("access-control-expose-headers", "Authorization");
                Response.Headers.Add("Authorization", JwtToken.Create(_jwtOption));

                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }


    }
}
