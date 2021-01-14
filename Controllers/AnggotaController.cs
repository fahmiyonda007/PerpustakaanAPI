using System.Collections.Generic;
using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Perpustakaan.Data;
using Perpustakaan.Dtos;
using Perpustakaan.Models;

namespace Perpustakaan.Controllers
{

    [Route("api/anggota")]
    [ApiController]
    public class AnggotaController : ControllerBase
    {
        private readonly IAnggotaRepo _repository;
        private readonly IMapper _mapper;

        public AnggotaController(IAnggotaRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/anggota
        [HttpGet]
        public ActionResult<IEnumerable<AnggotaRead>> GetAllAnggota()
        {
            var items = _repository.GetAllAnggota();
            return Ok(_mapper.Map<IEnumerable<AnggotaRead>>(items));
        }

        // GET api/anggota/{id}
        [HttpGet("{id}", Name = "GetAnggotaById")]
        public ActionResult<AnggotaRead> GetAnggotaById(int id)
        {
            var item = _repository.GetAnggotaById(id);

            if (item != null)
                return Ok(_mapper.Map<AnggotaRead>(item));

            return NotFound();
        }

        // POST api/anggota
        [HttpPost]
        public ActionResult<AnggotaRead> CreateAnggota(AnggotaCreate create)
        {
            var model = _mapper.Map<Anggota>(create);
            _repository.CreateAnggota(model);
            _repository.SaveChanges();

            var read = _mapper.Map<AnggotaRead>(model);

            var body = new { code = HttpStatusCode.Created, msg = "Successfully Added", data = read };
            return CreatedAtRoute(nameof(GetAnggotaById), new { read.id }, body);
        }

        // PUT api/anggota/{id}
        [HttpPut("{id}")]
        public ActionResult<AnggotaRead> UpdateAnggota(int id, AnggotaUpdate update)
        {
            var data = _repository.GetAnggotaById(id);
            if (data == null)
                return NotFound();

            var read = _mapper.Map(update, data);

            _repository.UpdateAnggota(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.Created, msg = "Successfully Updated", data = read };
            return CreatedAtRoute(nameof(GetAnggotaById), new { read.id }, body);
        }

        // PATCH api/anggota/{id}
        [HttpPatch("{id}")]
        public ActionResult<AnggotaRead> PartialUpdateAnggota(int id, JsonPatchDocument<AnggotaUpdate> patchDoc)
        {
            var data = _repository.GetAnggotaById(id);
            if (data == null)
                return NotFound();

            var toPatch = _mapper.Map<AnggotaUpdate>(data);
            patchDoc.ApplyTo(toPatch, ModelState);
            if (!TryValidateModel(toPatch))
            {
                return ValidationProblem(ModelState);
            }

            var read = _mapper.Map(toPatch, data);
            _repository.UpdateAnggota(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.Created, msg = "Successfully Updated", data = read };
            return CreatedAtRoute(nameof(GetAnggotaById), new { read.id }, body);
        }

        // DELETE api/anggota/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAnggota(int id)
        {
            var data = _repository.GetAnggotaById(id);
            if (data == null)
                return NotFound();

            _repository.DeleteAnggota(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.OK, msg = "Successfully Deleted"};
            return Ok(body);
        }

    }
}