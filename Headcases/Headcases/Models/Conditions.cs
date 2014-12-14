using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Headcases.Models
{
    public class Conditions
    {
        [Display(Name="Age")]
        public int AGE { get; set; }

        [Display(Name="Minutes since injury")]
        public int MINS_SINCE_INJURY { get; set; }

        [Display(Name = "Glasgow Coma Scale: Eye opening")]
        public GCS_EYE GCS_EYE { get; set; }

        [Display(Name = "Glasgow Coma Scale: Motor response")]
        public GCS_MOTOR GCS_MOTOR { get; set; }

        [Display(Name = "Glasgow Coma Scale: Verbal response")]
        public GCS_VERBAL GCS_VERBAL { get; set; }

        [Display(Name = "Pupil reactiveness (left)")]
        public PUPIL_REACT PUPIL_REACT_LEFT { get; set; }

        [Display(Name = "Pupil reactiveness (right)")]
        public PUPIL_REACT PUPIL_REACT_RIGHT { get; set; }

        [Display(Name = "Cause of injury")]
        public Cause EO_Cause { get; set; }

        public int Outcome { get; set; }

        [Display(Name = "Days in ICU")]
        [JsonProperty("EO_Days ICU")]
        public int EO_Days_ICU { get; set; }

        [Display(Name = "Seizure")]
        public YesNo EO_Seizure { get; set; }

        [Display(Name = "Haematemesis or melaena requiring transfusion")]
        [JsonProperty("EO_Haem or Mel")]
        public YesNo EO_Haem_or_Mel { get; set; }

        [Display(Name = "Wound infection with pus")]
        [JsonProperty("EO_Wound infection")]
        public YesNo EO_Wound_infection { get; set; }

        [Display(Name = "Pneumonia treated with antibiotics")]
        [JsonProperty("EO_Pneumonia TWAB")]
        public YesNo EO_Pneumonia_TWAB { get; set; }

        [Display(Name = "Other treated with antibiotics")]
        [JsonProperty("EO_Other TWAB")]
        public YesNo EO_Other_TWAB { get; set; }

        [Display(Name = "Neurosurgical operation")]
        public YesNo EO_Neurosurgical { get; set; }

        [Display(Name = "Major extracranial injury")]
        [JsonProperty("EO_Major EC injury")]
        public YesNo EO_Major_EC_injury { get; set; }

        [Display(Name = "1 or more petechial haemorrhages within the brain")]
        [JsonProperty("EO_1 or more PH")]
        public YesNo EO_1_or_more_PH { get; set; }

        [Display(Name = "Obliteration of the 3rd ventricle or basal cisterns")]
        [JsonProperty("EO_Obliteration 3rdVorBC")]
        public YesNo EO_Obliteration_3rdVorBC { get; set; }

        [Display(Name = "Subarachnoid bleed")]
        [JsonProperty("EO_Subarachnoid bleed")]
        public YesNo EO_Subarachnoid_bleed { get; set; }

        [Display(Name = "Midline shift >5mm")]
        [JsonProperty("EO_Midline shift >5mm")]
        public YesNo EO_Midline_shift_gt_5mm { get; set; }
    }
}