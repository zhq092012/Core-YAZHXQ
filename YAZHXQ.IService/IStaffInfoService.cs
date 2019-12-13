using System;
using System.Collections.Generic;
using System.Text;
using YAZHXQ.Models.Models;

namespace YAZHXQ.IService
{
    public interface IStaffInfoService
    {
        List<StaffInfo> GetALL();
    }
}
