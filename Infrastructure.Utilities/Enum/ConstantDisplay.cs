using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Utilities
{
    public class ConstantDisplay
    {
        public const string dmCategory = "dmCategory";
        public const string Description = "Description";
        public const string Note = "Note";
        #region Danh sách nhân viên
        public const string dmEmployee = "dmEmployee";
        public const string dmEmployeelist = "dmEmployeelist";

        #endregion

        #region Danh sách chức danh
        public const string dmJobTitle = "dmJobTitle";
        public const string JobTitleName = "JobTitleName";
        public const string JobTitleCode = "JobTitleCode";
        #endregion
    }

    public class ConstantID
    {
        #region Danh sách chức danh
        public const string Index_GridJobTitle = "Index_GridJobTitle";
        #endregion
    }
}
