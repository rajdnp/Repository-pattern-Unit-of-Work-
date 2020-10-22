using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication19.ViewModels;

namespace WebApplication19.Interfaces
{
    public interface IStudent
    {
        Task<bool> AddStudent(StudentViewModel model);
    }
}
