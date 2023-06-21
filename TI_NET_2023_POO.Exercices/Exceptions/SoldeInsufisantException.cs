using System.Runtime.Serialization;

namespace TI_NET_2023_POO.Exercices.Exceptions
{
    internal class SoldeInsufisantException : Exception
    {
        public SoldeInsufisantException() : base("Solde insufisant") { }

        public SoldeInsufisantException(string? message) : base(message) { }
    }
}