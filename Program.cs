using System;
using System.Text;
using System.Collections.Generic;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;
using value.SOURCEDB.BANKING;
using System.Threading;
using System.Threading.Tasks;
using Avro.Generic;

namespace KafkaAvro
{
    class Program
    {
        public static void Main(string[] args)
        {

            if (args.Length != 4)
            {
                Console.WriteLine("Usage: .. bootstrapServers schemaRegistryUrl topicName groupId");
                return;
            }

            var bootstrapServers = args[0];
            var schemaRegistryUrl = args[1];
            var topicName = args[2];
            var groupId = args[3];


            var consumerConfig = new Dictionary<string, object>
            {
                { "bootstrap.servers", bootstrapServers },
                { "group.id", groupId },
                { "schema.registry.url", schemaRegistryUrl },
                { "auto.offset.reset", "earliest" },
                { "enable.auto.commit", false }
            };

            Console.WriteLine("Connecting to Kafka...");
            var consumer = new Consumer<key.SOURCEDB.BANKING.FINANCIAL_EVENTS, FINANCIAL_EVENTS>(consumerConfig, new AvroDeserializer<key.SOURCEDB.BANKING.FINANCIAL_EVENTS>(), new AvroDeserializer<FINANCIAL_EVENTS>());
            Console.WriteLine("Connected!");

            consumer.CommitAsync();

            Console.WriteLine("Listening...");
            using (consumer)
            {

                consumer.OnMessage += (o, e) =>
                {
                    try
                    { 
                        Console.WriteLine($"Message processed: event_id: {e.Key.EVENT_ID}, amount: {e.Value.AMOUNT}, agreement_id: {e.Value.AGREEMENT_ID}, created_date: {e.Value.CREATED_DATE}");
                        consumer.CommitAsync(); //Commit read                      
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                    }
                };
                
                consumer.OnError += (_, e)
                    => Console.WriteLine("Error: " + e.Reason);

                consumer.OnConsumeError += (_, e)
                    => Console.WriteLine("Consume error: " + e.Error.Reason);
                
                consumer.OnPartitionEOF += (o, e)
                    => Console.WriteLine("Partition EOF");

                consumer.Subscribe(topicName);

                while (true)
                {
                    consumer.Poll(TimeSpan.FromMilliseconds(100));
                }
            }
        }


    }
}