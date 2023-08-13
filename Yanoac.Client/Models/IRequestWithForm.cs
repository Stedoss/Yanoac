using System.Collections.Generic;

namespace Yanoac.Client.Models;

public interface IRequestWithForm : IRequest
{
    public Dictionary<string, string> Form { get; }
}