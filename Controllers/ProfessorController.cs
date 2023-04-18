using LabSchool.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LabSchool.Controllers;


[ApiController]
[Route("[controller]")]
public class ProfessorController : ControllerBase {

    private readonly ProfessorRepository _professorRepository;

    public ProfessorController(ProfessorRepository professorRepository){
        _professorRepository = professorRepository;
    }

    [HttpGet("Obter Professores")]
    public IActionResult Listar(){
        var professores = _professorRepository.ObterProfessores();
        return Ok(professores);
    }
}