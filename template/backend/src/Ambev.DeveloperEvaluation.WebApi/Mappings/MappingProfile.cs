﻿using Ambev.DeveloperEvaluation.Application.Auth.AuthenticateUser;
using Ambev.DeveloperEvaluation.Application.Clientes.CreateCliente;
using Ambev.DeveloperEvaluation.Application.Filiais;
using Ambev.DeveloperEvaluation.Application.Filiais.CreateFilial;
using Ambev.DeveloperEvaluation.Application.Produtos.CreateProduto;
using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.WebApi.Features.Auth.AuthenticateUserFeature;
using Ambev.DeveloperEvaluation.WebApi.Features.Clients.CreateCliente;
using Ambev.DeveloperEvaluation.WebApi.Features.Filiais.CreateFilial;
using Ambev.DeveloperEvaluation.WebApi.Features.Produtos.CreateProduto;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUser;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapeando de GetUserResult para GetUserResponse
            CreateMap<GetUserResult, GetUserResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));


            // Mapeando de GetUserResult para GetUserResponse
            CreateMap<AuthenticateUserRequest, AuthenticateUserCommand>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password));

            // Mapeando de GetUserResult para GetUserResponse
            CreateMap<AuthenticateUserResult, AuthenticateUserResponse>()
                .ForMember(dest => dest.Token, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));

            // Mapeia os dados de CreateClienteRequest para CreateClienteCommand
            CreateMap<CreateClienteRequest, CreateClienteCommand>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Telefone));

            // Configuração do mapeamento entre CreateClienteResult e CreateClienteResponse
            CreateMap<CreateClienteResult, CreateClienteResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)); // Ajuste a correspondência entre as propriedades

            // Adiciona o mapeamento entre CreateFilialRequest e CreateFilialCommand
            CreateMap<CreateFilialRequest, CreateFilialCommand>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => src.Cidade))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
                .ForMember(dest => dest.Cep, opt => opt.MapFrom(src => src.Cep));

            // Configuração de mapeamento entre CreateFilialResult e CreateFilialResponse
            CreateMap<CreateFilialResult, CreateFilialResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<CreateProdutoResult, CreateProdutoResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)) // Exemplo de mapeamento de propriedades diferentes
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))
                .ForMember(dest => dest.PrecoUnitario, opt => opt.MapFrom(src => src.PrecoUnitario));


        }

    }
}
