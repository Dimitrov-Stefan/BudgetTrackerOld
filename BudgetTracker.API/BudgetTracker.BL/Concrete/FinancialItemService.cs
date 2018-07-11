using AutoMapper;
using BudgetTracker.BL.Abstract;
using BudgetTracker.Common.Dtos.FinancialItemDtos;
using BudgetTracker.Common.Entities;
using BudgetTracker.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetTracker.BL.Concrete
{
    public class FinancialItemService : IFinancialItemService
    {
        private readonly IFinancialItemRepository repository;

        public FinancialItemService(IFinancialItemRepository repository)
        {
            this.repository = repository;
        }

        public FinancialItemGetDto GetById(Guid id)
        {
            return Mapper.Map<FinancialItemGetDto>(repository.GetEntityById(id));
        }

        public IList<FinancialItemGetDto> GetAll()
        {
            IList<FinancialItem> financialItemsInDb = repository.GetAll().ToList();
            IList<FinancialItemGetDto> financialItems = Mapper.Map<IList<FinancialItem>, IList<FinancialItemGetDto>>(financialItemsInDb);

            return financialItems;
        }

        public void Create(FinancialItemCreateDto financialItemCreateDto)
        {
            FinancialItem financialItem = Mapper.Map<FinancialItem>(financialItemCreateDto);

            repository.Add(financialItem);
        }
    }
}
