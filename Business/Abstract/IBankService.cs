﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBankService
    {
        IResult Add(BankDto bankDto);
        IDataResult<List<Bank>> GetAll();
    }
}