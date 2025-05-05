using System;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var runway1 = new Runway();
            var runway2 = new Runway();
            var commandCentre = new CommandCentre(new[] { runway1, runway2 });

            var aircraft1 = new Aircraft("Boeing-747", commandCentre);
            var aircraft2 = new Aircraft("Airbus-A320", commandCentre);
            var aircraft3 = new Aircraft("Cessna-172", commandCentre);

            commandCentre.RegisterAircraft(aircraft1);
            commandCentre.RegisterAircraft(aircraft2);
            commandCentre.RegisterAircraft(aircraft3);

            aircraft1.RequestLanding();
            aircraft2.RequestLanding();
            aircraft3.RequestLanding();

            aircraft1.RequestTakeOff();

            aircraft3.RequestLanding();
        }
    }
}
