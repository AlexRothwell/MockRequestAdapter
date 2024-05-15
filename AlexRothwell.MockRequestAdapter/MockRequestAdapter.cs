using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
// ReSharper disable InconsistentNaming

namespace AlexRothwell.MockRequestAdapter
{
    public class MockRequestAdapter : IRequestAdapter
    {
        public MockRequestAdapter(ISerializationWriterFactory serializationWriterFactory)
        {
            SerializationWriterFactory = serializationWriterFactory;
        }

        public void EnableBackingStore(IBackingStoreFactory backingStoreFactory)
        {
            throw new System.NotImplementedException();
        }

        public Task<ModelType?> SendAsync<ModelType>(RequestInformation requestInfo, ParsableFactory<ModelType> factory, Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
            CancellationToken cancellationToken = new()) where ModelType : IParsable
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ModelType>?> SendCollectionAsync<ModelType>(RequestInformation requestInfo, ParsableFactory<ModelType> factory,
            Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null, CancellationToken cancellationToken = new()) where ModelType : IParsable
        {
            throw new System.NotImplementedException();
        }

        public Task<ModelType?> SendPrimitiveAsync<ModelType>(RequestInformation requestInfo, Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
            CancellationToken cancellationToken = new())
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ModelType>?> SendPrimitiveCollectionAsync<ModelType>(RequestInformation requestInfo, Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
            CancellationToken cancellationToken = new())
        {
            throw new System.NotImplementedException();
        }

        public Task SendNoContentAsync(RequestInformation requestInfo, Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
            CancellationToken cancellationToken = new())
        {
            throw new System.NotImplementedException();
        }

        public Task<T?> ConvertToNativeRequestAsync<T>(RequestInformation requestInfo,
            CancellationToken cancellationToken = new())
        {
            throw new System.NotImplementedException();
        }

        public ISerializationWriterFactory SerializationWriterFactory { get; }
        public string? BaseUrl { get; set; }
    }
}