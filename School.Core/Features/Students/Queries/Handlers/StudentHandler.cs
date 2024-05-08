using AutoMapper;
using Azure;
using MediatR;
using School.Core.Bases;
using School.Core.Features.Students.Queries.Models;
using School.Core.Features.Students.Queries.Results;
using School.Data.Entites;
using School.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler:ResponseHandler, IRequestHandler<GetStudentListQuery, Bases.Response<List<GetStudentListResponse>>>
                                      , IRequestHandler<GetStudentByIDQuery, Bases.Response<GetSingleStudentResponse>>
    {
        #region fields
        private readonly IStudentService studentService;
        private readonly IMapper mapper;
        #endregion

        public StudentHandler(IStudentService _studentService,IMapper _mapper)
        {
            studentService = _studentService;
            mapper = _mapper;
        }
        public async Task<Bases.Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request,CancellationToken cancellation)
        {
            var studentlist= await studentService.GetAllStudentsAsync();
            var studentlistmapper =mapper.Map<List<GetStudentListResponse>>(studentlist);

            return Ok(studentlistmapper);
        }

        public async Task<Bases.Response<GetSingleStudentResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var student = await studentService.GetStudentByIDAsynck(request.Id);
            var studentmapper=mapper.Map<GetSingleStudentResponse>(student);
            if (studentmapper == null) return NotFound<GetSingleStudentResponse>("object Not Fount");

            return Ok(studentmapper);
        }
    }
}
