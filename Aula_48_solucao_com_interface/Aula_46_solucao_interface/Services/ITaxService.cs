namespace Aula_48_solucao_com_interface.Services
{
    //É uma convenção em C#, que coloquemos I na frente do nome de uma inferface
    interface ITaxService
    {
        double Tax(double amount);
    }
}
