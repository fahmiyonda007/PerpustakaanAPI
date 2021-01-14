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

    [Route("api/buku")]
    [ApiController]
    public class BukuController : ControllerBase
    {
        private readonly IBukuRepo _repository;
        private readonly IMapper _mapper;

        public BukuController(IBukuRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/buku
        [HttpGet]
        public ActionResult<IEnumerable<BukuRead>> GetAllBuku()
        {
            var items = _repository.GetAllBuku();
            return Ok(_mapper.Map<IEnumerable<BukuRead>>(items));

        }

        // GET api/buku/{id}
        [HttpGet("{id}", Name = "GetBukuById")]
        public ActionResult<BukuRead> GetBukuById(int id)
        {
            var item = _repository.GetBukuById(id);

            if (item != null)
                return Ok(_mapper.Map<BukuRead>(item));

            return NotFound();
        }

        // POST api/buku
        [HttpPost]
        public ActionResult<BukuRead> CreateBuku(BukuCreate create)
        {
            var model = _mapper.Map<Buku>(create);
            _repository.CreateBuku(model);
            _repository.SaveChanges();

            var read = _mapper.Map<BukuRead>(model);
            
            var body = new { code = HttpStatusCode.Created, msg = "Successfully Added", data = read };
            return CreatedAtRoute(nameof(GetBukuById), new { read.id }, body);
        }

        // PUT api/buku/{id}
        [HttpPut("{id}")]
        public ActionResult<BukuRead> UpdateBuku(int id, BukuUpdate update)
        {
            var data = _repository.GetBukuById(id);
            if (data == null)
                return NotFound();

            var read = _mapper.Map(update, data);

            _repository.UpdateBuku(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.Created, msg = "Successfully Updated", data = read };
            return CreatedAtRoute(nameof(GetBukuById), new { read.id }, body);
        }

        // PATCH api/buku/{id}
        [HttpPatch("{id}")]
        public ActionResult<BukuRead> PartialUpdateBuku(int id, JsonPatchDocument<BukuUpdate> patchDoc)
        {
            var data = _repository.GetBukuById(id);
            if (data == null)
                return NotFound();

            var toPatch = _mapper.Map<BukuUpdate>(data);
            patchDoc.ApplyTo(toPatch, ModelState);
            if (!TryValidateModel(toPatch)) 
            {
                return ValidationProblem(ModelState);
            }

            var read = _mapper.Map(toPatch, data);
            _repository.UpdateBuku(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.Created, msg = "Successfully Updated", data = read };
            return CreatedAtRoute(nameof(GetBukuById), new { read.id }, body);
        }

        // DELETE api/buku/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteBuku(int id)
        {
            var data = _repository.GetBukuById(id);
            if (data == null)
                return NotFound();

            _repository.DeleteBuku(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.OK, msg = "Successfully Deleted"};
            return Ok(body);
        }

    }
}