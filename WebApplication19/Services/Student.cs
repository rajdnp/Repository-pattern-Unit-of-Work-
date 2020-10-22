using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication19.Entities;
using WebApplication19.Interfaces;
using WebApplication19.UnitOfWork;
using WebApplication19.ViewModels;

namespace WebApplication19.Services
{
    public class Student : IStudent
    {
        private readonly IUnitOfWork _unitOfWork;

        public Student(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
       

        public async Task<bool> AddStudent(StudentViewModel model)
        {
            bool result = false;
            try
            {
                var studentRepository =  _unitOfWork.GetRepository<Students>();

                var student = new Students
                {
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Age = model.Age,
                    AaadharNumber = model.AaadharNumber,
                    ClassId = model.ClassId,
                    Address = model.Address,
                    Due = GetDueFee(model.TotalFee,model.Paid),
                    Middlename = model.Middlename,
                    TotalFee = model.TotalFee,
                    Paid = model.Paid
                };

                 studentRepository.Insert(student);
                _unitOfWork.Save();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        private static decimal? GetDueFee(decimal? totalFee,decimal? paid)
        {
            if(paid != -1)
            {
                return totalFee - paid;
            }

            return totalFee;
        }
    }
}
