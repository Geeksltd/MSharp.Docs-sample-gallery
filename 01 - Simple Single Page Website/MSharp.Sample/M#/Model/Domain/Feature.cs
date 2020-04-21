using MSharp;

namespace Domain
{
    class Feature : EntityType
    {
        public Feature()
        {
            String("Title").Mandatory();
            String("Description").Mandatory();
        }
    }
}