using CepEndereco.Api.Dtos;
using MassTransit;
using System.Text.Json;

namespace MassTransitConsumer.NotificationCreatedConsumer
{
    public class NotificationCreatedConsumer : IConsumer<EnderecoResponse<EnderecoDto>>
    {
        public async Task Consume(ConsumeContext<EnderecoResponse<EnderecoDto>> context)
        {
            var serializedMessage = JsonSerializer.Serialize(context.Message, new JsonSerializerOptions
            {
                WriteIndented = true // Esta opção formata o JSON para torná-lo mais legível.
            });

            Console.WriteLine($"Producer: {serializedMessage}");
        }
    }
}