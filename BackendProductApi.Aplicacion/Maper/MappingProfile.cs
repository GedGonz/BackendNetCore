using AutoMapper;
using BackendProductApi.Aplicacion.EntidadesDto;
using BackendProductApi.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendProductApi.Aplicacion.Maper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Producto, ProductoDto>()
            .ForMember(x=>x.ProductoId, ops=>ops.MapFrom(x=>x.ProductoId))
            .ForMember(x => x.Nombre, ops => ops.MapFrom(x => x.Nombre))
            .ForMember(x => x.Descripcion, ops => ops.MapFrom(x => x.Descripcion))
            .ForMember(x => x.Categoria, ops => ops.MapFrom(x => x.Categoria))
            .ForMember(x => x.Precio, ops => ops.MapFrom(x => x.Precio))
            .ForMember(x => x.Imagen, ops => ops.MapFrom(x => x.Imagen)).ReverseMap();
        }
    }
}
