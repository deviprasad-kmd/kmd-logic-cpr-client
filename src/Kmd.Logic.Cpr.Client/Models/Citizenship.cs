// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Cpr.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Citizenship
    {
        /// <summary>
        /// Initializes a new instance of the Citizenship class.
        /// </summary>
        public Citizenship()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Citizenship class.
        /// </summary>
        public Citizenship(string countryName = default(string), string countryCode = default(string))
        {
            CountryName = countryName;
            CountryCode = countryCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryName")]
        public string CountryName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

    }
}
