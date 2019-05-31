using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolModel;

namespace IDAL
{
    public interface IGrade
    {
        List<Grade> GetAllGrades();
    }
}
