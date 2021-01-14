using AutoMapper;
using Perpustakaan.Dtos;
using Perpustakaan.Models;

namespace Perpustakaan.Profiles
{
    public class AnggotaProfile : Profile
    {
        public AnggotaProfile()
        {
            // source -> target
            CreateMap<Anggota, AnggotaRead>();
            CreateMap<AnggotaCreate, Anggota>();
            CreateMap<AnggotaUpdate, Anggota>();
            CreateMap<Anggota, AnggotaUpdate>();
        }
    }
}