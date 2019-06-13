kafka-fe-consumer
==================================

This sample shows how to consume RB Financial events (FE) using Kafka.  The FE event uses the Avro format.  To create classes that represent the FE event in code we use the AvroGen tool from Confluent, see below.

## How To Run This Sample

### To run this sample you will need:
- .NET Core 2.2

### Dependencies:
- Confluent.Kafka
- Confluent.SchemaRegistry
- Confluent.SchemaRegistry.Serdes

### Usage:
Usage: .. bootstrapServers schemaRegistryUrl topicName groupId saslUserName saslPassword sslCaLocation sslCertificateLocation sslKeyLocation

Example:
```
dotnet kafka-fe-consumer.dll myip:9092 http://myip:8081 mytopic mygroup saslUser saslPass "C:\sslCaLocation\cafile.pem" "C:\sslCertLoc\cert.pem" "C:\sslKeyLoc\file.key"
```

### AvroGen tool
The Avro serializer and deserializer provided by Confluent.Kafka.Avro was used to generate the FE classes (FINANCIAL_EVENTS.cs and FINANCIAL_EVENTS_KEY.cs) using the avrogen tool, available via Nuget (.NET Core 2.1 required):
```
dotnet tool install -g Confluent.Apache.Avro.AvroGen
```
Run this in bash console in VS Code
```
avrogen -s avro\\FinancialEventsKey.asvc avro
```
```
avrogen -s avro\\FinancialEventsValue.avsc avro
```

The avrogen tool will create subfolders that correspond to the namespace of the schema files and the files will have the same name, i.e. FINANCIAL_EVENTS.cs. What we did was rename the key file to FINANCIAL_EVENTS_KEY and then move both files to the root of the project.