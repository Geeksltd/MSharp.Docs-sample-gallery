using MSharp;

namespace Domain
{
    class Testimony : EntityType
    {
        public Testimony()
        {
            OpenImage("Image").Mandatory().AutoOptimize(false);
            String("Name").Mandatory();
            String("Position").Mandatory();
            String("Content").Mandatory().Max(2000);
            Int("Display Order");
        }
    }
}