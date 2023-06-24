using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJM_methodology_picker
{
    internal class ProjectModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Nume_Proiect")]
        public string Nume_Proiect { get; set; }
        [BsonElement("Buget")]
        public string Buget { get; set; }
        [BsonElement("Cerinte")]
        public string Cerinte { get; set; }
        [BsonElement("Ciclu_De_Dezvoltare")]
        public string Ciclu_De_Dezvoltare { get; set; }
        [BsonElement("Domeniu_Aplicare")]
        public string Domeniu_Aplicare { get; set; }
        [BsonElement("Managementul_Partilor_Interesate")]
        public string Managementul_Partilor_Interesate { get; set; }
        [BsonElement("Marimea_Echipei")]
        public string Marimea_Echipei { get; set; }
        [BsonElement("Obiectivele")]
        public string Obiectivele { get; set; }
        [BsonElement("Planificarea_Managementului_de_Proiect")]
        public string Planificarea_Managementului_de_Proiect { get; set; }
        [BsonElement("Resursele")]
        public string Resursele { get; set; }
        [BsonElement("Timpul")]
        public string Timpul { get; set; }

    }
}
