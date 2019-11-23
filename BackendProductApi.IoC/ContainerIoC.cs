using BackendProductApi.Aplicacion.Contratos;
using BackendProductApi.Aplicacion.Servicios;
using BackendProductApi.Dominio.Contratos;
using BackendProductApi.Dominio.Dominio;
using BackendProductApi.Dominio.Servicio;
using BackendProductApi.Infraestructura.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendProductApi.IoC
{
    public static class ContainerIoC
    {
        public static IServiceCollection Servicios(IServiceCollection servicio) 
        {
            servicio.AddScoped<IProductoRepositorio, ProductoRepositorio>();
            servicio.AddScoped<IProductoDominioServicio, ProductoDominioServicio>();
            servicio.AddScoped<IProductoAplicacionServicio, ProductoAplicacionServicio>();

            return servicio;

        }
    }
}
