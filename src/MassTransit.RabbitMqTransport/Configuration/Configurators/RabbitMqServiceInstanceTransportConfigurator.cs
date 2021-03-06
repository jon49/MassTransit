namespace MassTransit.RabbitMqTransport.Configurators
{
    using System;
    using Conductor.Configuration.Configurators;


    public class RabbitMqServiceInstanceTransportConfigurator :
        IServiceInstanceTransportConfigurator<IRabbitMqReceiveEndpointConfigurator>
    {
        public void ConfigureServiceEndpoint(IRabbitMqReceiveEndpointConfigurator configurator)
        {
            configurator.BindMessageExchanges = false;
        }

        public void ConfigureInstanceServiceEndpoint(IRabbitMqReceiveEndpointConfigurator configurator)
        {
            configurator.BindMessageExchanges = false;
        }

        public void ConfigureControlEndpoint(IRabbitMqReceiveEndpointConfigurator configurator)
        {
            configurator.AutoDelete = true;
            configurator.Durable = false;
            configurator.QueueExpiration = TimeSpan.FromMinutes(1);
        }

        public void ConfigureInstanceEndpoint(IRabbitMqReceiveEndpointConfigurator configurator)
        {
            configurator.AutoDelete = true;
            configurator.Durable = false;
            configurator.QueueExpiration = TimeSpan.FromMinutes(1);
        }
    }
}
