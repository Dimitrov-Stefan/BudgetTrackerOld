using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BudgetTracker.BL.Concrete;
using BudgetTracker.BL.Abstract;
using BudgetTracker.Common.Dtos.FinancialOperationDtos;

namespace BudgetTracker.API.Controllers
{
    [Produces("application/json")]
    [Route("api/FinancialOperations")]
    public class FinancialOperationsController : Controller
    {
        private readonly IFinancialOperationService financialOperationService;

        public FinancialOperationsController(IFinancialOperationService financialOperationService)
        {
            this.financialOperationService = financialOperationService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IList<FinancialOperationGetDto> GetAll()
        {
            return financialOperationService.GetAll();
        }
    }
}