
namespace Microsoft.Rest.ClientRuntime
{
    using System;

    public class UndeclaredResponseException : Exception
    {
        public UndeclaredResponseException(System.Net.HttpStatusCode code) : base($"A response with status code {code} was recieved, but this possibility was not declared in the specification.")
        {

        }
    }
}