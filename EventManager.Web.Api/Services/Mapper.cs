namespace EventManager.Web.Api.Services
{
    // Aqui vc pode fazer sua implementação (o que vai ser bem chato),
    // ou usar alguma já existente. Tem um Mapper no Nuget que é excelente,
    // ele mapeia automaticamente as propriedades com nomes iguais, e vc pode customizar
    // o resto como quiser de forma funcional.
    // A idéia é essa classe ser a responsável por mapear objetos model em objetos de
    // domínio e vice-versa.
    public interface IMapper
    {
        TOutput Map<TInput, TOutput>(TInput input);
    }
}
