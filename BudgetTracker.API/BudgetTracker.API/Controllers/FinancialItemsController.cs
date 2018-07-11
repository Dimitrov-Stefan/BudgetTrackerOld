using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BudgetTracker.DAL.Abstract;
using BudgetTracker.BL.Abstract;
using AutoMapper;
using BudgetTracker.Common.Dtos.FinancialItemDtos;

namespace BudgetTracker.API.Controllers
{
    [Produces("application/json")]
    [Route("api/FinancialItems")]
    public class FinancialItemsController : Controller
    {
        private readonly IFinancialItemService financialItemService;

        public FinancialItemsController(IFinancialItemService financialItemService)
        {
            this.financialItemService = financialItemService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<FinancialItemGetDto> GetFinancialItems()

         {
            IList<FinancialItemGetDto> financialItems = financialItemService.GetAll();

            return financialItems;
        }

        [HttpGet("{id}")]
        public FinancialItemGetDto GetById(Guid id)
        {
            FinancialItemGetDto financialItem = financialItemService.GetById(id);

            return financialItem;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult CreateFinancialItem([FromBody]FinancialItemCreateDto financialItemDto)
        {
            financialItemService.Create(financialItemDto);

            return NoContent();
        }
    }
}