using System.Collections.Generic;

namespace ExampleCode.Models
{
    public class ExampleModel
    {
        public List<ExampleMessage> Messages { get; set; }
    }

    public class ExampleMessage
    {
        public string Date { get; set; }

        public string Message { get; set; }
        public int DatabaseId { get; set; }
    }
}