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
    /// Info_Info ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IInfo_InfoViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentInfo_InfoHtmlControl property.
        /// </summary>
		string CurrentInfo_InfoHtmlControl { get; set; }
        /// <summary>
        /// Gets/Sets the SpecialPlaces_ListListControlCollection property.
        /// </summary>
		ObservableCollection<Entities.specialplacesCollectionSchema> SpecialPlaces_ListListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SpecialPlaces_ListListControlCollectionPageNumber property.
        /// </summary>
		int SpecialPlaces_ListListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedSpecialPlaces_ListListControlCollection property.
        /// </summary>
		Entities.specialplacesCollectionSchema SelectedSpecialPlaces_ListListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the CurrentHistory_InfoHtmlControl property.
        /// </summary>
		string CurrentHistory_InfoHtmlControl { get; set; }
        /// <summary>
        /// Gets/Sets the CurrentGeography_InfoHtmlControl property.
        /// </summary>
		string CurrentGeography_InfoHtmlControl { get; set; }
        /// <summary>
        /// Gets/Sets the Statistics_ListListControlCollection property.
        /// </summary>
		ObservableCollection<Entities.StatisticsSchema> Statistics_ListListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Statistics_ListListControlCollectionPageNumber property.
        /// </summary>
		int Statistics_ListListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedStatistics_ListListControlCollection property.
        /// </summary>
		Entities.StatisticsSchema SelectedStatistics_ListListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshSpecialPlaces_ListListControlCollection command.
        /// </summary>
		ICommand RefreshSpecialPlaces_ListListControlCollection { get; }

        
        /// <summary>
        /// Gets the RefreshStatistics_ListListControlCollection command.
        /// </summary>
		ICommand RefreshStatistics_ListListControlCollection { get; }

        
        /// <summary>
        /// Gets the TextToSpeechInfo_InfoHtmlControlCommand command.
        /// </summary>
		ICommand TextToSpeechInfo_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareInfo_InfoHtmlControlCommand command.
        /// </summary>
		ICommand ShareInfo_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartInfo_InfoHtmlControlCommand command.
        /// </summary>
		ICommand PinToStartInfo_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the TextToSpeechHistory_InfoHtmlControlCommand command.
        /// </summary>
		ICommand TextToSpeechHistory_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareHistory_InfoHtmlControlCommand command.
        /// </summary>
		ICommand ShareHistory_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartHistory_InfoHtmlControlCommand command.
        /// </summary>
		ICommand PinToStartHistory_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the TextToSpeechGeography_InfoHtmlControlCommand command.
        /// </summary>
		ICommand TextToSpeechGeography_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareGeography_InfoHtmlControlCommand command.
        /// </summary>
		ICommand ShareGeography_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartGeography_InfoHtmlControlCommand command.
        /// </summary>
		ICommand PinToStartGeography_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

        
        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
		ICommand AboutCommand { get; }

	}
}
