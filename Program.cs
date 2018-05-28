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
        public static void Main()
        {

            var schemaRegistryUrl = "http://172.28.17.89:8081";
            var bootstrapServers = "172.28.17.89:29092";
            var topicName = "ISB.banking.financial_events";


            var consumerConfig = new Dictionary<string, object>
            {
                { "bootstrap.servers", bootstrapServers },
                //{ "group.id", Guid.NewGuid() },
                { "group.id", "test-consumer-group1" },
                { "schema.registry.url", schemaRegistryUrl },
                { "auto.commit.interval.ms", 5000 },
                //{ "auto.offset.reset", "earliest" }
                { "auto.offset.reset", "beginning" }
            };

            using (var consumer = new Consumer<key.SOURCEDB.BANKING.FINANCIAL_EVENTS, FINANCIAL_EVENTS>(consumerConfig, new AvroDeserializer<key.SOURCEDB.BANKING.FINANCIAL_EVENTS>(), new AvroDeserializer<FINANCIAL_EVENTS>()))
            {


                


                consumer.OnMessage += (o, e)
                    => Console.WriteLine($"event_id: {e.Key.EVENT_ID}, amount: {e.Value.AMOUNT}, agreement_id: {e.Value.AGREEMENT_ID}, created_date: {e.Value.CREATED_DATE}");
                
                consumer.OnError += (_, e)
                    => Console.WriteLine("Error: " + e.Reason);

                consumer.OnConsumeError += (_, e)
                    => Console.WriteLine("Consume error: " + e.Error.Reason);
                
                consumer.OnPartitionEOF += (o, e)
                    => Console.WriteLine("DONE");

                consumer.Subscribe(topicName);

                while (true)
                {
                    consumer.Poll(TimeSpan.FromMilliseconds(100));
                }
            }
        }


    }
}