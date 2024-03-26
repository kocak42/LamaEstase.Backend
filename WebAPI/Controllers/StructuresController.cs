using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StructuresController : ControllerBase
{
    IStructureService _structureService;

    public StructuresController(IStructureService structureService)
    {
        _structureService = structureService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _structureService.GetAll();
        return Ok(result);

    }
    [HttpGet("getbyId")]
    public IActionResult GetById(int id)
    {
       

        var result = _structureService.GetById(id);
        return Ok(result);

    }

    [HttpPost("add")]
    public IActionResult Add(Structure structure)
    {
        _structureService.Add(structure);
        return Ok();
    }
    [HttpPost("delete")]
    public IActionResult Delete(Structure structure)
    {
        _structureService.Delete(structure);
        return Ok();
    }
    [HttpPost("update")]
    public IActionResult Update(Structure structure)
    {
        _structureService.Update(structure);
        return Ok();
    }




}