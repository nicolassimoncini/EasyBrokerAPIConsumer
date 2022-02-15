using EasyBrokerAPIConsumer.Domain.Interfaces;
using EasyBrokerAPIConsumer.Domain.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyBrokerAPIConsumer.Domain.Classes
{
    /// <summary>
    /// Default EasyBroker API consumer.
    /// </summary>
    public class APIConsumer : IAPIConsumer, IDisposable
    {
        private readonly RestClient client;
        private readonly RestRequest request;

        /// <summary>
        /// Creates an APIConsumer.
        /// </summary>
        /// <param name="Uri">The API Uri.</param>
        /// <param name="APIKey">The API Key for using as X-Authorization header validation.</param>
        public APIConsumer(string Uri, string APIKey)
        {
            client = new RestClient(Uri);
            request = new RestRequest("properties")
                .AddHeader("X-Authorization", APIKey);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            client?.Dispose();
        }

        /// <inheritdoc/>
        public async Task<List<Content>> GetPropertiesAsync(CancellationToken cancellationToken = default)
        {
            Root root = await client.GetAsync<Root>(request, cancellationToken);
            return root.content;
        }
    }
}
