using GenericRepositoryPractice.Domain.Entities;
using GenericRepositoryPractice.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeacherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_unitOfWork.TeacherRepository.GetAll());
        }
        [HttpGet("{id?}")]
        public IActionResult GetOne(int id)
        {
           return Ok(_unitOfWork.TeacherRepository.Get(id));
        }
        [HttpPost]
        public IActionResult Create()
        {
            
            _unitOfWork.TeacherRepository.Add(new Teacher { Name="Lorem2"});
            _unitOfWork.Save();

            return Ok(201);
        }
    }
}
