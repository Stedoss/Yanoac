using System.Collections.Generic;

namespace Yanoac.Client;

public interface IRequestWithForm : IRequest
{
    public Dictionary<string, string> Form { get; }
}