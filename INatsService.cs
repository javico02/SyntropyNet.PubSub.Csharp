using System;
using System.Threading.Tasks;

namespace SyntropyNet.PubSub.Sdk
{
    public interface INatsService : IDisposable
    {
        void Publish(string subject, byte[] data);
        Task ServeAsync();
        void AddHandler(string subject, Action handler);
    }
}
