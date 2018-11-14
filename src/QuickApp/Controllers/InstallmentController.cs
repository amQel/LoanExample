using AutoMapper;
using DAL.Core;
using DAL.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuickApp.ViewModels;
using System.Collections.Generic;

namespace QuickApp.Controllers
{
    [Route("api/[controller]")]
    public class InstallmentController : Controller
    {
        readonly ILogger _logger;
        private readonly IInstallmentCalculatorResolver _installmentCalculatorResolver;

        public InstallmentController(ILogger<InstallmentController> logger, IInstallmentCalculatorResolver installmentCalculatorResolver)
        {
            _logger = logger;
            _installmentCalculatorResolver = installmentCalculatorResolver;
        }

        [HttpGet("getCalculateInstallment")]
        public IActionResult CalculateInstallments([FromQuery] double totalValue, [FromQuery] int numberOfYears, [FromQuery] InstallmentType installmentType)
        {
            return Ok(Mapper.Map<IEnumerable<InstallmentViewModel>>(_installmentCalculatorResolver.CalculateInstallments(totalValue, numberOfYears, installmentType)));
        }
        
    }
}
