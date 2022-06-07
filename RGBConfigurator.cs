using SimHub.Plugins;
using System;

namespace PrecisionSimEngineeringRGBConfigurator
{
    [PluginDescription("Make RGB on Precision Sim Engineering Wheels adjustable in Simhub")]
    [PluginAuthor("Daniel Weiss")]
    [PluginName("PSE RGB Configurator")]
    public class RGBConfigurator : IPlugin, IWPFSettings
    {

        public HeadlightFlashSettings Settings { get; set; }


        /// <summary>
        /// Instance of the current plugin manager
        /// </summary>
        public PluginManager PluginManager { get; set; }

        /// <summary>
        /// Called at plugin manager stop, close/dispose anything needed here ! 
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void End(PluginManager pluginManager)
        {
            // Save settings
            this.SaveCommonSettings("PrecisionSimEngineeringRGBConfiguratorPrecisionSimEngineeringRGBConfigurator",
                Settings);
        }

        /// <summary>
        /// Returns the settings control, return null if no settings control is required
        /// </summary>
        /// <param name="pluginManager"></param>
        /// <returns></returns>
        public System.Windows.Controls.Control GetWPFSettingsControl(PluginManager pluginManager)
        {
            return new HeadlightFlashSettingsControll(this);
        }

        /// <summary>
        /// Called once after plugins startup
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void Init(PluginManager pluginManager)
        {
            HeadlightFlashSettings defaultValues = new HeadlightFlashSettings();

            // Load settings
            Settings = this.ReadCommonSettings(
                "PrecisionSimEngineeringRGBConfiguratorPrecisionSimEngineeringRGBConfigurator", () => defaultValues);
        }

        public static void SendRGBValuesToWheel(HeadlightFlashSettings settings)
        {

        }
    }
}