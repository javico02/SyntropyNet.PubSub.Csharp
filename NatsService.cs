using NATS.Client;
using SyntropyNet.PubSub.Sdk;
using System;
using System.Threading.Tasks;

namespace Syntropy.DataLayer.Sdk
{
    public class NatsService : INatsService
    {
        private readonly Options _options;
        private readonly IConnection _connection;

        public NatsService(string url)
        {
            _options = ConnectionFactory.GetDefaultOptions(url);
            _connection ??= new ConnectionFactory().CreateConnection(_options);
        }

        public void AddHandler(string subject, Action handler)
        {
            throw new NotImplementedException();
        }

        public void Publish(string subject, byte[] data)
        {
            _connection.Publish(subject, data);
        }

        public Task ServeAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
