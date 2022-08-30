﻿using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService : IResultServiceRepository<Color>
    {
        //Core'da IResultServiceRepository<T> yapısı oluşturuldu.
    }
}