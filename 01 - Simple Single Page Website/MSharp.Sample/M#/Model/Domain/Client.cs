using MSharp;

namespace Domain
{
    class Client : EntityType
    {
        public Client()
        {
            String("Name").Mandatory();
            OpenImage("Image").Mandatory().AutoOptimize(false);
        }
    }
}