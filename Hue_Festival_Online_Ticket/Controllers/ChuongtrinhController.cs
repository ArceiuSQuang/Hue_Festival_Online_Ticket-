﻿using Hue_Festival_Online_Ticket.IService;
using Hue_Festival_Online_Ticket.Model.Request;
using Hue_Festival_Online_Ticket.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hue_Festival_Online_Ticket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuongtrinhController : ControllerBase
    {
        private readonly IChuongtrinhService _chuongtrinhService;
        public ChuongtrinhController(IChuongtrinhService chuongtrinhService)
        {
            _chuongtrinhService = chuongtrinhService;
        }

        [HttpGet("get_program_list")]
        public async Task<IActionResult> getProgramList(int type_program)
        {
            return Ok(await _chuongtrinhService.getProgramList(type_program));
        }

        [HttpGet("get_detail_program")]
        public async Task<IActionResult> getProgramDetail(int id_program)
        {
            return Ok(await _chuongtrinhService.getDetailProgram(id_program));
        }

        [HttpGet("lich_dien/get_carlender_list")]
        public async Task<IActionResult> getCarlenderList()
        {
            return Ok(await _chuongtrinhService.getCarlenderList());
        }

        [HttpGet("lich_dien/get_carlender_program_list")]
        public async Task<IActionResult> getcarlenderprogramlist(string date)
        {
            return Ok(await _chuongtrinhService.getCarlenderProgramList(date));
        }

        [HttpPost("change_wish_program")]
        public async Task<IActionResult> changeWishProgram(YeuthichRequestDTO model)
        {
            return Ok(await _chuongtrinhService.changeWishProgram(model));
        }
    }
}