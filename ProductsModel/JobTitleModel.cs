using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Infrastructure.Utilities;

namespace Business.ModelView
{
   public class JobTitleModel
    {
        public Guid Id { get; set; }
        [DisplayName(ConstantDisplay.JobTitleCode)]
        public string Code { get; set; }
        [DisplayName(ConstantDisplay.JobTitleName)]
        public string JobTitleName { get; set; }
        [DisplayName(ConstantDisplay.Description)]
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ServerCreate { get; set; }
        public string ServerUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
