using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);

        Produto MapperEntityToDto(Produto produto);
    }
}