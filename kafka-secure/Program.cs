using System;
using Confluent.Kafka;
using Confluent.SchemaRegistry;
using Confluent.Kafka.SyncOverAsync;
using Confluent.SchemaRegistry.Serdes;
using System.Threading;

namespace kafka_fe_consumer
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length < 9)
            {
                Console.WriteLine("Usage: .. bootstrapServers schemaRegistryUrl topicName groupId saslUserName saslPassword sslCaLocation sslCertificateLocation sslKeyLocation");
                return;
            }

            var bootstrapServers = args[0];
            var schemaRegistryUrl = args[1];
            var topic = args[2];
            var groupId = args[3];
            var saslUsername = args[4];
            var saslPassword = args[5];
            var sslCaLocation = args[6];
            var sslCertificateLocation = args[7];
            var sslKeyLocation = args[8];

            // Set up config for schema registry and consumer.            
            var schemaConfig = new Confluent.SchemaRegistry.SchemaRegistryConfig()
            {
                SchemaRegistryUrl = schemaRegistryUrl
            };
            Confluent.SchemaRegistry.ISchemaRegistryClient src = new Confluent.SchemaRegistry.CachedSchemaRegistryClient(schemaConfig);

            // Create the config used 
            var config
             = new ConsumerConfig()
             {
                 BootstrapServers = bootstrapServers,
                 GroupId = groupId,
                 EnableAutoCommit = false,
                 AutoOffsetReset = AutoOffsetReset.Earliest,
                 EnablePartitionEof = true,
                 // Security configuration
                 SaslMechanism = SaslMechanism.Plain,
                 SecurityProtocol = SecurityProtocol.SaslSsl,
                 SaslUsername = saslUsername,
                 SaslPassword = saslPassword,
                 SslCaLocation = sslCaLocation,
                 SslCertificateLocation = sslCertificateLocation,
                 SslKeyLocation = sslKeyLocation
             };

            // Búum til builder fyrir consumer-inn og búumst við streng sem lykil og FinancialEvent object.
            var builder = new Confluent.Kafka.ConsumerBuilder<string, @is.rb.payment.FinancialEvent>(config)
                .SetErrorHandler((cons, error) => { 
                    Console.WriteLine($"an error occured: {error.ToString()}");
                })
                // Notum KeyDeserializer þegar það hefur verið virkjað í KSQL að setja AVRO lykil.
                // .SetKeyDeserializer(new AvroDeserializer<@is.rb.payment.FinancialEventsKey>(src).AsSyncOverAsync())
                .SetValueDeserializer(new AvroDeserializer<@is.rb.payment.FinancialEvent>(src).AsSyncOverAsync());

            Console.WriteLine("Setting up connection");
            //Set up a consumer to consume a topic
            using (var consumer = builder.Build())
            {
                consumer.Subscribe(topic);
                Console.WriteLine("Connected...");

                // Viljum að vinnslan hætti "gracefully"
                CancellationTokenSource cts = new CancellationTokenSource();
                Console.CancelKeyPress += (_, e) =>
                {
                    e.Cancel = true; // prevent the process from terminating.
                    cts.Cancel();
                };
                try
                {
                    while (true)
                    {
                        // Connect and start consumption of topic
                        var consumeResult = consumer.Consume(cts.Token);
                        // When all records of a topicpartition have been read, the last ConsumeResult for that partition will 
                        // have the property IsPartitionEOF=true and subsequent results will be null
                        if (consumeResult != null && !consumeResult.IsPartitionEOF)
                        {
                            // Console.WriteLine(consumeResult.Value);
                            Console.WriteLine($"EventId: {consumeResult.Value.EVENT_ID.ToString()}");
                            consumer.Commit(consumeResult);
                        }
                    }
                }
                finally
                {
                    // Lokum consumer-num þannig að Kafka viti af því að við erum hætt að lesa.
                    if (consumer != null)
                    {
                        consumer.Close();
                    }
                }
            }
        }
    }
}
