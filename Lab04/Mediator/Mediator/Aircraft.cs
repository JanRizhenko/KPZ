using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private CommandCentre _commandCentre;

        public Aircraft(string name, CommandCentre centre)
        {
            this.Name = name;
            this._commandCentre = centre;
        }

        public void RequestLanding()
        {
            _commandCentre.HandleLanding(this);
        }

        public void RequestTakeOff()
        {
            _commandCentre.HandleTakeOff(this);
        }
    }
}
