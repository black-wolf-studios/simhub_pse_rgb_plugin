using System.Collections.Immutable;
using OpenHardwareMonitor.Collections;
using SimHub.Plugins.OutputPlugins.Nextion;

namespace PrecisionSimEngineeringRGBConfigurator
{
    public class USBService
    {
        
        public static void SendRGBValuesToWheel(HeadlightFlashSettings settings)
        {
        }

        private static void SendRGBSignalForButton(uint buttonCode, uint colorCode);

        private static readonly ImmutableDictionary<string, Pair<>> lmxConfiguration { get = {
        }
    }
    }
}