using JobsArgeya.Data.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Classes
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
            var dbName = _databaseContext.Jobs.Where(x => x.Id == jobId).FirstOrDefault();
            if(parameter == 0)
            {
                return dbName.JobTitle.ToString();
            }
            else if(parameter == 1)
            {
                return dbName.JobKeywords.ToString();
            }
            else if(parameter == 2)
            {
                return dbName.JobDescription.ToString();
            }
            else if(parameter == 3)
            {
                return dbName.JobContent.ToString();
            }
            else if(parameter == 4)
            {
                return dbName.JobSlug.ToString();
            }
            else
            {
                return "";
            }
        }
        public string getSiteDetails(int parameter)
        {
            var dbSettings = _databaseContext.Settings.Where(x => x.Id == 1).FirstOrDefault();
            if(parameter == 0)
            {
                return dbSettings.Keywords.ToString();
            }
            else if(parameter == 1)
            {
                return dbSettings.Description.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
