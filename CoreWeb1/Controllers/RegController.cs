using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWeb1.Service;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using CoreWeb1.Models;

namespace CoreWeb1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegController : ControllerBase
    {
        private readonly IReg _IReg;
        public RegController(IReg Reg)
        {
            _IReg = Reg;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegList()
          {
            var result = await _IReg.GetRegList();
            return Ok(result);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteReg(int Id)
        {
            try
            {
                var result = await _IReg.DeleteReg(Id);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the server");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddReg(TblReg Reg)
        {
            try
            {
                var result = await _IReg.AddReg(Reg);
                return Ok(result);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the server");
            }
        }
        [HttpGet("{Id}")]
        [HttpPut]
        [Route("Reg")]
        public async Task<IActionResult> UpdateReg(TblReg Reg)
        {
            try
            {
                await _IReg.UpdateReg(Reg);
                return Ok("Update Successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the server");
            }
        }
    }
}
