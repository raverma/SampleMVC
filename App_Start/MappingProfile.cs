﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleMVC.Models;
using AutoMapper;
namespace SampleMVC.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, Customer>();

        }
    }
}