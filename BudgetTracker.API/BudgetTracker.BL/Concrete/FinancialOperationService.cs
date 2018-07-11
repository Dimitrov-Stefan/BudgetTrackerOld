using BudgetTracker.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using BudgetTracker.Common.Dtos.FinancialOperationDtos;
using BudgetTracker.Common.Entities;
using BudgetTracker.DAL.Abstract;
using AutoMapper;
using System.Linq;

namespace BudgetTracker.BL.Concrete
{
    public class FinancialOperationService : IFinancialOperationService
    {
        private readonly IFinancialOperationRepository repository;

        public FinancialOperationService(IFinancialOperationRepository repository)
        {
            this.repository = repository;
        }

        public FinancialOperationGetDto GetById(Guid id)
        {
            return Mapper.Map<FinancialOperationGetDto>(repository.GetEntityById(id));
        }

        public IList<FinancialOperationGetDto> GetAll()
        {
            IList<FinancialOperation> financialOperationsInDb = repository.GetAll().ToList();
            IList<FinancialOperationGetDto> financialItems = Mapper.Map<IList<FinancialOperation>, IList<FinancialOperationGetDto>>(financialOperationsInDb);

            return financialItems;
        }

        public void Create(FinancialOperationCreateDto financialOperationCreateDto)
        {
            FinancialOperation financialOperation = Mapper.Map<FinancialOperation>(financialOperationCreateDto);

            repository.Add(financialOperation);
        }
    }
}
