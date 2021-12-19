using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using irpf.Dto;
using irpf.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace irpf.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class irpfController : ControllerBase
    {
        public irpfController() { }

        [HttpPost("calculate")]
        public IActionResult Post(PersonDto person)
        {
            try
            {
                var irpf = new IrpfCalculatorService(2021, person.TotalSalary, person.DependentsNumber).Calculate();
                return Ok(irpf);
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when trying to perform the calculation. Erro: {ex.Message}");
            }
        }
    }
}