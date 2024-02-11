using intro.DataAccess.Abstracts;
using intro.DataAccess.Concretes;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager
{
    //dependency injection loose coupling
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        //veri kaynağından çekilir...
        Console.WriteLine("Kurslar listelendi");
        //business rules

        return _courseDal.GetAll();
    }

}
