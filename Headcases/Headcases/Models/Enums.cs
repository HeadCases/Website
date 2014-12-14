using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Headcases.Models
{
    public enum GCS_EYE
    {
        None = 1,
        
        ToPain = 2,

        ToSound = 3,

        Spontaneous = 4
    }

    public enum GCS_MOTOR
    {
        None = 1,

        Extending = 2,

        AbnormalFlexion = 3,

        NormalFlexion = 4,

        Localising = 5,

        ObeysCommands = 6
    }

    public enum GCS_VERBAL
    {
        None = 1,
        Sounds = 2,
        Words = 3,
        ConfusedSpeech = 4,
        Orientated = 5
    }

    public enum YesNo
    {
        Yes = 1,
        No = 2
    }

    public enum PUPIL_REACT
    {
        Yes = 1,
        No = 2,
        UnableToAssess = 3
    }

    public enum Cause
    {
        [Display(Name = "Road Traffic Accident")]
        Traffic = 1,

        [Display(Name = "Fall (>2m)")]
        Fall = 2,

        Other = 3
    }
}