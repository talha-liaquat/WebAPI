using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Task
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("status")]
    public string[] Status { get; set; }

    [BsonElement("__v")]
    public int Version { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("Created_date")]
    public DateTime CreatedDate { get; set; }
}
