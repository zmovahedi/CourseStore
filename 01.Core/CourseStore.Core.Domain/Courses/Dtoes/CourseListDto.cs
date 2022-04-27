using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Core.Domain.Courses.Dtoes
{
    public class CourseListDto
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
