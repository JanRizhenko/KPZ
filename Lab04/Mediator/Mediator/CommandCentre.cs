using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Dictionary<Aircraft, Runway> _aircraftToRunway = new Dictionary<Aircraft, Runway>();

        public CommandCentre(Runway[] runways)
        {
            _runways.AddRange(runways);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void HandleLanding(Aircraft aircraft)
        {
            var freeRunway = _runways.FirstOrDefault(r => !r.IsBusy);
            if (freeRunway != null)
            {
                freeRunway.Occupy();
                _aircraftToRunway[aircraft] = freeRunway;
                Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {freeRunway.Id}");
            }
            else
            {
                Console.WriteLine($"No free runways for {aircraft.Name}. Please wait.");
            }
        }

        public void HandleTakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"\nAircraft {aircraft.Name} requesting to take off...");
            if (_aircraftToRunway.TryGetValue(aircraft, out var runway))
            {
                runway.Free();
                _aircraftToRunway.Remove(aircraft);
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {runway.Id}");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}
