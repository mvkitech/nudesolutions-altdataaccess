using System;
using System.Collections.Generic;
using System.Text;

namespace DaoLibrary.Dto
{
    class CategoryDto
    {
        public int Id { get; set; }
        public int Sequence { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int TotalLimits { get; set; }
        public int ItemDesc { get; set; }
        public int ItemLimit { get; set; }
    }
}
