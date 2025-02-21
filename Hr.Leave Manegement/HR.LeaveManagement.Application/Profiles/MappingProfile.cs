﻿using AutoMapper;
using Hr.Leave_Manegement.Domain;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
                CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap();
                CreateMap<LeaveRequest,LeaveRequestListDto>().ReverseMap();
                CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();
                CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
        }
    }
}
