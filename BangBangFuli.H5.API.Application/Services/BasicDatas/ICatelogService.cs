﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BangBangFuli.H5.API.Application.Services.BasicDatas
{
    public interface ICatelogService: IAppService
    {
        string GetClassName(int classId);

    }
}