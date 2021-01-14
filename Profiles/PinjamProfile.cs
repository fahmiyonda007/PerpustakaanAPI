using AutoMapper;
using Perpustakaan.Dtos;
using Perpustakaan.Models;

namespace Perpustakaan.Profiles
{
    public class PinjamProfile : Profile
    {
        public PinjamProfile()
        {
            // source -> target
            CreateMap<Pinjam, PinjamRead>();
            CreateMap<PinjamCreate, Pinjam>();
            CreateMap<PinjamUpdate, Pinjam>();
            CreateMap<PinjamUpdatePengembalian, Pinjam>();
            CreateMap<Pinjam, PinjamUpdate>();
        }
    }
}