// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// Statistics_Detail ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IStatistics_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentStatisticsSchema property.
        /// </summary>
		Entities.StatisticsSchema CurrentStatisticsSchema { get; set; }
        
        /// <summary>
        /// Gets the TextToSpeechStatistics_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechStatistics_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareStatistics_DetailStaticControlCommand command.
        /// </summary>
		ICommand ShareStatistics_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartStatistics_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartStatistics_DetailStaticControlCommand { get; }

	}
}
