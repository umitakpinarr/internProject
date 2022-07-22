using JobsArgeya.Data.Context;
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

        public string GetJobDetails(int JobId, int Parameter)
        {
            var DbJob = _databaseContext.Jobs.Where(x => x.Id == JobId).FirstOrDefault();
            if(Parameter == 0)
            {
                return DbJob.JobTitle.ToString();
            }
            else if(Parameter == 1)
            {
                return DbJob.JobKeywords.ToString();
            }
            else if(Parameter == 2)
            {
                return DbJob.JobDescription.ToString();
            }
            else if(Parameter == 3)
            {
                return DbJob.JobContent.ToString();
            }
            else if(Parameter == 4)
            {
                return DbJob.JobSlug.ToString();
            }
            else
            {
                return "";
            }
        }
        public string GetSiteDetails(int Parameter, string Host)
        {
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            var DbSettings = _databaseContext.Settings.Where(x => x.CompanyId == DbCompany.Id).FirstOrDefault();
            if(Parameter == 0)
            {
                return DbSettings.Keywords.ToString();
            }
            else if(Parameter == 1)
            {
                return DbSettings.Description.ToString();
            }
            else if(Parameter == 2)
            {
                return DbSettings.SiteColor.ToString();
            }
            else if(Parameter == 3)
            {
                return DbSettings.Title.ToString();
            }
            else if(Parameter == 4)
            {
                return DbSettings.Adress.ToString();
            }
            else if(Parameter == 5)
            {
                return DbSettings.Logo.ToString();
            }
            else
            {
                return "";
            }
        }
        public string GetUserOffice(int UserId, int Parameter)
        {
            var DbUser = _databaseContext.Users.Where(x => x.Id == UserId).FirstOrDefault();
            var DbCompany = _databaseContext.Companies.Where(x => x.Id == DbUser.CompanyId).FirstOrDefault();
            if(Parameter == 1)
            {
                return DbCompany.CompanyName;
            }
            else if (Parameter == 2)
            {
                return DbCompany.CompanyDomain;
            }
            else if(Parameter == 3)
            {
                return DbCompany.Id.ToString();
            }           
            else
            {
                return "";
            }
        }
    }
}
