using AutoMapper;
using Perpustakaan.Dtos;
using Perpustakaan.Models;

namespace Perpustakaan.Profiles
{
    public class BukuProfile : Profile
    {
        public BukuProfile()
        {
            // source -> target
            CreateMap<Buku, BukuRead>();
            CreateMap<BukuCreate, Buku>();
            CreateMap<BukuUpdate, Buku>();
            CreateMap<Buku, BukuUpdate>();
        }
    }
}