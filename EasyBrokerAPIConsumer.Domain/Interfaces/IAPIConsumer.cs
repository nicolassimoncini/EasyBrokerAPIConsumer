using EasyBrokerAPIConsumer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyBrokerAPIConsumer.Domain.Interfaces
{
    /// <summary>
    /// Represents an EasyBroker API consumer
    /// </summary>
    public interface IAPIConsumer
    {
        /// <summary>
        /// Gets a complete list of properties
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<Content>> GetPropertiesAsync(CancellationToken cancellationToken = default);
    }
}
