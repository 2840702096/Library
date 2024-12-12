using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public class MessageSettings
    {
        public MessageSettings()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MessageContext { get; set; }
    }
}
