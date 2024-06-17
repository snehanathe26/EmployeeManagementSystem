﻿using EmployeemanagementSystem.Entities;
using Newtonsoft.Json;

namespace EmployeemanagementSystem.DTO
{
    public class EmployeeAdditionalDetailsDTO
    {
        [JsonProperty("employeeBasicDetailsUId")]
        public string EmployeeBasicDetailsUId { get; set; }

        [JsonProperty("alternateEmail")]
        public string AlternateEmail { get; set; }

        [JsonProperty("alternateMobile")]
        public string AlternateMobile { get; set; }

        [JsonProperty("workInformation")]
        public WorkInfo_ WorkInformation { get; set; }

        [JsonProperty("personalDetails")]
        public PersonalDetails PersonalDetails { get; set; }

        [JsonProperty("identityInformation")]
        public IdentityInfo_ IdentityInformation { get; set; }
    }
}
