Kafka-FE-Consumer
==================================

This sample shows how to consume RB Financial events (FE) using Kafka.  The FE event uses the Avro format.  To create classes that represent the FE event in code we use the AvroGen tool from Confluent, see below.

## How To Run This Sample

### To run this sample you will need:
- .NET Core 2.1

### Dependencies:
- Confluent.Kafka
- Confluent.Kafka.Avro

### Usage:
Usage: .. bootstrapServers schemaRegistryUrl topicName groupId

Example:
```
dotnet Kafka-FE-Consumer.dll myip:9092 http://myip:8081 mytopic mygroup
```

### AvroGen tool
The Avro serializer and deserializer provided by Confluent.Kafka.Avro was used to generate the FE classes (FINANCIAL_EVENTS.cs and FINANCIAL_EVENTS_KEY.cs) using the avrogen tool, available via Nuget (.NET Core 2.1 required):
```
dotnet tool install -g Confluent.Apache.Avro.AvroGen
```
avrogen -s banking.financial_events-key.json .
avrogen -s banking.financial_events-value.json .