﻿using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Clientes.CreateCliente;

namespace Ambev.DeveloperEvaluation.Application.Clients.CreateCliente;

/// <summary>
/// Profile for mapping between Cliente entity and CreateClienteResponse
/// </summary>
public class CreateClienteProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateCliente operation
    /// </summary>
    public CreateClienteProfile()
    {
        CreateMap<CreateClienteCommand, Cliente>(); // Mapeamento de CreateClienteCommand para Cliente
        CreateMap<Cliente, CreateClienteResult>();   // Mapeamento de Cliente para CreateClienteResult
    }
}
