﻿using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        IResult TAdd(T t);
        IResult TDelete(T t);
        IResult TUpdate(T t);

        IDataResult<List<T>> TGetList();
        IDataResult<T> GetById(int id);



    }
}
