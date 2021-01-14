using System;
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

    [Route("api/pinjam")]
    [ApiController]
    public class PinjamController : ControllerBase
    {
        private readonly IPinjamRepo _repository;
        private readonly IMapper _mapper;

        public PinjamController(IPinjamRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/pinjam
        [HttpGet]
        public ActionResult<IEnumerable<PinjamRead>> GetAllPinjam()
        {
            var items = _repository.GetAllPinjam();
            return Ok(_mapper.Map<IEnumerable<PinjamRead>>(items));

        }

        // GET api/pinjam/{id}
        [HttpGet("{id}", Name = "GetPinjamById")]
        public ActionResult<PinjamRead> GetPinjamById(int id)
        {
            var item = _repository.GetPinjamById(id);

            if (item != null)
                return Ok(_mapper.Map<PinjamRead>(item));

            return NotFound();
        }

        // POST api/pinjam
        [HttpPost]
        public ActionResult<PinjamRead> CreatePinjam(PinjamCreate create)
        {
            var model = _mapper.Map<Pinjam>(create);
            _repository.CreatePinjam(model);
            _repository.SaveChanges();

            var read = _mapper.Map<PinjamRead>(model);
            
            var body = new { code = HttpStatusCode.Created, msg = "Successfully Added", data = read };
            return CreatedAtRoute(nameof(GetPinjamById), new { read.id }, body);
        }

        // PUT api/pinjam/{id}
        [HttpPut("{id}")]
        public ActionResult<PinjamRead> UpdatePinjam(int id, PinjamUpdate update)
        {
            var data = _repository.GetPinjamById(id);
            if (data == null)
                return NotFound();

            var read = _mapper.Map(update, data);

            _repository.UpdatePinjam(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.Created, msg = "Successfully Updated", data = read };
            return CreatedAtRoute(nameof(GetPinjamById), new { read.id }, body);
        }

        // PATCH api/pinjam/{id}
        [HttpPatch("{id}")]
        public ActionResult<PinjamRead> PartialUpdatePinjam(int id, JsonPatchDocument<PinjamUpdate> patchDoc)
        {
            var data = _repository.GetPinjamById(id);
            if (data == null)
                return NotFound();

            var toPatch = _mapper.Map<PinjamUpdate>(data);
            patchDoc.ApplyTo(toPatch, ModelState);
            if (!TryValidateModel(toPatch)) 
            {
                return ValidationProblem(ModelState);
            }

            var read = _mapper.Map(toPatch, data);
            _repository.UpdatePinjam(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.Created, msg = "Successfully Updated", data = read };
            return CreatedAtRoute(nameof(GetPinjamById), new { read.id }, body);
        }

        // DELETE api/pinjam/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePinjam(int id)
        {
            var data = _repository.GetPinjamById(id);
            if (data == null)
                return NotFound();

            _repository.DeletePinjam(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.OK, msg = "Successfully Deleted"};
            return Ok(body);
        }

        // GET api/pinjam/{anggota_id}/{buku_id}
        [HttpGet("{anggota_id}/{buku_id}")]
        public ActionResult<PinjamRead> GetPengembalianPinjam(int anggota_id, int buku_id)
        {
            var item = _repository.GetPengembalianPinjam(anggota_id, buku_id);

            if (item != null)
                return Ok(_mapper.Map<PinjamRead>(item));

            return NotFound();
        }

        // PUT api/pinjam/pengembalian/{anggota_id}/{buku_id}
        [HttpPut("pengembalian/{anggota_id}/{buku_id}")]
        public ActionResult<PinjamRead> UpdatePengembalianPinjam(int anggota_id, int buku_id, PinjamUpdatePengembalian update)
        {
            var data = _repository.GetPengembalianPinjam(anggota_id, buku_id);
            if (data == null)
                return NotFound();

            update.tanggal_pengembalian = DateTime.Now;
            var read = _mapper.Map(update, data);

            _repository.UpdatePengembalianPinjam(data);
            _repository.SaveChanges();

            var body = new { code = HttpStatusCode.Created, msg = "Successfully Updated", data = read };
            return CreatedAtRoute(nameof(GetPinjamById), new { read.id }, body);
        }

    }
}