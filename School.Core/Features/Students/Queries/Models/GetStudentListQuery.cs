﻿using Azure;
using MediatR;
using School.Core.Features.Students.Queries.Results;
using School.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery:IRequest<Bases.Response<List<GetStudentListResponse>>>
    {
    }
}
