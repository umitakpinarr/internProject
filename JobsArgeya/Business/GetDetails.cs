﻿using JobsArgeya.Data.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Business
{
    public class GetDetails
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public GetDetails(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }

        public string getJobDetails(int jobId, int parameter)
        {
            var dbJob = _databaseContext.Jobs.Where(x => x.id == jobId).FirstOrDefault();
            if(parameter == 0)
            {
                return dbJob.jobTitle.ToString();
            }
            else if(parameter == 1)
            {
                return dbJob.jobKeywords.ToString();
            }
            else if(parameter == 2)
            {
                return dbJob.jobDescription.ToString();
            }
            else if(parameter == 3)
            {
                return dbJob.jobContent.ToString();
            }
            else if(parameter == 4)
            {
                return dbJob.jobSlug.ToString();
            }
            else
            {
                return "";
            }
        }
        public string getSiteDetails(int parameter, string host)
        {
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            var dbSettings = _databaseContext.Settings.Where(x => x.officeId == dbOffice.id).FirstOrDefault();
            if(parameter == 0)
            {
                return dbSettings.keywords.ToString();
            }
            else if(parameter == 1)
            {
                return dbSettings.description.ToString();
            }
            else if(parameter == 2)
            {
                return dbSettings.siteColor.ToString();
            }
            else if(parameter == 3)
            {
                return dbSettings.title.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
