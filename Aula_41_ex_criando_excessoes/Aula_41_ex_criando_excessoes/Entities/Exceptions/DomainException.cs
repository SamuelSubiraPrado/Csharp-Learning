namespace Aula_41_ex_criando_excessoes.Entities.Exceptions
{
    //Criando uma exc personalizada
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
