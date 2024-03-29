// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Entities=WPAppStudio.Entities;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// Statistics_Statistics data source.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class Statistics_Statistics : IStatistics_Statistics 
    {
		private const int MaxResults = 10;
        private readonly ObservableCollection<Entities.StatisticsSchema> _data = new ObservableCollection<Entities.StatisticsSchema>
		{
          new Entities.StatisticsSchema
            {
                Id= new Guid("f33fc004-ecd3-4940-b859-d6711803802a"),
                Title=@"Area Code",
                Description=@"510",
			},
          new Entities.StatisticsSchema
            {
                Id= new Guid("d90788f6-6133-43fd-995c-9e6003231dfb"),
                Title=@"Country",
                Description=@"United States",
			},
          new Entities.StatisticsSchema
            {
                Id= new Guid("e799ba34-3f8c-4b1f-8bc3-b8356f16d5e0"),
                Title=@"County",
                Description=@"Alameda",
			},
          new Entities.StatisticsSchema
            {
                Id= new Guid("190571e1-9db6-43ef-9053-d874b817863a"),
                Title=@"Elevation",
                Description=@"161 ft",
			},
          new Entities.StatisticsSchema
            {
                Id= new Guid("af6d98c9-5ca4-4100-a135-d63fa7213fd0"),
                Title=@"Population",
                Description=@"Total: 61,388
Density: 2,690.3/sq mi",
			},
          new Entities.StatisticsSchema
            {
                Id= new Guid("cbfa9c6b-97da-44be-9513-809956cb0637"),
                Title=@"State",
                Description=@"California",
			},
          new Entities.StatisticsSchema
            {
                Id= new Guid("d86a78b7-3c5e-4c97-9d2b-c910fff60350"),
                Title=@"Total Area",
                Description=@"16.919 sq mi",
			},
          new Entities.StatisticsSchema
            {
                Id= new Guid("eff1e0b1-e41c-4ca4-9736-aa14968a0657"),
                Title=@"U.S. Congress",
                Description=@"Eric Swalwell (D)",
			},
          new Entities.StatisticsSchema
            {
                Id= new Guid("7c1a8650-1ec5-4e77-96e7-a5ec237d8b91"),
                Title=@"Zip Codes",
                Description=@"94546, 94552",
			},
		};
	
		
        /// <summary>
        /// Retrieves the data from a static data source, in an observable collection of StatisticsSchema items.
        /// </summary>
        /// <returns>An observable collection of StatisticsSchema items.</returns>
        public ObservableCollection<Entities.StatisticsSchema> GetData(int numPage)
        {								
			return new ObservableCollection<Entities.StatisticsSchema>(_data.Skip(MaxResults * numPage).Take(MaxResults));
        }
		
		/// <summary>
        /// Retrieves the data from a static data source, filtered by a filter specification, in an observable collection of StatisticsSchema items.
        /// </summary>
		/// <param name="filter">Filter operation specification</param>
        /// <returns>An observable collection of StatisticsSchema items.</returns>
        public ObservableCollection<Entities.StatisticsSchema> Search(FilterSpecification filter)
        {
            return RepositoriesBase.Filter<Entities.StatisticsSchema>.FilterCollection(filter, _data);
        }
	}
}
