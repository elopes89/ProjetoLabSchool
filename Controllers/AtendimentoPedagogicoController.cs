using System.Net;
using LabSchool.Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using LabSchool.Dtos;

namespace LabSchool.Controllers;


[ApiController]
[Route("AtendimentoPedagogicoController")]
public class AtendimentoPedagogicoController : ControllerBase
{

    private readonly AlunoRepository _alunoRepository;
    private readonly PedagogoRepository _pedagogoRepository;
    private readonly IMapper _mapper;

    public AtendimentoPedagogicoController(AlunoRepository alunoRepository, IMapper mapper, PedagogoRepository pedagogoRepository)
    {        _alunoRepository = alunoRepository;
        _mapper = mapper;
        _pedagogoRepository = pedagogoRepository;
    }

    [HttpPost]
    [Route("/AtendimentoPedagogico")]
    public IActionResult AtualizarSituacao([FromBody] AtendimentoPedagogico atendimento)
    {
        var pedagogo = _pedagogoRepository?.AtendimentoPedagogicoPedagogo(atendimento.PedagogoCodigo);
        var aluno = _alunoRepository?.AtendimentoPedagogicoAluno(atendimento.AlunoCodigo);
       
        return Ok(new { aluno, pedagogo });
    }
}